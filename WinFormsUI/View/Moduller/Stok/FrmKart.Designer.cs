
namespace WinFormsUI.View.Moduller.Stok
{
    partial class FrmKart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grpBirimler = new System.Windows.Forms.GroupBox();
            this.txtStok3Oran = new DevExpress.XtraEditors.TextEdit();
            this.txtStok2Oran = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtStok3Birim = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtStok2Birim = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtStokBirim = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.lstGruplar = new System.Windows.Forms.ListView();
            this.colgrupKod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colgrupAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colgrupAciklama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnStokGrupSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnStokGrupEkle = new DevExpress.XtraEditors.SimpleButton();
            this.gridButtons1 = new WinFormsUI.View.UserControls.gridButtons();
            this.txtStokKDV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtStokAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtStokBarkod = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnEditStokKod = new DevExpress.XtraEditors.ButtonEdit();
            this.grdCtrlStokListe = new DevExpress.XtraGrid.GridControl();
            this.grdViewStokListe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbirim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbirim2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbirim2oran = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbirim3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbirim3oran = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.grpBirimler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStok3Oran.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStok2Oran.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStok3Birim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStok2Birim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokBirim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKDV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokBarkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditStokKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlStokListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewStokListe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBaseClose
            // 
            this.btnBaseClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBaseClose.FlatAppearance.BorderSize = 0;
            this.btnBaseClose.Location = new System.Drawing.Point(36, -65);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.grpBirimler);
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.gridButtons1);
            this.groupControl1.Controls.Add(this.txtStokKDV);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtStokAd);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtStokBarkod);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnEditStokKod);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(843, 243);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Stok Bilgileri";
            // 
            // grpBirimler
            // 
            this.grpBirimler.Controls.Add(this.txtStok3Oran);
            this.grpBirimler.Controls.Add(this.txtStok2Oran);
            this.grpBirimler.Controls.Add(this.labelControl14);
            this.grpBirimler.Controls.Add(this.labelControl13);
            this.grpBirimler.Controls.Add(this.txtStok3Birim);
            this.grpBirimler.Controls.Add(this.labelControl12);
            this.grpBirimler.Controls.Add(this.txtStok2Birim);
            this.grpBirimler.Controls.Add(this.labelControl6);
            this.grpBirimler.Controls.Add(this.txtStokBirim);
            this.grpBirimler.Controls.Add(this.labelControl3);
            this.grpBirimler.Location = new System.Drawing.Point(12, 133);
            this.grpBirimler.Name = "grpBirimler";
            this.grpBirimler.Size = new System.Drawing.Size(347, 60);
            this.grpBirimler.TabIndex = 4;
            this.grpBirimler.TabStop = false;
            this.grpBirimler.Text = "Birimler";
            // 
            // txtStok3Oran
            // 
            this.txtStok3Oran.Location = new System.Drawing.Point(273, 34);
            this.txtStok3Oran.Name = "txtStok3Oran";
            this.txtStok3Oran.Size = new System.Drawing.Size(49, 20);
            this.txtStok3Oran.TabIndex = 4;
            // 
            // txtStok2Oran
            // 
            this.txtStok2Oran.Location = new System.Drawing.Point(141, 35);
            this.txtStok2Oran.Name = "txtStok2Oran";
            this.txtStok2Oran.Size = new System.Drawing.Size(49, 20);
            this.txtStok2Oran.TabIndex = 2;
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(273, 15);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(26, 13);
            this.labelControl14.TabIndex = 26;
            this.labelControl14.Text = "Oranı";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(141, 16);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(26, 13);
            this.labelControl13.TabIndex = 25;
            this.labelControl13.Text = "Oranı";
            // 
            // txtStok3Birim
            // 
            this.txtStok3Birim.Location = new System.Drawing.Point(206, 35);
            this.txtStok3Birim.Name = "txtStok3Birim";
            this.txtStok3Birim.Size = new System.Drawing.Size(49, 20);
            this.txtStok3Birim.TabIndex = 3;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(195, 16);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(60, 13);
            this.labelControl12.TabIndex = 23;
            this.labelControl12.Text = "Üçüncü Birim";
            // 
            // txtStok2Birim
            // 
            this.txtStok2Birim.Location = new System.Drawing.Point(73, 35);
            this.txtStok2Birim.Name = "txtStok2Birim";
            this.txtStok2Birim.Size = new System.Drawing.Size(49, 20);
            this.txtStok2Birim.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(73, 16);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(49, 13);
            this.labelControl6.TabIndex = 21;
            this.labelControl6.Text = "İkinci Birim";
            // 
            // txtStokBirim
            // 
            this.txtStokBirim.Location = new System.Drawing.Point(6, 35);
            this.txtStokBirim.Name = "txtStokBirim";
            this.txtStokBirim.Size = new System.Drawing.Size(49, 20);
            this.txtStokBirim.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 16);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 13);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "Birinci Birim";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.lstGruplar);
            this.groupControl3.Controls.Add(this.btnStokGrupSil);
            this.groupControl3.Controls.Add(this.btnStokGrupEkle);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl3.Location = new System.Drawing.Point(550, 23);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(291, 175);
            this.groupControl3.TabIndex = 5;
            this.groupControl3.Tag = "frmStokGrup";
            this.groupControl3.Text = "Grup Bilgileri";
            // 
            // lstGruplar
            // 
            this.lstGruplar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colgrupKod,
            this.colgrupAdi,
            this.colgrupAciklama});
            this.lstGruplar.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstGruplar.FullRowSelect = true;
            this.lstGruplar.HideSelection = false;
            this.lstGruplar.Location = new System.Drawing.Point(2, 23);
            this.lstGruplar.MultiSelect = false;
            this.lstGruplar.Name = "lstGruplar";
            this.lstGruplar.Size = new System.Drawing.Size(241, 150);
            this.lstGruplar.TabIndex = 3;
            this.lstGruplar.UseCompatibleStateImageBehavior = false;
            this.lstGruplar.View = System.Windows.Forms.View.Details;
            // 
            // colgrupKod
            // 
            this.colgrupKod.Text = "Grup Kodu";
            this.colgrupKod.Width = 62;
            // 
            // colgrupAdi
            // 
            this.colgrupAdi.Text = "Grup Adı";
            this.colgrupAdi.Width = 72;
            // 
            // colgrupAciklama
            // 
            this.colgrupAciklama.Text = "Grup Açıklaması";
            this.colgrupAciklama.Width = 101;
            // 
            // btnStokGrupSil
            // 
            this.btnStokGrupSil.ImageOptions.Image = global::WinFormsUI.Properties.Resources.Sil32x32;
            this.btnStokGrupSil.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.btnStokGrupSil.Location = new System.Drawing.Point(249, 71);
            this.btnStokGrupSil.Name = "btnStokGrupSil";
            this.btnStokGrupSil.Size = new System.Drawing.Size(32, 32);
            this.btnStokGrupSil.TabIndex = 2;
            // 
            // btnStokGrupEkle
            // 
            this.btnStokGrupEkle.ImageOptions.Image = global::WinFormsUI.Properties.Resources.Ara32x32;
            this.btnStokGrupEkle.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.btnStokGrupEkle.Location = new System.Drawing.Point(249, 26);
            this.btnStokGrupEkle.Name = "btnStokGrupEkle";
            this.btnStokGrupEkle.Size = new System.Drawing.Size(32, 32);
            this.btnStokGrupEkle.TabIndex = 1;
            this.btnStokGrupEkle.Tag = "Stok.frmGrup";
            // 
            // gridButtons1
            // 
            this.gridButtons1.btnCancel_Text = "Stok Sil";
            this.gridButtons1.btnCancelEnable = true;
            this.gridButtons1.btnSaveEnable = true;
            this.gridButtons1.btnTemizleVisible = true;
            this.gridButtons1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridButtons1.Location = new System.Drawing.Point(2, 198);
            this.gridButtons1.Name = "gridButtons1";
            this.gridButtons1.Size = new System.Drawing.Size(839, 43);
            this.gridButtons1.TabIndex = 6;
            // 
            // txtStokKDV
            // 
            this.txtStokKDV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStokKDV.Location = new System.Drawing.Point(66, 104);
            this.txtStokKDV.Name = "txtStokKDV";
            this.txtStokKDV.Size = new System.Drawing.Size(478, 20);
            this.txtStokKDV.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(41, 107);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(19, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "KDV";
            // 
            // txtStokAd
            // 
            this.txtStokAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStokAd.Location = new System.Drawing.Point(66, 78);
            this.txtStokAd.Name = "txtStokAd";
            this.txtStokAd.Size = new System.Drawing.Size(478, 20);
            this.txtStokAd.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(21, 81);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Stok Adı";
            // 
            // txtStokBarkod
            // 
            this.txtStokBarkod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStokBarkod.Location = new System.Drawing.Point(66, 52);
            this.txtStokBarkod.Name = "txtStokBarkod";
            this.txtStokBarkod.Size = new System.Drawing.Size(478, 20);
            this.txtStokBarkod.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 55);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Barkodu";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Stok Kodu";
            // 
            // btnEditStokKod
            // 
            this.btnEditStokKod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditStokKod.Location = new System.Drawing.Point(66, 26);
            this.btnEditStokKod.Name = "btnEditStokKod";
            this.btnEditStokKod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnEditStokKod.Size = new System.Drawing.Size(478, 20);
            this.btnEditStokKod.TabIndex = 0;
            this.btnEditStokKod.Tag = "Stok.frmListe";
            // 
            // grdCtrlStokListe
            // 
            this.grdCtrlStokListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCtrlStokListe.Location = new System.Drawing.Point(0, 243);
            this.grdCtrlStokListe.MainView = this.grdViewStokListe;
            this.grdCtrlStokListe.Name = "grdCtrlStokListe";
            this.grdCtrlStokListe.Size = new System.Drawing.Size(843, 126);
            this.grdCtrlStokListe.TabIndex = 1;
            this.grdCtrlStokListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdViewStokListe});
            // 
            // grdViewStokListe
            // 
            this.grdViewStokListe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colKod,
            this.colbarkod,
            this.colad,
            this.colKDV,
            this.colbirim,
            this.colbirim2,
            this.colbirim2oran,
            this.colbirim3,
            this.colbirim3oran});
            this.grdViewStokListe.GridControl = this.grdCtrlStokListe;
            this.grdViewStokListe.Name = "grdViewStokListe";
            this.grdViewStokListe.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdViewStokListe.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdViewStokListe.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.Disabled;
            this.grdViewStokListe.OptionsBehavior.Editable = false;
            this.grdViewStokListe.OptionsBehavior.ReadOnly = true;
            this.grdViewStokListe.OptionsMenu.EnableColumnMenu = false;
            this.grdViewStokListe.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colid.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colid.AppearanceHeader.Options.UseFont = true;
            this.colid.AppearanceHeader.Options.UseForeColor = true;
            this.colid.FieldName = "s_Id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colid.OptionsColumn.AllowMove = false;
            this.colid.OptionsColumn.AllowShowHide = false;
            this.colid.OptionsColumn.AllowSize = false;
            this.colid.OptionsColumn.ReadOnly = true;
            this.colid.OptionsFilter.AllowAutoFilter = false;
            this.colid.OptionsFilter.AllowFilter = false;
            // 
            // colKod
            // 
            this.colKod.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colKod.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colKod.AppearanceHeader.Options.UseFont = true;
            this.colKod.AppearanceHeader.Options.UseForeColor = true;
            this.colKod.Caption = "Stok Kodu";
            this.colKod.FieldName = "s_Kod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colKod.OptionsColumn.AllowMove = false;
            this.colKod.OptionsColumn.AllowShowHide = false;
            this.colKod.OptionsColumn.AllowSize = false;
            this.colKod.OptionsColumn.ReadOnly = true;
            this.colKod.OptionsFilter.AllowAutoFilter = false;
            this.colKod.OptionsFilter.AllowFilter = false;
            this.colKod.Visible = true;
            this.colKod.VisibleIndex = 0;
            // 
            // colbarkod
            // 
            this.colbarkod.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colbarkod.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colbarkod.AppearanceHeader.Options.UseFont = true;
            this.colbarkod.AppearanceHeader.Options.UseForeColor = true;
            this.colbarkod.Caption = "Barkodu";
            this.colbarkod.FieldName = "s_Barkod";
            this.colbarkod.Name = "colbarkod";
            this.colbarkod.OptionsColumn.AllowEdit = false;
            this.colbarkod.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colbarkod.OptionsColumn.AllowMove = false;
            this.colbarkod.OptionsColumn.AllowShowHide = false;
            this.colbarkod.OptionsColumn.AllowSize = false;
            this.colbarkod.OptionsColumn.ReadOnly = true;
            this.colbarkod.OptionsFilter.AllowAutoFilter = false;
            this.colbarkod.OptionsFilter.AllowFilter = false;
            this.colbarkod.Visible = true;
            this.colbarkod.VisibleIndex = 1;
            // 
            // colad
            // 
            this.colad.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colad.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colad.AppearanceHeader.Options.UseFont = true;
            this.colad.AppearanceHeader.Options.UseForeColor = true;
            this.colad.Caption = "Stok Adı";
            this.colad.FieldName = "s_Ad";
            this.colad.Name = "colad";
            this.colad.OptionsColumn.AllowEdit = false;
            this.colad.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colad.OptionsColumn.AllowMove = false;
            this.colad.OptionsColumn.AllowShowHide = false;
            this.colad.OptionsColumn.AllowSize = false;
            this.colad.OptionsColumn.ReadOnly = true;
            this.colad.OptionsFilter.AllowAutoFilter = false;
            this.colad.OptionsFilter.AllowFilter = false;
            this.colad.Visible = true;
            this.colad.VisibleIndex = 2;
            // 
            // colKDV
            // 
            this.colKDV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colKDV.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colKDV.AppearanceHeader.Options.UseFont = true;
            this.colKDV.AppearanceHeader.Options.UseForeColor = true;
            this.colKDV.Caption = "KDV";
            this.colKDV.FieldName = "s_Kdv";
            this.colKDV.Name = "colKDV";
            this.colKDV.OptionsColumn.AllowEdit = false;
            this.colKDV.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colKDV.OptionsColumn.AllowMove = false;
            this.colKDV.OptionsColumn.AllowShowHide = false;
            this.colKDV.OptionsColumn.AllowSize = false;
            this.colKDV.OptionsColumn.ReadOnly = true;
            this.colKDV.OptionsFilter.AllowAutoFilter = false;
            this.colKDV.OptionsFilter.AllowFilter = false;
            this.colKDV.Visible = true;
            this.colKDV.VisibleIndex = 3;
            // 
            // colbirim
            // 
            this.colbirim.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colbirim.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colbirim.AppearanceHeader.Options.UseFont = true;
            this.colbirim.AppearanceHeader.Options.UseForeColor = true;
            this.colbirim.Caption = "Stok Birimi";
            this.colbirim.FieldName = "s_Birim";
            this.colbirim.Name = "colbirim";
            this.colbirim.OptionsColumn.AllowEdit = false;
            this.colbirim.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colbirim.OptionsColumn.AllowMove = false;
            this.colbirim.OptionsColumn.AllowShowHide = false;
            this.colbirim.OptionsColumn.AllowSize = false;
            this.colbirim.OptionsColumn.ReadOnly = true;
            this.colbirim.OptionsFilter.AllowAutoFilter = false;
            this.colbirim.OptionsFilter.AllowFilter = false;
            this.colbirim.Visible = true;
            this.colbirim.VisibleIndex = 4;
            // 
            // colbirim2
            // 
            this.colbirim2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colbirim2.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colbirim2.AppearanceHeader.Options.UseFont = true;
            this.colbirim2.AppearanceHeader.Options.UseForeColor = true;
            this.colbirim2.Caption = "2. Birim";
            this.colbirim2.FieldName = "s_Ikincibirim";
            this.colbirim2.Name = "colbirim2";
            this.colbirim2.OptionsColumn.AllowEdit = false;
            this.colbirim2.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colbirim2.OptionsColumn.AllowMove = false;
            this.colbirim2.OptionsColumn.AllowShowHide = false;
            this.colbirim2.OptionsColumn.AllowSize = false;
            this.colbirim2.OptionsColumn.ReadOnly = true;
            this.colbirim2.OptionsFilter.AllowAutoFilter = false;
            this.colbirim2.OptionsFilter.AllowFilter = false;
            this.colbirim2.Visible = true;
            this.colbirim2.VisibleIndex = 5;
            // 
            // colbirim2oran
            // 
            this.colbirim2oran.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colbirim2oran.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colbirim2oran.AppearanceHeader.Options.UseFont = true;
            this.colbirim2oran.AppearanceHeader.Options.UseForeColor = true;
            this.colbirim2oran.Caption = "2. Birimin Oranı";
            this.colbirim2oran.FieldName = "s_Ikincibirimoran";
            this.colbirim2oran.Name = "colbirim2oran";
            this.colbirim2oran.OptionsColumn.AllowEdit = false;
            this.colbirim2oran.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colbirim2oran.OptionsColumn.AllowMove = false;
            this.colbirim2oran.OptionsColumn.AllowShowHide = false;
            this.colbirim2oran.OptionsColumn.AllowSize = false;
            this.colbirim2oran.OptionsColumn.ReadOnly = true;
            this.colbirim2oran.OptionsFilter.AllowAutoFilter = false;
            this.colbirim2oran.OptionsFilter.AllowFilter = false;
            this.colbirim2oran.Visible = true;
            this.colbirim2oran.VisibleIndex = 6;
            // 
            // colbirim3
            // 
            this.colbirim3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colbirim3.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colbirim3.AppearanceHeader.Options.UseFont = true;
            this.colbirim3.AppearanceHeader.Options.UseForeColor = true;
            this.colbirim3.Caption = "3. Birim";
            this.colbirim3.FieldName = "s_Ucuncubirim";
            this.colbirim3.Name = "colbirim3";
            this.colbirim3.OptionsColumn.AllowEdit = false;
            this.colbirim3.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colbirim3.OptionsColumn.AllowMove = false;
            this.colbirim3.OptionsColumn.AllowShowHide = false;
            this.colbirim3.OptionsColumn.AllowSize = false;
            this.colbirim3.OptionsColumn.ReadOnly = true;
            this.colbirim3.OptionsFilter.AllowAutoFilter = false;
            this.colbirim3.OptionsFilter.AllowFilter = false;
            this.colbirim3.Visible = true;
            this.colbirim3.VisibleIndex = 7;
            // 
            // colbirim3oran
            // 
            this.colbirim3oran.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colbirim3oran.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colbirim3oran.AppearanceHeader.Options.UseFont = true;
            this.colbirim3oran.AppearanceHeader.Options.UseForeColor = true;
            this.colbirim3oran.Caption = "3. Birimin Oranı";
            this.colbirim3oran.FieldName = "s_Ucuncubirimoran";
            this.colbirim3oran.Name = "colbirim3oran";
            this.colbirim3oran.OptionsColumn.AllowEdit = false;
            this.colbirim3oran.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colbirim3oran.OptionsColumn.AllowMove = false;
            this.colbirim3oran.OptionsColumn.AllowShowHide = false;
            this.colbirim3oran.OptionsColumn.AllowSize = false;
            this.colbirim3oran.OptionsColumn.ReadOnly = true;
            this.colbirim3oran.OptionsFilter.AllowAutoFilter = false;
            this.colbirim3oran.OptionsFilter.AllowFilter = false;
            this.colbirim3oran.Visible = true;
            this.colbirim3oran.VisibleIndex = 8;
            // 
            // FrmKart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 369);
            this.Controls.Add(this.grdCtrlStokListe);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = global::WinFormsUI.Properties.Resources.Stok_Kartı16x16;
            this.IconOptions.ShowIcon = false;
            this.Name = "FrmKart";
            this.Text = "Stok Kartı";
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.grdCtrlStokListe, 0);
            this.Controls.SetChildIndex(this.btnBaseClose, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.grpBirimler.ResumeLayout(false);
            this.grpBirimler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStok3Oran.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStok2Oran.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStok3Birim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStok2Birim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokBirim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKDV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokBarkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditStokKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlStokListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewStokListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtStokKDV;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtStokAd;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtStokBarkod;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit btnEditStokKod;
        private DevExpress.XtraGrid.GridControl grdCtrlStokListe;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewStokListe;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private UserControls.gridButtons gridButtons1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colKod;
        private DevExpress.XtraGrid.Columns.GridColumn colbarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colad;
        private DevExpress.XtraGrid.Columns.GridColumn colbirim;
        private DevExpress.XtraGrid.Columns.GridColumn colKDV;
        private DevExpress.XtraGrid.Columns.GridColumn colbirim2;
        private DevExpress.XtraGrid.Columns.GridColumn colbirim2oran;
        private DevExpress.XtraGrid.Columns.GridColumn colbirim3;
        private DevExpress.XtraGrid.Columns.GridColumn colbirim3oran;
        private System.Windows.Forms.GroupBox grpBirimler;
        private DevExpress.XtraEditors.TextEdit txtStok3Oran;
        private DevExpress.XtraEditors.TextEdit txtStok2Oran;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit txtStok3Birim;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtStok2Birim;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtStokBirim;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnStokGrupSil;
        private DevExpress.XtraEditors.SimpleButton btnStokGrupEkle;
        private System.Windows.Forms.ListView lstGruplar;
        private System.Windows.Forms.ColumnHeader colgrupKod;
        private System.Windows.Forms.ColumnHeader colgrupAdi;
        private System.Windows.Forms.ColumnHeader colgrupAciklama;
    }
}