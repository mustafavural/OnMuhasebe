using Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormUI.View.Moduls.Stoklar
{
    public partial class FrmStokKart : FrmBase
    {
        IStokService _stokService;
        IStokGrupService _stokGrupService;
        FrmStokListe _frmStokListe;
        FrmStokGrup _frmStokGrup;
        Stok _secilenStok;

        public FrmStokKart(IStokService stokService, IStokGrupService stokGrupService, FrmStokListe frmStokListe, FrmStokGrup frmStokGrup)
        {
            InitializeComponent();
            _stokService = stokService;
            _stokGrupService = stokGrupService;
            _frmStokListe = frmStokListe;
            _frmStokGrup = frmStokGrup;
        }

        #region Events

        private void FrmStokKart_Load(object sender, EventArgs e)
        {
            var stoklar = _stokService.GetList();
            if (stoklar.Success)
                dgvStokListe.DataSource = stoklar.Data;
            else
                MessageBox.Show(stoklar.Message);
        }

        private void TxtStokKod_Leave(object sender, EventArgs e)
        {
            if (txtStokKod.Text != "")
            {
                _secilenStok = _stokService.GetByKod(txtStokKod.Text).Data;
                WriteToScreen(_secilenStok);
            }
        }

        private void BtnStokBul_Click(object sender, EventArgs e)
        {
            var secilenStok = _frmStokListe.SecimIcinAc();
            if (secilenStok != null)
            {
                _secilenStok = secilenStok;
                WriteToScreen(secilenStok);
            }
        }

        private void BtnGrupEkle_Click(object sender, EventArgs e)
        {
            var secilenGrup = _frmStokGrup.SecimIcinAc();
            if (secilenGrup != null)
                AddOneToGroupList(secilenGrup);
        }

        private void BtnGrupSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgvGrupView.SelectedRows)
                dgvGrupView.Rows.Remove(item);
        }

        private void UscStokEkleSilButon_ClickEkraniTemizle(object sender, EventArgs e)
        {
            txtStokKod.Clear();
            txtStokBarkod.Clear();
            txtStokAd.Clear();
            txtStokKDV.Clear();
            txtStokBirim.Clear();
            txtStokBirim2.Clear();
            txtStokOran2.Clear();
            txtStokBirim3.Clear();
            txtStokOran3.Clear();

            dgvGrupView.Rows.Clear();

            uscStokEkleSilButon.BtnSave_Text = "Ekle";
            uscStokEkleSilButon.BtnDelete_Enable = false;
            _secilenStok = null;

            FrmStokKart_Load(sender, e);
        }

        private void UscStokEkleSilButon_ClickEkleGuncelle(object sender, EventArgs e)
        {
            ReadFromScreen(out Stok stok, out List<StokGrupKod> stokGrupKodlar);
            if (stok != null && stokGrupKodlar != null)
            {
                if (_secilenStok == null)
                {
                    var added = AddStok(stok, out int addedId);
                    if (added.Success)
                        foreach (var group in stokGrupKodlar)
                        {
                            var groupAdded = AddOneGroupToStok(addedId, group.Id);
                            if (groupAdded.Success) UscStokEkleSilButon_ClickEkraniTemizle(sender, e);
                            else MessageBox.Show(groupAdded.Message);
                        }
                    else MessageBox.Show(added.Message);
                }
                else
                {
                    var updated = UpdateStok(stok);
                    if (updated.Success)
                    {
                        var groupUpdated = UpdateStokGroups(_secilenStok.Id, stokGrupKodlar);
                        if (groupUpdated.Success) UscStokEkleSilButon_ClickEkraniTemizle(sender, e);
                        else MessageBox.Show(groupUpdated.Message);
                    }
                    else MessageBox.Show(updated.Message);
                }
            }
        }

        private void UscStokEkleSilButon_ClickSecileniSil(object sender, EventArgs e)
        {
            var groupsResult = _stokService.GetListStokGrupKod(_secilenStok.Id).Data;
            foreach (var item in groupsResult)
            {
                var deleteResult = DeleteOneGroupFromStok(_secilenStok.Id, item.Id);
                if (!deleteResult.Success)
                    MessageBox.Show(deleteResult.Message);
            }

            var deletedResult = DeleteStok(_secilenStok);
            if (deletedResult.Success)
                UscStokEkleSilButon_ClickEkraniTemizle(sender, e);
            MessageBox.Show(deletedResult.Message);
        }

        private void DgvStokListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var ciftTiklanan = (Stok)dgvStokListe.SelectedRows[0].DataBoundItem;
            _secilenStok = _stokService.GetById(ciftTiklanan.Id).Data;
            WriteToScreen(_secilenStok);
        }

        #region KeyEvents
        private void HarfEngelle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((TextBox)sender).Text.Contains(','))
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            else
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void TxtStokBirim_TextChanged(object sender, EventArgs e)
        {
            txtStokBirim2.Enabled = txtStokBirim.Text != "";
            TxtStokBirim2_TextChanged(sender, e);
        }

        private void TxtStokBirim2_TextChanged(object sender, EventArgs e)
        {
            txtStokOran2.Enabled = txtStokBirim2.Text != "" && txtStokBirim2.Enabled;
            TxtStokOran2_TextChanged(sender, e);
        }

        private void TxtStokOran2_TextChanged(object sender, EventArgs e)
        {
            txtStokBirim3.Enabled = txtStokOran2.Text != "" && txtStokOran2.Enabled;
            TxtStokBirim3_TextChanged(sender, e);
        }

        private void TxtStokBirim3_TextChanged(object sender, EventArgs e)
        {
            txtStokOran3.Enabled = txtStokBirim3.Text != "" && txtStokBirim3.Enabled;
        }
        #endregion

        #endregion

        #region PrivateMethods

        private IResult AddStok(Stok stok, out int Id)
        {
            try
            {
                var stokResult = _stokService.Add(stok);
                var addedStok = _stokService.GetByKod(stok.Kod);
                Id = addedStok.Data.Id;
                return stokResult;
            }
            catch (Exception err)
            {
                Id = -1;
                return new ErrorResult(err.Message);
            }
        }

        private IResult DeleteStok(Stok stok)
        {
            try
            {
                stok.Id = _secilenStok.Id;
                var result = _stokService.Delete(stok);
                _secilenStok = stok;
                return result;
            }
            catch (Exception err)
            {
                return new ErrorResult(err.Message);
            }
        }

        private IResult UpdateStok(Stok stok)
        {
            try
            {
                stok.Id = _secilenStok.Id;
                var result = _stokService.Update(stok);
                _secilenStok = stok;
                return result;
            }
            catch (Exception err)
            {
                return new ErrorResult(err.Message);
            }
        }

        private IResult UpdateStokGroups(int stokId, List<StokGrupKod> stokGrupKodlar)
        {
            List<StokGrupKod> mevcutlar = _stokService.GetListStokGrupKod(stokId).Data;

            var eklenecekler = stokGrupKodlar.Where(s => !mevcutlar.Exists(m => m.Id == s.Id)).ToList();
            var silinecekler = mevcutlar.Where(m => !stokGrupKodlar.Exists(s => s.Id == m.Id)).ToList();

            foreach (var item in eklenecekler)
            {
                var addGrupResult = AddOneGroupToStok(stokId, item.Id);
                if (!addGrupResult.Success)
                    return new ErrorResult(addGrupResult.Message);
            }

            foreach (var item in silinecekler)
            {
                var deleteGrupResult = DeleteOneGroupFromStok(stokId, item.Id);
                if (!deleteGrupResult.Success)
                    return new ErrorResult(deleteGrupResult.Message);
            }

            return new SuccessResult();
        }

        private IResult AddOneGroupToStok(int stokId, int stokGrupKodId)
        {
            var stok = new StokGrup { StokGrupKodId = stokGrupKodId, StokId = stokId };
            try
            {
                return _stokGrupService.Add(stok);
            }
            catch (Exception err)
            {
                return new ErrorResult(err.Message);
            }
        }

        private IResult DeleteOneGroupFromStok(int stokId, int stokGrupKodId)
        {
            var relation = _stokGrupService.GetByBothId(stokId, stokGrupKodId).Data;
            try
            {
                return _stokGrupService.Delete(relation);
            }
            catch(Exception err)
            {
                return new ErrorResult(err.Message);
            }
        }

        private void ReadFromScreen(out Stok stok, out List<StokGrupKod> stokGrupKodlar)
        {
            stok = new Stok();
            stok.Kod = txtStokKod.Text;
            stok.Barkod = txtStokBarkod.Text;
            stok.Ad = txtStokAd.Text;
            int.TryParse(txtStokKDV.Text.Split(",", 2)[0], out int kdv);
            stok.KDV = kdv;
            stok.Birim = txtStokBirim.Text;
            stok.Birim2 = txtStokBirim2.Enabled ? txtStokBirim2.Text : "";
            decimal.TryParse(txtStokOran2.Text, out decimal oran2);
            stok.Birim2Oran = txtStokBirim2.Enabled && txtStokBirim2.Text != "" ? oran2 : 0.0m;
            stok.Birim3 = txtStokBirim3.Enabled ? txtStokBirim3.Text : "";
            decimal.TryParse(txtStokOran3.Text, out decimal oran3);
            stok.Birim3Oran = txtStokBirim3.Enabled && txtStokBirim3.Text != "" ? oran3 : 0.0m;

            stokGrupKodlar = new List<StokGrupKod>();
            foreach (DataGridViewRow item in dgvGrupView.Rows)
                stokGrupKodlar.Add(
                    new StokGrupKod
                    {
                        Id = Convert.ToInt32(item.Cells[0].Value),
                        Tur = item.Cells[1].Value.ToString(),
                        Ad = item.Cells[2].Value.ToString()
                    });
        }

        private void WriteToScreen(Stok secilenStok)
        {
            if (secilenStok != null)
            {
                txtStokKod.Text = secilenStok.Kod;
                txtStokBarkod.Text = secilenStok.Barkod;
                txtStokAd.Text = secilenStok.Ad;
                txtStokKDV.Text = secilenStok.KDV.ToString();
                txtStokBirim.Text = secilenStok.Birim;
                txtStokBirim2.Text = secilenStok.Birim2;
                txtStokOran2.Text = secilenStok.Birim2Oran.ToString();
                txtStokBirim3.Text = secilenStok.Birim3;
                txtStokOran3.Text = secilenStok.Birim3Oran.ToString();

                var stokGruplari = _stokService.GetListStokGrupKod(secilenStok.Id).Data;
                dgvGrupView.Rows.Clear();
                foreach (var item in stokGruplari)
                    AddOneToGroupList(item);

                uscStokEkleSilButon.BtnSave_Text = "Güncelle";
                uscStokEkleSilButon.BtnDelete_Enable = true;
            }
        }

        private void AddOneToGroupList(StokGrupKod grupKod) =>
            dgvGrupView.Rows[dgvGrupView.Rows.Add()].SetValues(grupKod.Id, grupKod.Tur, grupKod.Ad);
        #endregion
    }
}