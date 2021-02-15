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
        bool _secimIcin;
        public FrmStokGrup(IStokGrupKodService stokGrupKodService, bool secimIcin = true)
        {
            InitializeComponent();
            _stokGrupKodService = stokGrupKodService;
            _secimIcin = secimIcin;
        }

        private void FrmStokGrup_Load(object sender, EventArgs e)
        {
            #region Seçim İçin
            if(_secimIcin)
            {
                this.GrpEkleGuncelle.Visible = false;

            }
            #endregion

            UscGruplar_ClickClear(sender, e);
        }

        private void UscGruplar_ClickClear(object sender, EventArgs e)
        {
            IDataResult<List<StokGrupKod>> result = _stokGrupKodService.GetList();
            if (result.Success)
            {
                dgvGruplar.DataSource = result.Data;
                dgvGruplar.Refresh();
            }
            else
                MessageBox.Show(result.Message);

            txtGrupKodAd.Clear();
            txtGrupKodTur.Clear();

            uscGruplar.BtnSave_Text = "Ekle";
            uscGruplar.BtnDelete_Enable = false;

            _secilenKod = null;
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
                UscGruplar_ClickClear(sender, e);
            MessageBox.Show(result.Message);
        }

        private void UscGruplar_GrupSil(object sender, EventArgs e)
        {
            IResult result = _stokGrupKodService.Delete(_secilenKod);
            if (result.Success)
                UscGruplar_ClickClear(sender, e);
            MessageBox.Show(result.Message);
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

            if (_secimIcin)
            {
                SecileniGonder();
                this.Close();
            }
            else
            {
                txtGrupKodTur.Text = secilenSatir.Cells[1].Value.ToString();
                txtGrupKodAd.Text = secilenSatir.Cells[2].Value.ToString();

                uscGruplar.BtnSave_Text = "Güncelle";
                uscGruplar.BtnDelete_Enable = true;
            }
        }

        private StokGrupKod SecileniGonder()
        {
            return _secilenKod;
        }
    }
}