using Business.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormUI.View.Moduls.Stoklar
{
    public partial class FrmStokKart : Form
    {
        IStokService _stokService;
        IStokGrupService _stokGrupService;
        IStokGrupKodService _stokGrupKodService;
        FrmStokListe _frmStokListe;
        FrmStokGrup _frmStokGrup;
        public FrmStokKart(IStokService stokService, IStokGrupService stokGrupService, FrmStokListe frmStokListe, FrmStokGrup frmStokGrup, IStokGrupKodService stokGrupKodService)
        {
            InitializeComponent();
            _stokService = stokService;
            _stokGrupService = stokGrupService;
            _frmStokListe = frmStokListe;
            _frmStokGrup = frmStokGrup;
            _stokGrupKodService = stokGrupKodService;
        }

        private void BtnStokBul_Click(object sender, EventArgs e)
        {
            var secilenStok = _frmStokListe.SecimIcinAc();
            txtStokKod.Text = secilenStok.Kod;
            txtStokBarkod.Text = secilenStok.Barkod;
            txtStokAd.Text = secilenStok.Ad;
            txtStokKDV.Text = secilenStok.KDV.ToString();
            txtStokBirim.Text = secilenStok.Birim;
            txtStokBirim2.Text = secilenStok.Birim2;
            txtStokOran2.Text = secilenStok.Birim2Oran.ToString();
            txtStokBirim3.Text = secilenStok.Birim3;
            txtStokOran3.Text = secilenStok.Birim3Oran.ToString();

            var stokGruplari = _stokGrupKodService.GetListByStokId(secilenStok.Id).Data;

            lstGrup.Items.Clear();
            foreach (var item in stokGruplari)
            {
                lstGrup.Items.Add(item.Tur);
                lstGrup.Items[lstGrup.Items.Count - 1].SubItems.Add(item.Ad);
                lstGrup.Items[lstGrup.Items.Count - 1].SubItems.Add(item.Id.ToString());
            }
        }

        private void BtnGrupEkle_Click(object sender, EventArgs e)
        {
            var secilenGrup = _frmStokGrup.SecimIcinAc();
            lstGrup.Items.Add(secilenGrup.Tur);
            lstGrup.Items[lstGrup.Items.Count - 1].SubItems.Add(secilenGrup.Ad);
            lstGrup.Items[lstGrup.Items.Count - 1].SubItems.Add(secilenGrup.Id.ToString());
        }
    }
}