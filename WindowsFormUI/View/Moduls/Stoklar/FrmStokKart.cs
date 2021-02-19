using Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormUI.View.Moduls.Stoklar
{
    public partial class FrmStokKart : FrmBase
    {
        IStokService _stokService;
        IStokGrupService _stokGrupService;
        IStokGrupKodService _stokGrupKodService;//TODO:Stoğa ait grupları getir işlemini stokservisine al
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

        private void FrmStokKart_Load(object sender, EventArgs e)
        {
            uscStokEkleSilButon.BtnSave_Text = "Ekle";
            uscStokEkleSilButon.BtnDelete_Enable = false;
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
                GetirSecilenStok(secilenStok);
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

        private void GrupBilgileriniGoruntule(StokGrupKod stokGrupKod)
        {
            var rowIndex = dgvGrupView.Rows.Add();
            dgvGrupView.Rows[rowIndex].Cells["colGrupId"].Value = stokGrupKod.Id;
            dgvGrupView.Rows[rowIndex].Cells["colGrupTur"].Value = stokGrupKod.Tur;
            dgvGrupView.Rows[rowIndex].Cells["colGrupAd"].Value = stokGrupKod.Ad;
        }

        private void GetirSecilenStok(Stok secilenStok)
        {
            StokBilgileriniGoruntule(secilenStok);

            var stokGruplari = _stokGrupKodService.GetListByStokId(secilenStok.Id);
            if (stokGruplari.Success)
            {
                dgvGrupView.Rows.Clear();
                foreach (var item in stokGruplari.Data)
                    GrupBilgileriniGoruntule(item);
            }
            else
                MessageBox.Show(stokGruplari.Message);
        }

        private void EkrandakiBilgileriGetir(out Stok stok, out List<StokGrupKod> stokGrupKodlar)
        {
            stok = new Stok
            {
                Kod = txtStokKod.Text,
                Barkod = txtStokBarkod.Text,
                Ad = txtStokAd.Text,
                KDV = Convert.ToInt32(txtStokKDV.Text),
                Birim = txtStokBirim.Text,
                Birim2 = txtStokBirim2.Text,
                Birim2Oran = Convert.ToDecimal(txtStokOran2.Text),
                Birim3 = txtStokBirim3.Text,
                Birim3Oran = Convert.ToDecimal(txtStokOran3.Text)
            };

            stokGrupKodlar = new List<StokGrupKod>();
            foreach (DataGridViewRow item in dgvGrupView.Rows)
                stokGrupKodlar.Add((StokGrupKod)item.DataBoundItem);
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

        private void BtnGrupEkle_Click(object sender, EventArgs e)
        {
            var secilenGrup = _frmStokGrup.SecimIcinAc();
            if (secilenGrup != null)
                GrupBilgileriniGoruntule(secilenGrup);
        }

        private void DgvStokListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var secilenStok = _stokService.GetById((int)dgvStokListe.SelectedRows[0].Cells[0].Value);

            if (secilenStok.Success)
            {
                _secilenStok = secilenStok.Data;
                GetirSecilenStok(secilenStok.Data);

                uscStokEkleSilButon.BtnSave_Text = "Guncelle";
                uscStokEkleSilButon.BtnDelete_Enable = true;
            }
            else
                MessageBox.Show(secilenStok.Message);
        }

        private void UscStokEkleSilButon_ClickEkleGuncelle(object sender, EventArgs e)
        {
            Stok stok;
            List<StokGrupKod> stokGrupKodlar;
            EkrandakiBilgileriGetir(out stok, out stokGrupKodlar);

            if (_secilenStok == null)
            {
                var stokResult = _stokService.Add(stok);
                if(stokResult.Success)
                    UscStokEkleSilButon_ClickEkraniTemizle(sender, e);
                MessageBox.Show(stokResult.Message);
                /*
                 * TODO:Grupları kaydet
                 */

            }
            else
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

                var stokResult = _stokService.Update(_secilenStok);
                if(stokResult.Success)
                    UscStokEkleSilButon_ClickEkraniTemizle(sender, e);
                MessageBox.Show(stokResult.Message);
                /*
                 * TODO:Grupları güncelle
                 */
            }
        }

        private void UscStokEkleSilButon_ClickSecileniSil(object sender, EventArgs e)
        {
            /*
             * TODO:Grupları sil
             */
            IResult result = _stokService.Delete(_secilenStok);
            if (result.Success)
                UscStokEkleSilButon_ClickEkraniTemizle(sender, e);
            MessageBox.Show(result.Message);
        }
    }
}