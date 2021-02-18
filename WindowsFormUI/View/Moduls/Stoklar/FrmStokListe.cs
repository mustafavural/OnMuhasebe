using Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormUI.View.Moduls.Stoklar
{
    public partial class FrmStokListe : FrmBase
    {
        IStokService _stokService;
        IStokGrupKodService _stokGrupKodService;
        FrmStokGrup _frmStokGrup;

        IDataResult<List<Stok>> _stokResult;
        StokGrupKod _secilenGrup;
        Stok _secilenStok;
        bool _secimIcin = false;
        public FrmStokListe(IStokService stokService, IStokGrupKodService stokGrupService, FrmStokGrup frmStokGrup)
        {
            InitializeComponent();
            _stokService = stokService;
            _frmStokGrup = frmStokGrup;
            _stokGrupKodService = stokGrupService;
        }

        private void ListeyiYenile()
        {
            dgvStokListe.DataSource = _stokResult.Data
                .Where(p =>
                {
                    return p.Kod.Contains(txtStokKod.Text.ToUpper()) && 
                    p.Barkod.Contains(txtBarkod.Text.ToUpper()) && 
                    p.Ad.Contains(txtStokAd.Text.ToUpper()) &&
                    p.KDV.ToString().Contains(txtKDV.Text.ToUpper());
                }).Where(grup =>
                {
                    if (lstGrupView.Items.Count == 0)
                        return true;
                    else
                    {
                        var stokGruplar = _stokGrupKodService.GetListByStokId(grup.Id).Data;
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
                dgvStokListe.DataSource = _stokResult.Data.Select(s => new { s.Id, s.Kod, s.Barkod, s.Ad }).ToList();
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

        public Stok SecimIcinAc()
        {
            this._secimIcin = true;
            this.ShowDialog();
            return _secilenStok;
        }

        private void DgvStokListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_secimIcin)
            {
                var secilenSatir = dgvStokListe.SelectedRows[0];
                var secilenStok = _stokService.GetById((int)secilenSatir.Cells[0].Value);
                if (secilenStok.Success)
                {
                    _secilenStok = secilenStok.Data;
                    this.Close();
                }
                else
                    MessageBox.Show(secilenStok.Message);
            }
        }
    }
}
