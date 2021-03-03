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
        StoklarController _stoklarController;
        FrmStokGrup _frmStokGrup;

        IDataResult<List<Stok>> _stokResult;
        StokGrupKod _secilenGrupKod;
        Stok _secilenStok;
        public FrmStokListe(FrmStokGrup frmStokGrup, StoklarController stoklarController)
        {
            InitializeComponent();
            _frmStokGrup = frmStokGrup;
            _stoklarController = stoklarController;
        }

        private void FrmStokListe_Load(object sender, EventArgs e)
        {
            _stokResult = _stoklarController.GetStokList();
            if (_stokResult.Success)
                dgvStokListe.DataSource = _stokResult.Data;
            else
                MessageBox.Show(_stokResult.Message);
        }

        private void ListeyiYenile()
        {
            var groupFilters = new List<int>();
            foreach (DataGridViewRow item in dgvGrupView.Rows)
                groupFilters.Add((int)item.Cells[0].Value);

            var stokResult = _stokResult.Data.Where(p =>
                   p.Kod.Contains(txtStokKod.Text.ToUpper()) &&
                   p.Barkod.Contains(txtBarkod.Text.ToUpper()) &&
                   p.Ad.Contains(txtStokAd.Text.ToUpper()) &&
                   p.KDV.ToString().Contains(txtKDV.Text.ToUpper())).ToList();

            foreach (var item in groupFilters)
            {
                stokResult = stokResult.Where(p =>
                {
                    var gruplar = _stoklarController.GetListStokGrupKod(p.Id).Data;
                    var Idler = gruplar.Select(s => s.Id).ToList();
                    return Idler.Exists(s => s == item);
                }).ToList();
            }

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
            _secilenStok = _stoklarController.GetById(secilenSatir.Id).Data;
            Close();
        }

        public Stok SecimIcinAc()
        {
            ShowDialog();
            return _secilenStok;
        }
    }
}