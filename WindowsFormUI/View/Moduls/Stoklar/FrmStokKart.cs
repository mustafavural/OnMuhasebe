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
        FrmStokListe _frmStokListe;
        FrmStokGrup _frmStokGrup;
        StoklarController _stoklarController;
        Stok _secilenStok;

        public FrmStokKart(IStokService stokService, IStokGrupService stokGrupService, FrmStokListe frmStokListe, FrmStokGrup frmStokGrup)
        {
            InitializeComponent();
            _stokService = stokService;
            _frmStokListe = frmStokListe;
            _frmStokGrup = frmStokGrup;
            _stoklarController = new StoklarController(stokService, stokGrupService, _secilenStok);
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
            var turList = new List<string>();
            foreach (DataGridViewRow item in dgvGrupView.Rows)
                turList.Add(item.Cells[1].Value.ToString());

            var secilenGrup = _frmStokGrup.SecimIcinAc(turList);
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
                    var added = _stoklarController.AddStok(stok, out int addedId);
                    if (added.Success)
                        foreach (var group in stokGrupKodlar)
                        {
                            var groupAdded = _stoklarController.AddOneGroupToStok(addedId, group.Id);
                            if (groupAdded.Success) UscStokEkleSilButon_ClickEkraniTemizle(sender, e);
                            else MessageBox.Show(groupAdded.Message);
                        }
                    MessageBox.Show(added.Message);
                }
                else
                {
                    var updated = _stoklarController.UpdateStok(stok);
                    if (updated.Success)
                    {
                        var groupUpdated = _stoklarController.UpdateStokGroups(_secilenStok.Id, stokGrupKodlar);
                        if (groupUpdated.Success) UscStokEkleSilButon_ClickEkraniTemizle(sender, e);
                        else MessageBox.Show(groupUpdated.Message);
                    }
                    MessageBox.Show(updated.Message);
                }
            }
        }

        private void UscStokEkleSilButon_ClickSecileniSil(object sender, EventArgs e)
        {
            var groupsResult = _stokService.GetListStokGrupKod(_secilenStok.Id).Data;
            foreach (var item in groupsResult)
            {
                var deleteResult = _stoklarController.DeleteOneGroupFromStok(_secilenStok.Id, item.Id);
                if (!deleteResult.Success)
                    MessageBox.Show(deleteResult.Message);
            }

            var deletedResult = _stoklarController.DeleteStok(_secilenStok);
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
        #endregion

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

        #region PrivateMethods
        private void ReadFromScreen(out Stok stok, out List<StokGrupKod> stokGrupKodlar)
        {
            int.TryParse(txtStokKDV.Text.Split(",", 2)[0], out int kdv);
            decimal.TryParse(txtStokOran2.Text, out decimal oran2);
            decimal.TryParse(txtStokOran3.Text, out decimal oran3);
            stok = new Stok
            {
                Kod = txtStokKod.Text,
                Barkod = txtStokBarkod.Text,
                Ad = txtStokAd.Text,
                KDV = kdv,
                Birim = txtStokBirim.Text,
                Birim2 = txtStokBirim2.Enabled ? txtStokBirim2.Text : "",
                Birim2Oran = txtStokBirim2.Enabled && txtStokBirim2.Text != "" ? oran2 : 0.0m,
                Birim3 = txtStokBirim3.Enabled ? txtStokBirim3.Text : "",
                Birim3Oran = txtStokBirim3.Enabled && txtStokBirim3.Text != "" ? oran3 : 0.0m
            };

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

        private void AddOneToGroupList(StokGrupKod grupKod)
        {
            int newIndex = dgvGrupView.Rows.Add();
            dgvGrupView.Rows[newIndex].SetValues(grupKod.Id, grupKod.Tur, grupKod.Ad);
        }
        #endregion
    }
}