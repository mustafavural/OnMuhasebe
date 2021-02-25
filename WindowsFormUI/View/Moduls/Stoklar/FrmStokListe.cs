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
        StokGrupKod _secilenGrupKod;
        Stok _secilenStok;
        public FrmStokListe(IStokService stokService, IStokGrupKodService stokGrupService, FrmStokGrup frmStokGrup)
        {
            InitializeComponent();
            _stokService = stokService;
            _frmStokGrup = frmStokGrup;
            _stokGrupKodService = stokGrupService;
        }

        private void FrmStokListe_Load(object sender, EventArgs e)
        {
            _stokResult = _stokService.GetList();
            if (_stokResult.Success)
                dgvStokListe.DataSource = _stokResult.Data;
            else
                MessageBox.Show(_stokResult.Message);
        }

        private void ListeyiYenile()
        {
            var stokResult = _stokResult.Data.Where(p =>
                   p.Kod.Contains(txtStokKod.Text.ToUpper()) &&
                   p.Barkod.Contains(txtBarkod.Text.ToUpper()) &&
                   p.Ad.Contains(txtStokAd.Text.ToUpper()) &&
                   p.KDV.ToString().Contains(txtKDV.Text.ToUpper())).ToList();

            stokResult = stokResult.Where(p =>
            {
                if (dgvGrupView.Rows.Count == 0)
                    return true;
                else
                {
                    var stokGrupKodlar = _stokGrupKodService.GetListByStokId(p.Id).Data;
                    foreach (var item in stokGrupKodlar)
                        foreach (DataGridViewRow stokGrupKod in dgvGrupView.Rows)
                            if (item.Id.ToString() == stokGrupKod.Cells[0].Value.ToString())
                                return true;
                    return false;
                }
            }).ToList();

            dgvStokListe.DataSource = stokResult;
        }

        private void BtnStokGrupEkle_Click(object sender, EventArgs e)
        {
            var turList = new List<string>();
            foreach (DataGridViewRow row in dgvGrupView.Rows)
                turList.Add(row.Cells[1].Value.ToString());


            _secilenGrupKod = _frmStokGrup.SecimIcinAc(turList);
            if (_secilenGrupKod != null)
            {
                var rowIndex = dgvGrupView.Rows.Add();
                dgvGrupView.Rows[rowIndex].SetValues(_secilenGrupKod.Id, _secilenGrupKod.Tur, _secilenGrupKod.Ad);
            }
            ListeyiYenile();
        }

        private void BtnStokGrupSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgvGrupView.SelectedRows)
                dgvGrupView.Rows.Remove(item);
            ListeyiYenile();
        }

        private void TxtStokBilgiler_TextChanged(object sender, EventArgs e)
        {
            ListeyiYenile();
        }

        private void DgvStokListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Stok secilenSatir = (Stok)dgvStokListe.SelectedRows[0].DataBoundItem;
            var secilenStok = _stokService.GetById(secilenSatir.Id);
            if (secilenStok.Success)
            {
                _secilenStok = secilenStok.Data;
                Close();
            }
            else
                MessageBox.Show(secilenStok.Message);
        }

        public Stok SecimIcinAc()
        {
            ShowDialog();
            return _secilenStok;
        }
    }
}