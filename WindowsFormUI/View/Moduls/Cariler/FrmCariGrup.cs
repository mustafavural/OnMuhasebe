using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormUI.View.Moduls.Cariler
{
    public partial class FrmCariGrup : FrmBase
    {
        CarilerController _carilerController;
        bool _secimIcin;
        List<string> _zatenVarOlanTurler;

        CariGrupKod _secilenKod;
        public FrmCariGrup(CarilerController carilerController)
        {
            InitializeComponent();
            _carilerController = carilerController;
        }

        private void FrmCariGrup_Load(object sender, EventArgs e)
        {
            if (_secimIcin)
                grpEkleGuncelle.Visible = false;

            UscGruplar_ClickClear(sender, e);
        }

        private CariGrupKod GetCariGrupKodFromTextBoxes() =>
            new CariGrupKod { Ad = txtGrupKodAd.Text.ToUpper(), Tur = txtGrupKodTur.Text.ToUpper() };

        private CariGrupKod GetCariGrupKodFromDataGridView() =>
            _secilenKod = (CariGrupKod)dgvGruplar.SelectedRows[0].DataBoundItem;

        private void UscGruplar_ClickClear(object sender, EventArgs e)
        {
            var result = _carilerController.GetCariGrupList();
            if (_zatenVarOlanTurler != null)
                dgvGruplar.DataSource = result.Data.Where(p => !_zatenVarOlanTurler.Exists(z => z == p.Tur)).ToList();
            else
                dgvGruplar.DataSource = result.Data;

            txtGrupKodAd.Clear();
            txtGrupKodTur.Clear();

            uscGruplar.BtnSave_Text = "Ekle";
            uscGruplar.BtnDelete_Enable = false;

            _secilenKod = null;
        }

        private void UscGruplar_GrupEkleGuncelle(object sender, EventArgs e)
        {
            IResult result;
            CariGrupKod secilen = GetCariGrupKodFromTextBoxes();
            if (_secilenKod == null)
                result = _carilerController.AddGrupKod(secilen, out int Id);
            else
            {
                _secilenKod.Ad = secilen.Ad;
                _secilenKod.Tur = secilen.Tur;
                result = _carilerController.UpdateGrupKod(_secilenKod, _secilenKod.Id);
            }

            if (result.Success)
                UscGruplar_ClickClear(sender, e);
            MessageBox.Show(result.Message);
        }

        private void UscGruplar_GrupSil(object sender, EventArgs e)
        {
            var result = _carilerController.DeleteGrupKod(_secilenKod);
            if (result.Success)
                UscGruplar_ClickClear(sender, e);
            MessageBox.Show(result.Message);
        }

        private void DgvGruplar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var secilenSatir = GetCariGrupKodFromDataGridView();

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

        public CariGrupKod SecimIcinAc(List<string> turList)
        {
            _zatenVarOlanTurler = turList;
            _secimIcin = true;
            ShowDialog();
            return _secilenKod;
        }
    }
}