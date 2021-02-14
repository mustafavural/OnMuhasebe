
namespace WinFormsUI.View.Moduller.Stok
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
            this.btnStokGrupSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnStokGrupEkle = new DevExpress.XtraEditors.SimpleButton();
            this.lstGruplar = new System.Windows.Forms.ListView();
            this.colgrupId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colgrupKod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colgrupAciklama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colgrupAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txts_Kdv = new DevExpress.XtraEditors.TextEdit();
            this.KDV = new DevExpress.XtraEditors.LabelControl();
            this.txts_Ad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txts_Barkod = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txts_Kod = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grdCtrlStokListe = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstokkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAd = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txts_Kdv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txts_Ad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txts_Barkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txts_Kod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlStokListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBaseClose
            // 
            this.btnBaseClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBaseClose.FlatAppearance.BorderSize = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnStokGrupSil);
            this.groupControl1.Controls.Add(this.btnStokGrupEkle);
            this.groupControl1.Controls.Add(this.lstGruplar);
            this.groupControl1.Controls.Add(this.txts_Kdv);
            this.groupControl1.Controls.Add(this.KDV);
            this.groupControl1.Controls.Add(this.txts_Ad);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txts_Barkod);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txts_Kod);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(162, 468);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Stok Bilgileri";
            // 
            // btnStokGrupSil
            // 
            this.btnStokGrupSil.ImageOptions.Image = global::WinFormsUI.Properties.Resources.Sil32x32;
            this.btnStokGrupSil.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.btnStokGrupSil.Location = new System.Drawing.Point(106, 206);
            this.btnStokGrupSil.Name = "btnStokGrupSil";
            this.btnStokGrupSil.Size = new System.Drawing.Size(32, 32);
            this.btnStokGrupSil.TabIndex = 10;
            // 
            // btnStokGrupEkle
            // 
            this.btnStokGrupEkle.ImageOptions.Image = global::WinFormsUI.Properties.Resources.Ara32x32;
            this.btnStokGrupEkle.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.btnStokGrupEkle.Location = new System.Drawing.Point(28, 206);
            this.btnStokGrupEkle.Name = "btnStokGrupEkle";
            this.btnStokGrupEkle.Size = new System.Drawing.Size(32, 32);
            this.btnStokGrupEkle.TabIndex = 9;
            this.btnStokGrupEkle.Tag = "Stok.frmGrup";
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
            this.lstGruplar.Location = new System.Drawing.Point(12, 244);
            this.lstGruplar.MultiSelect = false;
            this.lstGruplar.Name = "lstGruplar";
            this.lstGruplar.Size = new System.Drawing.Size(144, 212);
            this.lstGruplar.TabIndex = 8;
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
            // txts_Kdv
            // 
            this.txts_Kdv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txts_Kdv.Location = new System.Drawing.Point(12, 180);
            this.txts_Kdv.Name = "txts_Kdv";
            this.txts_Kdv.Size = new System.Drawing.Size(144, 20);
            this.txts_Kdv.TabIndex = 7;
            // 
            // KDV
            // 
            this.KDV.Location = new System.Drawing.Point(12, 161);
            this.KDV.Name = "KDV";
            this.KDV.Size = new System.Drawing.Size(19, 13);
            this.KDV.TabIndex = 6;
            this.KDV.Text = "KDV";
            // 
            // txts_Ad
            // 
            this.txts_Ad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txts_Ad.Location = new System.Drawing.Point(12, 135);
            this.txts_Ad.Name = "txts_Ad";
            this.txts_Ad.Size = new System.Drawing.Size(144, 20);
            this.txts_Ad.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 116);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Stok Adı";
            // 
            // txts_Barkod
            // 
            this.txts_Barkod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txts_Barkod.Location = new System.Drawing.Point(12, 90);
            this.txts_Barkod.Name = "txts_Barkod";
            this.txts_Barkod.Size = new System.Drawing.Size(144, 20);
            this.txts_Barkod.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Barkodu";
            // 
            // txts_Kod
            // 
            this.txts_Kod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txts_Kod.Location = new System.Drawing.Point(12, 45);
            this.txts_Kod.Name = "txts_Kod";
            this.txts_Kod.Size = new System.Drawing.Size(144, 20);
            this.txts_Kod.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Stok Kodu";
            // 
            // grdCtrlStokListe
            // 
            this.grdCtrlStokListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCtrlStokListe.Location = new System.Drawing.Point(162, 0);
            this.grdCtrlStokListe.MainView = this.gridView1;
            this.grdCtrlStokListe.Name = "grdCtrlStokListe";
            this.grdCtrlStokListe.Size = new System.Drawing.Size(538, 468);
            this.grdCtrlStokListe.TabIndex = 1;
            this.grdCtrlStokListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colstokkod,
            this.colBarkodu,
            this.colStokAd});
            this.gridView1.GridControl = this.grdCtrlStokListe;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.Disabled;
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colId.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colId.AppearanceHeader.Options.UseFont = true;
            this.colId.AppearanceHeader.Options.UseForeColor = true;
            this.colId.FieldName = "s_Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colId.OptionsColumn.AllowMove = false;
            this.colId.OptionsColumn.AllowShowHide = false;
            this.colId.OptionsColumn.AllowSize = false;
            this.colId.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colId.OptionsFilter.AllowAutoFilter = false;
            this.colId.OptionsFilter.AllowFilter = false;
            // 
            // colstokkod
            // 
            this.colstokkod.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colstokkod.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colstokkod.AppearanceHeader.Options.UseFont = true;
            this.colstokkod.AppearanceHeader.Options.UseForeColor = true;
            this.colstokkod.Caption = "Stok Kodu";
            this.colstokkod.FieldName = "s_Kod";
            this.colstokkod.Name = "colstokkod";
            this.colstokkod.OptionsColumn.AllowEdit = false;
            this.colstokkod.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colstokkod.OptionsColumn.AllowMove = false;
            this.colstokkod.OptionsColumn.AllowShowHide = false;
            this.colstokkod.OptionsColumn.AllowSize = false;
            this.colstokkod.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colstokkod.OptionsFilter.AllowAutoFilter = false;
            this.colstokkod.OptionsFilter.AllowFilter = false;
            this.colstokkod.Visible = true;
            this.colstokkod.VisibleIndex = 0;
            // 
            // colBarkodu
            // 
            this.colBarkodu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colBarkodu.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colBarkodu.AppearanceHeader.Options.UseFont = true;
            this.colBarkodu.AppearanceHeader.Options.UseForeColor = true;
            this.colBarkodu.Caption = "Barkodu";
            this.colBarkodu.FieldName = "s_Barkod";
            this.colBarkodu.Name = "colBarkodu";
            this.colBarkodu.OptionsColumn.AllowEdit = false;
            this.colBarkodu.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colBarkodu.OptionsColumn.AllowMove = false;
            this.colBarkodu.OptionsColumn.AllowShowHide = false;
            this.colBarkodu.OptionsColumn.AllowSize = false;
            this.colBarkodu.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBarkodu.OptionsFilter.AllowAutoFilter = false;
            this.colBarkodu.OptionsFilter.AllowFilter = false;
            this.colBarkodu.Visible = true;
            this.colBarkodu.VisibleIndex = 1;
            // 
            // colStokAd
            // 
            this.colStokAd.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colStokAd.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colStokAd.AppearanceHeader.Options.UseFont = true;
            this.colStokAd.AppearanceHeader.Options.UseForeColor = true;
            this.colStokAd.Caption = "Stok Adı";
            this.colStokAd.FieldName = "s_Ad";
            this.colStokAd.Name = "colStokAd";
            this.colStokAd.OptionsColumn.AllowEdit = false;
            this.colStokAd.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colStokAd.OptionsColumn.AllowMove = false;
            this.colStokAd.OptionsColumn.AllowShowHide = false;
            this.colStokAd.OptionsColumn.AllowSize = false;
            this.colStokAd.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colStokAd.OptionsFilter.AllowAutoFilter = false;
            this.colStokAd.OptionsFilter.AllowFilter = false;
            this.colStokAd.Visible = true;
            this.colStokAd.VisibleIndex = 2;
            // 
            // frmListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 468);
            this.Controls.Add(this.grdCtrlStokListe);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = global::WinFormsUI.Properties.Resources.Stok_Liste16x16;
            this.Name = "frmListe";
            this.Text = "Stok Listeleri";
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.grdCtrlStokListe, 0);
            this.Controls.SetChildIndex(this.btnBaseClose, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txts_Kdv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txts_Ad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txts_Barkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txts_Kod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlStokListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txts_Ad;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txts_Barkod;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txts_Kod;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl grdCtrlStokListe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colstokkod;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkodu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAd;
        private DevExpress.XtraEditors.TextEdit txts_Kdv;
        private DevExpress.XtraEditors.LabelControl KDV;
        private System.Windows.Forms.ListView lstGruplar;
        private System.Windows.Forms.ColumnHeader colgrupKod;
        private System.Windows.Forms.ColumnHeader colgrupAdi;
        private System.Windows.Forms.ColumnHeader colgrupAciklama;
        private DevExpress.XtraEditors.SimpleButton btnStokGrupSil;
        private DevExpress.XtraEditors.SimpleButton btnStokGrupEkle;
        private System.Windows.Forms.ColumnHeader colgrupId;
    }
}