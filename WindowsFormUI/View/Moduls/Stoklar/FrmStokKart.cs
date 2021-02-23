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
            if (stok != null && stokGrupKodlar != null)
                if (_secilenStok == null)
                {
                    var newStokId = AddStok(stok);
                    if (newStokId > 0)
                    {
                        foreach (var group in stokGrupKodlar)
                            AddOneGroupToStok(newStokId, group.Id);
                        UscStokEkleSilButon_ClickEkraniTemizle(sender, e);
                    }
                }
                else
                {
                    var stokResult = UpdateStok(stok);
                    if (stokResult.Success)
                    {
                        UpdateStokGroups(stok.Id, stokGrupKodlar);
                        UscStokEkleSilButon_ClickEkraniTemizle(sender, e);
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

        private void UpdateStokGroups(int stokId, List<StokGrupKod> stokGrupKodlar)
        {
            List<StokGrupKod> mevcutlar = _stokService.GetListStokGrupKod(stokId).Data;
            foreach (var item in stokGrupKodlar)
                if (!mevcutlar.Contains(item))
                    AddOneGroupToStok(stokId, item.Id);

            foreach (var item in mevcutlar)
                if (!stokGrupKodlar.Contains(item))
                    DeleteOneGroupFromStok(stokId, item.Id);
        }

        private List<string> CheckIfInputErrors()
        {
            List<string> errors = new List<string>();
            if (txtStokKod.Text == "")
                errors.Add("Stok Kodu Boş Olamaz");

            if (txtStokAd.Text == "")
                errors.Add("Stok Adı Boş Olamaz");

            if (txtStokKDV.Text == "")
                errors.Add("Stok KDV'si Boş Olamaz");

            if (txtStokBirim.Text == "")
                errors.Add("Stok Birimi Boş Olamaz");

            if (txtStokOran2.Text == "" && txtStokBirim2.Enabled && txtStokBirim2.Text != "")
                errors.Add("Stok 2. Birimi Girilmiş İken Oranı Boş Olamaz");

            if (txtStokOran3.Text == "" && txtStokBirim3.Enabled && txtStokBirim3.Text != "")
                errors.Add("Stok 3. Birimi Girilmiş İken Oranı Boş Olamaz");

            if (txtStokOran2.Text == txtStokOran3.Text && txtStokOran2.Enabled && txtStokOran3.Enabled)
                errors.Add("2. ve 3. Oran Birbiriyle Aynı Olamaz");

            return errors;
        }

        private void ReadFromScreen(out Stok stok, out List<StokGrupKod> stokGrupKodlar)
        {
            var hatalar = CheckIfInputErrors();

            if (hatalar.Count == 0)
            {
                stok = new Stok
                {
                    Kod = txtStokKod.Text,
                    Barkod = txtStokBarkod.Text,
                    Ad = txtStokAd.Text,
                    KDV = Convert.ToInt32(txtStokKDV.Text.Split(",", 2)[0]),
                    Birim = txtStokBirim.Text,
                    Birim2 = txtStokBirim2.Enabled ? txtStokBirim2.Text : "",
                    Birim2Oran = txtStokBirim2.Enabled && txtStokBirim2.Text != "" ? Convert.ToDecimal(txtStokOran2.Text) : 0.0m,
                    Birim3 = txtStokBirim3.Enabled ? txtStokBirim3.Text : "",
                    Birim3Oran = txtStokBirim3.Enabled && txtStokBirim3.Text != "" ? Convert.ToDecimal(txtStokOran3.Text) : 0.0m
                };

                stokGrupKodlar = new List<StokGrupKod>();
                foreach (DataGridViewRow item in dgvGrupView.Rows)//TODO: burada grup okurken hata var
                    stokGrupKodlar.Add((StokGrupKod)item.DataBoundItem);
            }
            else
            {
                string result = "";
                foreach (var item in hatalar)
                    result += "--> " + item + "\n\n";
                MessageBox.Show("Aşağıdaki hataları gözden geçirin...\n\n" + result,
                    "Stok Bilgileri Eksik !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                stok = null;
                stokGrupKodlar = null;
            }
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