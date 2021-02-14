
namespace WinFormsUI.View.Moduller.Cari
{
    partial class FrmListe
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
            this.btnCariGrupSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnCariGrupEkle = new DevExpress.XtraEditors.SimpleButton();
            this.lstGruplar = new System.Windows.Forms.ListView();
            this.colgrupId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colgrupKod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colgrupAciklama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colgrupAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtCariTelefon = new DevExpress.XtraEditors.TextEdit();
            this.txtCariVergiTcNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCariAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCariKod = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grdCtrlCariListe = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colgrupcKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgrupcAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgrupcVTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgrupcTel = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariVergiTcNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlCariListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBaseClose
            // 
            this.btnBaseClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBaseClose.FlatAppearance.BorderSize = 0;
            this.btnBaseClose.Location = new System.Drawing.Point(-10, -125);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnCariGrupSil);
            this.groupControl1.Controls.Add(this.btnCariGrupEkle);
            this.groupControl1.Controls.Add(this.lstGruplar);
            this.groupControl1.Controls.Add(this.txtCariTelefon);
            this.groupControl1.Controls.Add(this.txtCariVergiTcNo);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtCariAd);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtCariKod);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(162, 317);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Cari Bilgileri";
            // 
            // btnCariGrupSil
            // 
            this.btnCariGrupSil.ImageOptions.Image = global::WinFormsUI.Properties.Resources.Sil32x32;
            this.btnCariGrupSil.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.btnCariGrupSil.Location = new System.Drawing.Point(104, 206);
            this.btnCariGrupSil.Name = "btnCariGrupSil";
            this.btnCariGrupSil.Size = new System.Drawing.Size(32, 32);
            this.btnCariGrupSil.TabIndex = 13;
            // 
            // btnCariGrupEkle
            // 
            this.btnCariGrupEkle.ImageOptions.Image = global::WinFormsUI.Properties.Resources.Ara32x32;
            this.btnCariGrupEkle.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.btnCariGrupEkle.Location = new System.Drawing.Point(26, 206);
            this.btnCariGrupEkle.Name = "btnCariGrupEkle";
            this.btnCariGrupEkle.Size = new System.Drawing.Size(32, 32);
            this.btnCariGrupEkle.TabIndex = 12;
            this.btnCariGrupEkle.Tag = "Stok.frmGrup";
            // 
            // lstGruplar
            // 
            this.lstGruplar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colgrupId,
            this.colgrupKod,
            this.colgrupAciklama,
            this.colgrupAdi});
            this.lstGruplar.FullRowSelect = true;
            this.lstGruplar.HideSelection = false;
            this.lstGruplar.Location = new System.Drawing.Point(10, 244);
            this.lstGruplar.MultiSelect = false;
            this.lstGruplar.Name = "lstGruplar";
            this.lstGruplar.Size = new System.Drawing.Size(144, 212);
            this.lstGruplar.TabIndex = 11;
            this.lstGruplar.UseCompatibleStateImageBehavior = false;
            this.lstGruplar.View = System.Windows.Forms.View.Details;
            // 
            // colgrupId
            // 
            this.colgrupId.Text = "";
            this.colgrupId.Width = 0;
            // 
            // colgrupKod
            // 
            this.colgrupKod.Text = "";
            this.colgrupKod.Width = 0;
            // 
            // colgrupAciklama
            // 
            this.colgrupAciklama.Text = "Grup Açıklaması";
            this.colgrupAciklama.Width = 86;
            // 
            // colgrupAdi
            // 
            this.colgrupAdi.Text = "Grup Adı";
            this.colgrupAdi.Width = 53;
            // 
            // txtCariTelefon
            // 
            this.txtCariTelefon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCariTelefon.Location = new System.Drawing.Point(12, 180);
            this.txtCariTelefon.Name = "txtCariTelefon";
            this.txtCariTelefon.Size = new System.Drawing.Size(144, 20);
            this.txtCariTelefon.TabIndex = 7;
            // 
            // txtCariVergiTcNo
            // 
            this.txtCariVergiTcNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCariVergiTcNo.Location = new System.Drawing.Point(12, 135);
            this.txtCariVergiTcNo.Name = "txtCariVergiTcNo";
            this.txtCariVergiTcNo.Size = new System.Drawing.Size(144, 20);
            this.txtCariVergiTcNo.TabIndex = 5;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(12, 161);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(36, 13);
            this.labelControl9.TabIndex = 6;
            this.labelControl9.Text = "Telefon";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 116);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(63, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Vergi / TC No";
            // 
            // txtCariAd
            // 
            this.txtCariAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCariAd.Location = new System.Drawing.Point(12, 90);
            this.txtCariAd.Name = "txtCariAd";
            this.txtCariAd.Size = new System.Drawing.Size(144, 20);
            this.txtCariAd.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(15, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Adı";
            // 
            // txtCariKod
            // 
            this.txtCariKod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCariKod.Location = new System.Drawing.Point(12, 45);
            this.txtCariKod.Name = "txtCariKod";
            this.txtCariKod.Size = new System.Drawing.Size(144, 20);
            this.txtCariKod.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Cari Kodu";
            // 
            // grdCtrlCariListe
            // 
            this.grdCtrlCariListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCtrlCariListe.Location = new System.Drawing.Point(162, 0);
            this.grdCtrlCariListe.MainView = this.gridView1;
            this.grdCtrlCariListe.Name = "grdCtrlCariListe";
            this.grdCtrlCariListe.Size = new System.Drawing.Size(685, 317);
            this.grdCtrlCariListe.TabIndex = 1;
            this.grdCtrlCariListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colgrupcKod,
            this.colgrupcAd,
            this.colgrupcVTC,
            this.colgrupcTel});
            this.gridView1.GridControl = this.grdCtrlCariListe;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.Disabled;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            this.gridView1.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colgrupcKod
            // 
            this.colgrupcKod.Caption = "Cari Kodu";
            this.colgrupcKod.FieldName = "c_Kod";
            this.colgrupcKod.Name = "colgrupcKod";
            this.colgrupcKod.OptionsColumn.AllowEdit = false;
            this.colgrupcKod.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colgrupcKod.OptionsColumn.AllowMove = false;
            this.colgrupcKod.OptionsColumn.AllowShowHide = false;
            this.colgrupcKod.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colgrupcKod.OptionsFilter.AllowAutoFilter = false;
            this.colgrupcKod.OptionsFilter.AllowFilter = false;
            this.colgrupcKod.Visible = true;
            this.colgrupcKod.VisibleIndex = 0;
            // 
            // colgrupcAd
            // 
            this.colgrupcAd.Caption = "Cari Ad";
            this.colgrupcAd.FieldName = "c_Ad";
            this.colgrupcAd.Name = "colgrupcAd";
            this.colgrupcAd.OptionsColumn.AllowEdit = false;
            this.colgrupcAd.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colgrupcAd.OptionsColumn.AllowMove = false;
            this.colgrupcAd.OptionsColumn.AllowShowHide = false;
            this.colgrupcAd.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colgrupcAd.OptionsFilter.AllowAutoFilter = false;
            this.colgrupcAd.OptionsFilter.AllowFilter = false;
            this.colgrupcAd.Visible = true;
            this.colgrupcAd.VisibleIndex = 1;
            // 
            // colgrupcVTC
            // 
            this.colgrupcVTC.Caption = "Vergi-TC No";
            this.colgrupcVTC.FieldName = "c_Vergi_Tc_No";
            this.colgrupcVTC.Name = "colgrupcVTC";
            this.colgrupcVTC.OptionsColumn.AllowEdit = false;
            this.colgrupcVTC.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colgrupcVTC.OptionsColumn.AllowMove = false;
            this.colgrupcVTC.OptionsColumn.AllowShowHide = false;
            this.colgrupcVTC.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colgrupcVTC.OptionsFilter.AllowAutoFilter = false;
            this.colgrupcVTC.OptionsFilter.AllowFilter = false;
            this.colgrupcVTC.Visible = true;
            this.colgrupcVTC.VisibleIndex = 2;
            // 
            // colgrupcTel
            // 
            this.colgrupcTel.Caption = "Telefon";
            this.colgrupcTel.FieldName = "c_Tel";
            this.colgrupcTel.Name = "colgrupcTel";
            this.colgrupcTel.OptionsColumn.AllowEdit = false;
            this.colgrupcTel.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colgrupcTel.OptionsColumn.AllowMove = false;
            this.colgrupcTel.OptionsColumn.AllowShowHide = false;
            this.colgrupcTel.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colgrupcTel.OptionsFilter.AllowAutoFilter = false;
            this.colgrupcTel.OptionsFilter.AllowFilter = false;
            this.colgrupcTel.Visible = true;
            this.colgrupcTel.VisibleIndex = 3;
            // 
            // frmListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 317);
            this.Controls.Add(this.grdCtrlCariListe);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = global::WinFormsUI.Properties.Resources.Cari_Liste16x16;
            this.Name = "frmListe";
            this.Text = "Cari Listeleri";
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.grdCtrlCariListe, 0);
            this.Controls.SetChildIndex(this.btnBaseClose, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariVergiTcNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlCariListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtCariVergiTcNo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCariAd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCariKod;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl grdCtrlCariListe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtCariTelefon;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton btnCariGrupSil;
        private DevExpress.XtraEditors.SimpleButton btnCariGrupEkle;
        private System.Windows.Forms.ListView lstGruplar;
        private System.Windows.Forms.ColumnHeader colgrupId;
        private System.Windows.Forms.ColumnHeader colgrupKod;
        private System.Windows.Forms.ColumnHeader colgrupAciklama;
        private System.Windows.Forms.ColumnHeader colgrupAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colgrupcKod;
        private DevExpress.XtraGrid.Columns.GridColumn colgrupcAd;
        private DevExpress.XtraGrid.Columns.GridColumn colgrupcVTC;
        private DevExpress.XtraGrid.Columns.GridColumn colgrupcTel;
    }
}