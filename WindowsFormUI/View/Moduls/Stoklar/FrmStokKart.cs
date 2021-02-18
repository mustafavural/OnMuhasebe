using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
        public FrmStokKart(IStokService stokService, IStokGrupService stokGrupService, FrmStokListe frmStokListe, FrmStokGrup frmStokGrup, IStokGrupKodService stokGrupKodService)
        {
            InitializeComponent();
            _stokService = stokService;
            _stokGrupService = stokGrupService;
            _frmStokListe = frmStokListe;
            _frmStokGrup = frmStokGrup;
            _stokGrupKodService = stokGrupKodService;
        }

        private void FrmStokKart_Load(object sender, EventArgs e)
        {
            this.uscStokEkleSilButon.BtnSave_Text = "Ekle";
            this.uscStokEkleSilButon.BtnDelete_Enable = false;
            var stoklar = _stokService.GetList();

            if (stoklar.Success)
                dgvStokListe.DataSource = stoklar.Data;
            else
                MessageBox.Show(stoklar.Message);
        }

        private void BtnStokBul_Click(object sender, EventArgs e)
        {
            var secilenStok = _frmStokListe.SecimIcinAc();
            GetirSecilenStok(secilenStok);
        }

        private void GetirSecilenStok(Stok secilenStok)
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
            }

            var stokGruplari = _stokGrupKodService.GetListByStokId(secilenStok.Id);

            if (stokGruplari.Success)
            {
                lstGrup.Items.Clear();
                foreach (var item in stokGruplari.Data)
                {
                    lstGrup.Items.Add(item.Tur);
                    lstGrup.Items[lstGrup.Items.Count - 1].SubItems.Add(item.Ad);
                    lstGrup.Items[lstGrup.Items.Count - 1].SubItems.Add(item.Id.ToString());
                }
            }
            else
                MessageBox.Show(stokGruplari.Message);
        }

        private void BtnGrupEkle_Click(object sender, EventArgs e)
        {
            var secilenGrup = _frmStokGrup.SecimIcinAc();
            if (secilenGrup != null)
            {
                lstGrup.Items.Add(secilenGrup.Tur);
                lstGrup.Items[lstGrup.Items.Count - 1].SubItems.Add(secilenGrup.Ad);
                lstGrup.Items[lstGrup.Items.Count - 1].SubItems.Add(secilenGrup.Id.ToString());
            }
        }

        private void DgvStokListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var secilenStok = _stokService.GetById((int)dgvStokListe.SelectedRows[0].Cells[0].Value);

            if (secilenStok.Success)
            {
                _secilenStok = secilenStok.Data;
                GetirSecilenStok(secilenStok.Data);

                this.uscStokEkleSilButon.BtnSave_Text = "Guncelle";
                this.uscStokEkleSilButon.BtnDelete_Enable = true;
            }
            else
                MessageBox.Show(secilenStok.Message);
        }

        private void UscStokEkleSilButon_ClickEkleGuncelle(object sender, EventArgs e)
        {
            Stok stok;
            List<StokGrupKod> stokGrupKodlar;
            if (_secilenStok == null)
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
                foreach (ListViewItem item in lstGrup.Items)
                {
                    stokGrupKodlar.Add(new StokGrupKod { Tur = item.ToString(), Ad = item.SubItems[1].Text });
                }
            }

            UscStokEkleSilButon_ClickEkraniTemizle(sender, e);
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

            lstGrup.Items.Clear();

            this.uscStokEkleSilButon.BtnSave_Text = "Ekle";
            this.uscStokEkleSilButon.BtnDelete_Enable = false;
        }

        private void UscStokEkleSilButon_ClickSecileniSil(object sender, EventArgs e)
        {
            if (_secilenStok != null)
            {
                var result = _stokService.Delete(_secilenStok);
                MessageBox.Show(result.Message);
            }
            else
                MessageBox.Show("İç Hata! Butonun pasif olması gerekirdi.", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            UscStokEkleSilButon_ClickEkraniTemizle(sender, e);
        }
    }
}