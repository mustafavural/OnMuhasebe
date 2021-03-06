﻿using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormUI.View.Moduls.Stoklar
{
    public partial class FrmStokGrup : FrmBase
    {
        StoklarController _stoklarController;
        bool _secimIcin = false;
        List<string> _zatenVarOlanTurler;

        StokGrupKod _secilenKod;
        public FrmStokGrup(StoklarController stoklarController)
        {
            InitializeComponent();
            _stoklarController = stoklarController;
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
            var result = _stoklarController.GetStokGrupList();
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
            StokGrupKod secilen = GetStokGrupKodFromTextBoxes();
            if (_secilenKod == null)
                result = _stoklarController.AddGrupKod(secilen, out int Id);
            else
            {
                _secilenKod.Ad = secilen.Ad;
                _secilenKod.Tur = secilen.Tur;
                result = _stoklarController.UpdateGrupKod(_secilenKod, _secilenKod.Id);
            }

            if (result.Success)
                UscGruplar_ClickClear(sender, e);
            MessageBox.Show(result.Message);
        }

        private void UscGruplar_GrupSil(object sender, EventArgs e)
        {
            var result = _stoklarController.DeleteGrupKod(_secilenKod);
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

        public StokGrupKod SecimIcinAc(List<string> turList)
        {
            _zatenVarOlanTurler = turList;
            _secimIcin = true;
            ShowDialog();
            return _secilenKod;
        }
    }
}