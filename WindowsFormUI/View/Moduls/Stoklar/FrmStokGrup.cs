using Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Windows.Forms;

namespace WindowsFormUI.View.Moduls.Stoklar
{
    public partial class FrmStokGrup : FrmBase
    {
        IStokGrupKodService _stokGrupKodService;
        bool _secimIcin = false;

        StokGrupKod _secilenKod;
        public FrmStokGrup(IStokGrupKodService stokGrupKodService)
        {
            InitializeComponent();
            _stokGrupKodService = stokGrupKodService;
        }

        private void FrmStokGrup_Load(object sender, EventArgs e)
        {
            if (_secimIcin)
                grpEkleGuncelle.Visible = false;

            UscGruplar_ClickClear(sender, e);
        }

        private StokGrupKod GetStokGrupKodFromTextBoxes() =>
            new StokGrupKod { Ad = txtGrupKodAd.Text.ToUpper(), Tur = txtGrupKodTur.Text.ToUpper() };

        private StokGrupKod GetStokGrupKodFromDataGridView() =>
            _secilenKod = (StokGrupKod)dgvGruplar.SelectedRows[0].DataBoundItem;

        private void UscGruplar_ClickClear(object sender, EventArgs e)
        {
            var result = _stokGrupKodService.GetList();
            if (result.Success)
                dgvGruplar.DataSource = result.Data;
            else
                MessageBox.Show(result.Message);

            txtGrupKodAd.Clear();
            txtGrupKodTur.Clear();

            uscGruplar.BtnSave_Text = "Ekle";
            uscGruplar.BtnDelete_Enable = false;

            _secilenKod = null;
        }

        private void UscGruplar_GrupEkleGuncelle(object sender, EventArgs e)
        {
            IResult result;
            StokGrupKod secilen = GetStokGrupKodFromTextBoxes();
            if (_secilenKod == null)
                result = _stokGrupKodService.Add(secilen);
            else
            {
                _secilenKod.Ad = secilen.Ad;
                _secilenKod.Tur = secilen.Tur;
                result = _stokGrupKodService.Update(_secilenKod);
            }

            if (result.Success)
                UscGruplar_ClickClear(sender, e);
            MessageBox.Show(result.Message);
        }

        private void UscGruplar_GrupSil(object sender, EventArgs e)
        {
            var result = _stokGrupKodService.Delete(_secilenKod);
            if (result.Success)
                UscGruplar_ClickClear(sender, e);
            MessageBox.Show(result.Message);
        }

        private void DgvGruplar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var secilenSatir = GetStokGrupKodFromDataGridView();

            if (_secimIcin)
                Close();
            else
            {
                txtGrupKodTur.Text = secilenSatir.Tur;
                txtGrupKodAd.Text = secilenSatir.Ad;

                uscGruplar.BtnSave_Text = "Güncelle";
                uscGruplar.BtnDelete_Enable = true;
            }
        }

        public StokGrupKod SecimIcinAc()
        {
            _secimIcin = true;
            ShowDialog();
            return _secilenKod;
        }
    }
}