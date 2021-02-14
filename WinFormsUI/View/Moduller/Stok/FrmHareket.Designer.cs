
namespace WinFormsUI.View.Moduller.Stok
{
    partial class FrmHareket
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
            this.txtStokBakiye = new DevExpress.XtraEditors.TextEdit();
            this.txtStokToplamCikan = new DevExpress.XtraEditors.TextEdit();
            this.txtStokToplamGiren = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtStokAd = new DevExpress.XtraEditors.TextEdit();
            this.btnEditStokKod = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grdCtrlStokHareket = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiren = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCikan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonel = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokBakiye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokToplamCikan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokToplamGiren.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditStokKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlStokHareket)).BeginInit();
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
            this.groupControl1.Controls.Add(this.txtStokBakiye);
            this.groupControl1.Controls.Add(this.txtStokToplamCikan);
            this.groupControl1.Controls.Add(this.txtStokToplamGiren);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtStokAd);
            this.groupControl1.Controls.Add(this.btnEditStokKod);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(662, 78);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Stok Bilgileri";
            // 
            // txtStokBakiye
            // 
            this.txtStokBakiye.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStokBakiye.Enabled = false;
            this.txtStokBakiye.Location = new System.Drawing.Point(543, 50);
            this.txtStokBakiye.Name = "txtStokBakiye";
            this.txtStokBakiye.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtStokBakiye.Size = new System.Drawing.Size(107, 18);
            this.txtStokBakiye.TabIndex = 10;
            // 
            // txtStokToplamCikan
            // 
            this.txtStokToplamCikan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStokToplamCikan.Enabled = false;
            this.txtStokToplamCikan.Location = new System.Drawing.Point(393, 50);
            this.txtStokToplamCikan.Name = "txtStokToplamCikan";
            this.txtStokToplamCikan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtStokToplamCikan.Size = new System.Drawing.Size(107, 18);
            this.txtStokToplamCikan.TabIndex = 8;
            // 
            // txtStokToplamGiren
            // 
            this.txtStokToplamGiren.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStokToplamGiren.Enabled = false;
            this.txtStokToplamGiren.Location = new System.Drawing.Point(211, 50);
            this.txtStokToplamGiren.Name = "txtStokToplamGiren";
            this.txtStokToplamGiren.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtStokToplamGiren.Size = new System.Drawing.Size(107, 18);
            this.txtStokToplamGiren.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Location = new System.Drawing.Point(324, 53);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(63, 13);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Toplam Çıkan";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(506, 53);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(31, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Bakiye";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(143, 53);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Toplam Giren";
            // 
            // txtStokAd
            // 
            this.txtStokAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStokAd.Enabled = false;
            this.txtStokAd.Location = new System.Drawing.Point(191, 26);
            this.txtStokAd.Name = "txtStokAd";
            this.txtStokAd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtStokAd.Size = new System.Drawing.Size(459, 18);
            this.txtStokAd.TabIndex = 2;
            // 
            // btnEditStokKod
            // 
            this.btnEditStokKod.Location = new System.Drawing.Point(66, 26);
            this.btnEditStokKod.Name = "btnEditStokKod";
            this.btnEditStokKod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnEditStokKod.Size = new System.Drawing.Size(119, 20);
            this.btnEditStokKod.TabIndex = 1;
            this.btnEditStokKod.Tag = "Stok.frmListe";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Stok Kodu";
            // 
            // grdCtrlStokHareket
            // 
            this.grdCtrlStokHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCtrlStokHareket.Location = new System.Drawing.Point(0, 78);
            this.grdCtrlStokHareket.MainView = this.gridView1;
            this.grdCtrlStokHareket.Name = "grdCtrlStokHareket";
            this.grdCtrlStokHareket.Size = new System.Drawing.Size(662, 326);
            this.grdCtrlStokHareket.TabIndex = 1;
            this.grdCtrlStokHareket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCariKod,
            this.colCariAd,
            this.colGiren,
            this.colCikan,
            this.colBirim,
            this.colFiyat,
            this.colTarih,
            this.colAciklama,
            this.colPersonel});
            this.gridView1.GridControl = this.grdCtrlStokHareket;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.Disabled;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colId.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colId.AppearanceHeader.Options.UseFont = true;
            this.colId.AppearanceHeader.Options.UseForeColor = true;
            this.colId.FieldName = "s_har_id";
            this.colId.Name = "colId";
            // 
            // colCariKod
            // 
            this.colCariKod.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colCariKod.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colCariKod.AppearanceHeader.Options.UseFont = true;
            this.colCariKod.AppearanceHeader.Options.UseForeColor = true;
            this.colCariKod.Caption = "Cari Kodu";
            this.colCariKod.FieldName = "c_Kod";
            this.colCariKod.Name = "colCariKod";
            this.colCariKod.OptionsColumn.AllowEdit = false;
            this.colCariKod.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCariKod.OptionsColumn.ReadOnly = true;
            this.colCariKod.OptionsFilter.AllowAutoFilter = false;
            this.colCariKod.OptionsFilter.AllowFilter = false;
            this.colCariKod.Visible = true;
            this.colCariKod.VisibleIndex = 0;
            // 
            // colCariAd
            // 
            this.colCariAd.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colCariAd.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colCariAd.AppearanceHeader.Options.UseFont = true;
            this.colCariAd.AppearanceHeader.Options.UseForeColor = true;
            this.colCariAd.Caption = "Cari Adı";
            this.colCariAd.FieldName = "c_Ad";
            this.colCariAd.Name = "colCariAd";
            this.colCariAd.OptionsColumn.AllowEdit = false;
            this.colCariAd.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCariAd.OptionsColumn.ReadOnly = true;
            this.colCariAd.OptionsFilter.AllowAutoFilter = false;
            this.colCariAd.OptionsFilter.AllowFilter = false;
            this.colCariAd.Visible = true;
            this.colCariAd.VisibleIndex = 1;
            // 
            // colGiren
            // 
            this.colGiren.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colGiren.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colGiren.AppearanceHeader.Options.UseFont = true;
            this.colGiren.AppearanceHeader.Options.UseForeColor = true;
            this.colGiren.Caption = "Alış Miktarı";
            this.colGiren.FieldName = "s_AlisMiktar";
            this.colGiren.Name = "colGiren";
            this.colGiren.OptionsColumn.AllowEdit = false;
            this.colGiren.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colGiren.OptionsColumn.ReadOnly = true;
            this.colGiren.OptionsFilter.AllowAutoFilter = false;
            this.colGiren.OptionsFilter.AllowFilter = false;
            this.colGiren.Visible = true;
            this.colGiren.VisibleIndex = 2;
            // 
            // colCikan
            // 
            this.colCikan.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colCikan.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colCikan.AppearanceHeader.Options.UseFont = true;
            this.colCikan.AppearanceHeader.Options.UseForeColor = true;
            this.colCikan.Caption = "Satış Miktarı";
            this.colCikan.FieldName = "s_SatisMiktar";
            this.colCikan.Name = "colCikan";
            this.colCikan.OptionsColumn.AllowEdit = false;
            this.colCikan.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCikan.OptionsColumn.ReadOnly = true;
            this.colCikan.OptionsFilter.AllowAutoFilter = false;
            this.colCikan.OptionsFilter.AllowFilter = false;
            this.colCikan.Visible = true;
            this.colCikan.VisibleIndex = 3;
            // 
            // colBirim
            // 
            this.colBirim.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colBirim.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colBirim.AppearanceHeader.Options.UseFont = true;
            this.colBirim.AppearanceHeader.Options.UseForeColor = true;
            this.colBirim.Caption = "Birimi";
            this.colBirim.FieldName = "s_har_Birim";
            this.colBirim.Name = "colBirim";
            this.colBirim.OptionsColumn.AllowEdit = false;
            this.colBirim.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBirim.OptionsColumn.ReadOnly = true;
            this.colBirim.OptionsFilter.AllowAutoFilter = false;
            this.colBirim.OptionsFilter.AllowFilter = false;
            this.colBirim.Visible = true;
            this.colBirim.VisibleIndex = 4;
            // 
            // colFiyat
            // 
            this.colFiyat.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colFiyat.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colFiyat.AppearanceHeader.Options.UseFont = true;
            this.colFiyat.AppearanceHeader.Options.UseForeColor = true;
            this.colFiyat.Caption = "Birim Fiyatı";
            this.colFiyat.FieldName = "s_har_Fiyat";
            this.colFiyat.Name = "colFiyat";
            this.colFiyat.OptionsColumn.AllowEdit = false;
            this.colFiyat.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colFiyat.OptionsColumn.ReadOnly = true;
            this.colFiyat.OptionsFilter.AllowAutoFilter = false;
            this.colFiyat.OptionsFilter.AllowFilter = false;
            this.colFiyat.Visible = true;
            this.colFiyat.VisibleIndex = 5;
            // 
            // colTarih
            // 
            this.colTarih.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colTarih.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colTarih.AppearanceHeader.Options.UseFont = true;
            this.colTarih.AppearanceHeader.Options.UseForeColor = true;
            this.colTarih.Caption = "İşlem Tarihi";
            this.colTarih.FieldName = "s_har_Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTarih.OptionsColumn.ReadOnly = true;
            this.colTarih.OptionsFilter.AllowAutoFilter = false;
            this.colTarih.OptionsFilter.AllowFilter = false;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 6;
            // 
            // colAciklama
            // 
            this.colAciklama.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colAciklama.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colAciklama.AppearanceHeader.Options.UseFont = true;
            this.colAciklama.AppearanceHeader.Options.UseForeColor = true;
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "s_har_Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAciklama.OptionsColumn.ReadOnly = true;
            this.colAciklama.OptionsFilter.AllowAutoFilter = false;
            this.colAciklama.OptionsFilter.AllowFilter = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 7;
            // 
            // colPersonel
            // 
            this.colPersonel.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colPersonel.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colPersonel.AppearanceHeader.Options.UseFont = true;
            this.colPersonel.AppearanceHeader.Options.UseForeColor = true;
            this.colPersonel.Caption = "İşlemi Yapan Personel";
            this.colPersonel.FieldName = "p_AdSoyad";
            this.colPersonel.Name = "colPersonel";
            this.colPersonel.OptionsColumn.AllowEdit = false;
            this.colPersonel.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPersonel.OptionsColumn.ReadOnly = true;
            this.colPersonel.OptionsFilter.AllowAutoFilter = false;
            this.colPersonel.OptionsFilter.AllowFilter = false;
            this.colPersonel.Visible = true;
            this.colPersonel.VisibleIndex = 8;
            // 
            // frmHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 404);
            this.Controls.Add(this.grdCtrlStokHareket);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = global::WinFormsUI.Properties.Resources.Stok_Hareket16x16;
            this.Name = "frmHareket";
            this.Text = "Stok Hareketleri";
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.grdCtrlStokHareket, 0);
            this.Controls.SetChildIndex(this.btnBaseClose, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokBakiye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokToplamCikan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokToplamGiren.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditStokKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlStokHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtStokAd;
        private DevExpress.XtraEditors.ButtonEdit btnEditStokKod;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl grdCtrlStokHareket;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtStokBakiye;
        private DevExpress.XtraEditors.TextEdit txtStokToplamCikan;
        private DevExpress.XtraEditors.TextEdit txtStokToplamGiren;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCariKod;
        private DevExpress.XtraGrid.Columns.GridColumn colCariAd;
        private DevExpress.XtraGrid.Columns.GridColumn colGiren;
        private DevExpress.XtraGrid.Columns.GridColumn colCikan;
        private DevExpress.XtraGrid.Columns.GridColumn colBirim;
        private DevExpress.XtraGrid.Columns.GridColumn colFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonel;
    }
}