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
        IStokGrupKodService _stokGrupKodService;
        FrmStokListe _frmStokListe;
        FrmStokGrup _frmStokGrup;
        Stok _secilenStok;

        public FrmStokKart(IStokService stokService, IStokGrupService stokGrupService, IStokGrupKodService stokGrupKodService, FrmStokListe frmStokListe, FrmStokGrup frmStokGrup)
        {
            InitializeComponent();
            _stokService = stokService;
            _stokGrupService = stokGrupService;
            _stokGrupKodService = stokGrupKodService;
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

        private void BtnStokBul_Click(object sender, EventArgs e)
        {
            var secilenStok = _frmStokListe.SecimIcinAc();
            if (secilenStok != null)
                WriteToScreen(secilenStok);
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
        }

        private void UscStokEkleSilButon_ClickEkleGuncelle(object sender, EventArgs e)
        {
            ReadFromScreen(out Stok stok, out List<StokGrupKod> stokGrupKodlar);

            if (_secilenStok == null)
            {
                var newStokId = AddStok(stok);
                if (newStokId > 0)
                {
                    foreach (var group in stokGrupKodlar)
                    {
                        AddOneGroupToStok(newStokId, group.Id);
                    }
                    UscStokEkleSilButon_ClickEkraniTemizle(sender, e);
                }
            }
            else
            {
                var stokResult = UpdateStok(stok);
                if (stokResult.Success)
                {
                    var grupResult = UpdateStokGroups(stok.Id, stokGrupKodlar);
                    if (grupResult.Success)
                        UscStokEkleSilButon_ClickEkraniTemizle(sender, e);
                    else
                        MessageBox.Show("Herhangi bir grup güncellenemedi");
                }
                MessageBox.Show(stokResult.Message);
            }
        }

        private void UscStokEkleSilButon_ClickSecileniSil(object sender, EventArgs e)
        {
            var groupsResult = _stokService.GetListStokGrupKod(_secilenStok.Id);
            if (groupsResult.Success)
                foreach (var item in groupsResult.Data)
                    DeleteOneGroupFromStok(_secilenStok.Id, item.Id);
            else
                MessageBox.Show(groupsResult.Message);

            var stokResult = _stokService.Delete(_secilenStok);
            if (stokResult.Success)
                UscStokEkleSilButon_ClickEkraniTemizle(sender, e);
            MessageBox.Show(stokResult.Message);
        }

        private void DgvStokListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var secilenStok = _stokService.GetById((int)dgvStokListe.SelectedRows[0].Cells[0].Value);

            if (secilenStok.Success)
            {
                _secilenStok = secilenStok.Data;
                WriteToScreen(secilenStok.Data);
            }
            else
                MessageBox.Show(secilenStok.Message);
        }

        private void HarfEngelle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((TextBox)sender).Text.Contains(','))
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            else
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }
        #endregion

        #region PrivateMethods

        private int AddStok(Stok stok)
        {
            var stokResult = _stokService.Add(stok);
            if (stokResult.Success)
                return _stokService.GetByKod(stok.Kod).Data.Id;
            else
            {
                MessageBox.Show(stokResult.Message);
                return -1;
            }
        }

        private IResult UpdateStok(Stok stok)
        {
            _secilenStok.Kod = stok.Kod;
            _secilenStok.Barkod = stok.Barkod;
            _secilenStok.Ad = stok.Ad;
            _secilenStok.KDV = stok.KDV;
            _secilenStok.Birim = stok.Birim;
            _secilenStok.Birim2 = stok.Birim2;
            _secilenStok.Birim2Oran = stok.Birim2Oran;
            _secilenStok.Birim3 = stok.Birim3;
            _secilenStok.Birim3Oran = stok.Birim3Oran;

            return _stokService.Update(_secilenStok);
        }

        private void AddOneGroupToStok(int stokId, int stokGrupKodId)
        {
            var addResult = _stokGrupService.Add(new StokGrup { StokGrupKodId = stokGrupKodId, StokId = stokId });
            if (!addResult.Success)
                MessageBox.Show(addResult.Message);
        }

        private void DeleteOneGroupFromStok(int stokId, int stokGrupKodId)
        {
            var relation = _stokGrupService.GetByBothId(stokId, stokGrupKodId);
            if (relation.Success)
            {
                var deleteResult = _stokGrupService.Delete(relation.Data);
                if (!deleteResult.Success)
                    MessageBox.Show(deleteResult.Message);
            }
            else
                MessageBox.Show(relation.Message);
        }

        private IResult UpdateStokGroups(int stokId, List<StokGrupKod> stokGrupKodlar)
        {
            List<StokGrupKod> mevcutlar = _stokService.GetListStokGrupKod(stokId).Data;
            foreach (var item in stokGrupKodlar)
            {
                if (mevcutlar.Contains(item))
                    continue;
                else
                    AddOneGroupToStok(stokId, item.Id);
            }
            foreach (var item in mevcutlar)
            {
                if (stokGrupKodlar.Contains(item))
                    continue;
                else
                    _stokGrupService.Delete(new StokGrup { StokId = stokId, StokGrupKodId = item.Id });
            }
            return null;
        }

        private void ReadFromScreen(out Stok stok, out List<StokGrupKod> stokGrupKodlar)
        {
            stok = new Stok();

            if (txtStokKod.Text == "")
                MessageBox.Show("Stok Kod Boş Olamaz");
            else stok.Kod = txtStokKod.Text;

            if (txtStokAd.Text == "") 
                MessageBox.Show("Stok Ad Boş Olamaz");
            else stok.Ad = txtStokAd.Text;

            if (txtStokKDV.Text == "") 
                MessageBox.Show("Stok KDV Boş Olamaz");
            else stok.KDV = Convert.ToInt32(txtStokKDV.Text);

            if (txtStokBirim.Text == "")
                if (txtStokBirim2.Text != "" || txtStokBirim3.Text != "")
                    MessageBox.Show("İlk Birim girilmemişken ikinci veya üçüncüsünü giremezsiniz");

            stokGrupKodlar = new List<StokGrupKod>();
            foreach (DataGridViewRow item in dgvGrupView.Rows)
                stokGrupKodlar.Add((StokGrupKod)item.DataBoundItem);
        }

        private void WriteToScreen(Stok secilenStok)
        {
            StokBilgileriniGoruntule(secilenStok);

            var stokGruplari = _stokService.GetListStokGrupKod(secilenStok.Id);
            if (stokGruplari.Success)
            {
                dgvGrupView.Rows.Clear();
                foreach (var item in stokGruplari.Data)
                    AddOneToGroupList(item);
            }
            else
                MessageBox.Show(stokGruplari.Message);

            uscStokEkleSilButon.BtnSave_Text = "Güncelle";
            uscStokEkleSilButon.BtnDelete_Enable = true;
        }

        private void StokBilgileriniGoruntule(Stok stok)
        {
            txtStokKod.Text = stok.Kod;
            txtStokBarkod.Text = stok.Barkod;
            txtStokAd.Text = stok.Ad;
            txtStokKDV.Text = stok.KDV.ToString();
            txtStokBirim.Text = stok.Birim;
            txtStokBirim2.Text = stok.Birim2;
            txtStokOran2.Text = stok.Birim2Oran.ToString();
            txtStokBirim3.Text = stok.Birim3;
            txtStokOran3.Text = stok.Birim3Oran.ToString();
        }

        private void AddOneToGroupList(StokGrupKod stokGrupKod)
        {
            var rowIndex = dgvGrupView.Rows.Add();
            dgvGrupView.Rows[rowIndex].Cells["colGrupId"].Value = stokGrupKod.Id;
            dgvGrupView.Rows[rowIndex].Cells["colGrupTur"].Value = stokGrupKod.Tur;
            dgvGrupView.Rows[rowIndex].Cells["colGrupAd"].Value = stokGrupKod.Ad;
        }
        #endregion
    }
}