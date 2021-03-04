using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormUI.View.Moduls.Cariler
{
    public partial class FrmCariListe : FrmBase
    {
        CarilerController _carilerController;
        FrmCariGrup _frmCariGrup;

        IDataResult<List<Cari>> _cariResult;
        CariGrupKod _secilenGrupKod;
        Cari _secilenCari;
        public FrmCariListe(FrmCariGrup frmCariGrup, CarilerController carilerController)
        {
            InitializeComponent();
            _frmCariGrup = frmCariGrup;
            _carilerController = carilerController;
        }

        private void FrmCariListe_Load(object sender, EventArgs e)
        {
            _cariResult = _carilerController.GetCariList();
            if (_cariResult.Success)
                dgvCariListe.DataSource = _cariResult.Data;
            else
                MessageBox.Show(_cariResult.Message);
        }

        private void ListeyiYenile()
        {
            var groupFilters = new List<int>();
            foreach (DataGridViewRow item in dgvGrupView.Rows)
                groupFilters.Add((int)item.Cells[0].Value);

            var cariResult = _cariResult.Data.Where(p =>
                   p.Kod.Contains(txtCariKod.Text.ToUpper()) &&
                   p.Unvan.Contains(txtUnvan.Text.ToUpper()) &&
                   p.VergiDairesi.Contains(txtVergiDairesi.Text.ToUpper()));

            foreach (var item in groupFilters)
            {
                cariResult = cariResult.Where(p =>
                {
                    var gruplar = _carilerController.GetListCariGrupKod(p.Id).Data;
                    var Idler = gruplar.Select(s => s.Id).ToList();
                    return Idler.Exists(s => s == item);
                }).ToList();
            }

            dgvCariListe.DataSource = cariResult;
        }

        private void BtnCariGrupEkle_Click(object sender, EventArgs e)
        {
            var turList = new List<string>();
            foreach (DataGridViewRow row in dgvGrupView.Rows)
                turList.Add(row.Cells[1].Value.ToString());


            _secilenGrupKod = _frmCariGrup.SecimIcinAc(turList);
            if (_secilenGrupKod != null)
            {
                var rowIndex = dgvGrupView.Rows.Add();
                dgvGrupView.Rows[rowIndex].SetValues(_secilenGrupKod.Id, _secilenGrupKod.Tur, _secilenGrupKod.Ad);
            }
            ListeyiYenile();
        }

        private void BtnCariGrupSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgvGrupView.SelectedRows)
                dgvGrupView.Rows.Remove(item);
            ListeyiYenile();
        }

        private void TxtCariBilgiler_TextChanged(object sender, EventArgs e)
        {
            ListeyiYenile();
        }

        private void DgvCariListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cari secilenSatir = (Cari)dgvCariListe.SelectedRows[0].DataBoundItem;
            _secilenCari = _carilerController.GetById(secilenSatir.Id).Data;
            Close();
        }

        public Cari SecimIcinAc()
        {
            ShowDialog();
            return _secilenCari;
        }
    }
}
