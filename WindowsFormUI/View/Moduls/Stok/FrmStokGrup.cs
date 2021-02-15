using Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormUI.View.Moduls.Stok
{
    public partial class FrmStokGrup : FrmBase
    {
        IStokGrupKodService _stokGrupKodService;
        StokGrupKod _secilenKod;
        public FrmStokGrup(IStokGrupKodService stokGrupKodService)
        {
            InitializeComponent();
            _stokGrupKodService = stokGrupKodService;
        }

        private void FrmStokGrup_Load(object sender, EventArgs e)
        {
            Yenile(sender, e);
        }

        private void Yenile(object sender, EventArgs e)
        {
            IDataResult<List<StokGrupKod>> result = _stokGrupKodService.GetList();
            if (result.Success)
            {
                dgvGruplar.DataSource = result.Data;
                dgvGruplar.Refresh();
            }
            else
                MessageBox.Show(result.Message);

            UscGruplar_ClickClear(sender, e);
        }

        private StokGrupKod GetStokGrupKodFromControls() =>
            new StokGrupKod { Ad = txtGrupKodAd.Text.ToUpper(), Tur = txtGrupKodTur.Text.ToUpper() };

        private void UscGruplar_GrupEkleGuncelle(object sender, EventArgs e)
        {
            IResult result;
            StokGrupKod secilen = GetStokGrupKodFromControls();
            if (_secilenKod == null)
                result = _stokGrupKodService.Add(secilen);
            else
            {
                _secilenKod.Ad = secilen.Ad;
                _secilenKod.Tur = secilen.Tur;
                result = _stokGrupKodService.Update(_secilenKod);
            }

            if (result.Success)
                Yenile(sender, e);
            MessageBox.Show(result.Message);
        }

        private void UscGruplar_GrupSil(object sender, EventArgs e)
        {
            IResult result = _stokGrupKodService.Delete(_secilenKod);
            if (result.Success)
                Yenile(sender, e);
            MessageBox.Show(result.Message);
        }

        private void UscGruplar_ClickClear(object sender, EventArgs e)
        {
            txtGrupKodAd.Clear();
            txtGrupKodTur.Clear();

            uscGruplar.BtnSave_Text = "Ekle";
            uscGruplar.BtnDelete_Enable = false;

            _secilenKod = null;
        }

        private void DgvGruplar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var secilenSatir = dgvGruplar.SelectedRows[0];
            _secilenKod = new StokGrupKod
            {
                Id = (int)secilenSatir.Cells[0].Value,
                Tur = secilenSatir.Cells[1].Value.ToString(),
                Ad = secilenSatir.Cells[2].Value.ToString()
            };

            txtGrupKodTur.Text = secilenSatir.Cells[1].Value.ToString();
            txtGrupKodAd.Text = secilenSatir.Cells[2].Value.ToString();

            uscGruplar.BtnSave_Text = "Güncelle";
            uscGruplar.BtnDelete_Enable = true;
        }
    }
}
