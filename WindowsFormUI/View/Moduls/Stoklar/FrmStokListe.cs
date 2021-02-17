using Business.Abstract;
using Core.Utilities.Result;
using System;
using System.Collections.Generic;
using Entities.Concrete;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace WindowsFormUI.View.Moduls.Stoklar
{
    public partial class FrmStokListe : FrmBase
    {
        IStokService _stokService;
        IStokGrupKodService _stokGrupKodService;
        IDataResult<List<Stok>> _stokResult;
        FrmStokGrup _frmStokGrup;
        StokGrupKod _secilenGrup;
        public FrmStokListe(IStokService stokService, FrmStokGrup frmStokGrup, IStokGrupKodService stokGrupService)
        {
            InitializeComponent();
            _stokService = stokService;
            _frmStokGrup = frmStokGrup;
            _stokGrupKodService = stokGrupService;
        }

        private void ListeyiYenile()
        {
            dgvStokListe.DataSource = _stokResult.Data
                .Where(kod =>
                {
                    return kod.Kod.Contains(txtStokKod.Text.ToUpper());
                }).Where(bar =>
                {
                    return bar.Barkod.Contains(txtBarkod.Text.ToUpper());
                }).Where(ad =>
                {
                    return ad.Ad.Contains(txtStokAd.Text.ToUpper());
                }).Where(kdv =>
                {
                    return kdv.KDV.ToString().Contains(txtKDV.Text.ToUpper());
                }).Where(grup =>
                {
                    if (lstGrupView.Items.Count == 0)
                        return true;
                    else
                    {
                        var stokGruplar = _stokGrupKodService.GetListByStok(grup.Id).Data;
                        foreach (var item in stokGruplar)
                        {
                            for (int i = 0; i < lstGrupView.Items.Count; i++)
                            {
                                if (item.Id.ToString() == lstGrupView.Items[i].SubItems[2].Text)
                                    return true;
                            }
                        }
                        return false;
                    }
                }).Select(s => new { s.Kod, s.Barkod, s.Ad }).ToList();
        }

        private void FrmStokListe_Load(object sender, EventArgs e)
        {
            _stokResult = _stokService.GetList();
            if (_stokResult.Success)
                dgvStokListe.DataSource = _stokResult.Data.Select(s => new { s.Kod, s.Barkod, s.Ad }).ToList();
            else
                MessageBox.Show(_stokResult.Message);
        }

        private void BtnStokGrupEkle_Click(object sender, EventArgs e)
        {
            _secilenGrup = _frmStokGrup.SecimIcinAc();
            lstGrupView.Items.Add(_secilenGrup.Tur);
            lstGrupView.Items[lstGrupView.Items.Count - 1].SubItems.Add(_secilenGrup.Ad);
            lstGrupView.Items[lstGrupView.Items.Count - 1].SubItems.Add(_secilenGrup.Id.ToString());
            ListeyiYenile();
        }

        private void BtnStokGrupSil_Click(object sender, EventArgs e)
        {
            foreach (var item in lstGrupView.SelectedItems)
                lstGrupView.Items.Remove((ListViewItem)item);

            ListeyiYenile();
        }
        
        private void TxtStokBilgiler_TextChanged(object sender, EventArgs e)
        {
            ListeyiYenile();
        }
    }
}
