
namespace WinFormsUI.View.Moduller.Stok
{
    partial class FrmGrup
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
            this.grdCtrlStokGrupKod = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.uscGrupButon = new WinFormsUI.View.UserControls.gridButtons();
            this.grpEkleGuncelle = new DevExpress.XtraEditors.GroupControl();
            this.lblGrupAciklama = new DevExpress.XtraEditors.LabelControl();
            this.lblGrupAd = new DevExpress.XtraEditors.LabelControl();
            this.lblGrupKod = new DevExpress.XtraEditors.LabelControl();
            this.txtGrupAd = new DevExpress.XtraEditors.TextEdit();
            this.txtGrupKod = new DevExpress.XtraEditors.TextEdit();
            this.txtAciklama = new DevExpress.XtraEditors.TextEdit();
            this.lsbGruplar = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlStokGrupKod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpEkleGuncelle)).BeginInit();
            this.grpEkleGuncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBaseClose
            // 
            this.btnBaseClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBaseClose.FlatAppearance.BorderSize = 0;
            this.btnBaseClose.Location = new System.Drawing.Point(49, -36);
            // 
            // grdCtrlStokGrupKod
            // 
            this.grdCtrlStokGrupKod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCtrlStokGrupKod.Location = new System.Drawing.Point(120, 116);
            this.grdCtrlStokGrupKod.MainView = this.gridView1;
            this.grdCtrlStokGrupKod.Name = "grdCtrlStokGrupKod";
            this.grdCtrlStokGrupKod.Size = new System.Drawing.Size(514, 177);
            this.grdCtrlStokGrupKod.TabIndex = 2;
            this.grdCtrlStokGrupKod.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colKod,
            this.colAd,
            this.colAciklama});
            this.gridView1.GridControl = this.grdCtrlStokGrupKod;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.Disabled;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            this.gridView1.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridView1.OptionsMenu.ShowGroupSortSummaryItems = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colKod, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colid
            // 
            this.colid.Caption = "Id";
            this.colid.FieldName = "s_grupKod_Id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colid.OptionsColumn.AllowShowHide = false;
            this.colid.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colid.Width = 102;
            // 
            // colKod
            // 
            this.colKod.Caption = "Kodu";
            this.colKod.FieldName = "s_grupKod_No";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colKod.OptionsColumn.AllowShowHide = false;
            this.colKod.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colKod.OptionsColumn.FixedWidth = true;
            this.colKod.Visible = true;
            this.colKod.VisibleIndex = 0;
            // 
            // colAd
            // 
            this.colAd.Caption = "Adı";
            this.colAd.FieldName = "s_grupKod_Adi";
            this.colAd.Name = "colAd";
            this.colAd.OptionsColumn.AllowEdit = false;
            this.colAd.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colAd.OptionsColumn.AllowShowHide = false;
            this.colAd.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAd.OptionsColumn.FixedWidth = true;
            this.colAd.Visible = true;
            this.colAd.VisibleIndex = 1;
            this.colAd.Width = 102;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "s_grupKod_Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colAciklama.OptionsColumn.AllowShowHide = false;
            this.colAciklama.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 2;
            this.colAciklama.Width = 479;
            // 
            // uscGrupButon
            // 
            this.uscGrupButon.btnCancel_Text = "Sil";
            this.uscGrupButon.btnTemizleVisible = true;
            this.uscGrupButon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uscGrupButon.Location = new System.Drawing.Point(2, 75);
            this.uscGrupButon.Name = "uscGrupButon";
            this.uscGrupButon.Size = new System.Drawing.Size(630, 39);
            this.uscGrupButon.TabIndex = 3;
            // 
            // grpEkleGuncelle
            // 
            this.grpEkleGuncelle.Controls.Add(this.lblGrupAciklama);
            this.grpEkleGuncelle.Controls.Add(this.lblGrupAd);
            this.grpEkleGuncelle.Controls.Add(this.uscGrupButon);
            this.grpEkleGuncelle.Controls.Add(this.lblGrupKod);
            this.grpEkleGuncelle.Controls.Add(this.txtGrupAd);
            this.grpEkleGuncelle.Controls.Add(this.txtGrupKod);
            this.grpEkleGuncelle.Controls.Add(this.txtAciklama);
            this.grpEkleGuncelle.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpEkleGuncelle.Location = new System.Drawing.Point(0, 0);
            this.grpEkleGuncelle.Name = "grpEkleGuncelle";
            this.grpEkleGuncelle.Size = new System.Drawing.Size(634, 116);
            this.grpEkleGuncelle.TabIndex = 1;
            this.grpEkleGuncelle.Text = "Grup Ekle Guncelle";
            // 
            // lblGrupAciklama
            // 
            this.lblGrupAciklama.Location = new System.Drawing.Point(218, 26);
            this.lblGrupAciklama.Name = "lblGrupAciklama";
            this.lblGrupAciklama.Size = new System.Drawing.Size(41, 13);
            this.lblGrupAciklama.TabIndex = 5;
            this.lblGrupAciklama.Text = "Açıklama";
            // 
            // lblGrupAd
            // 
            this.lblGrupAd.Location = new System.Drawing.Point(112, 26);
            this.lblGrupAd.Name = "lblGrupAd";
            this.lblGrupAd.Size = new System.Drawing.Size(41, 13);
            this.lblGrupAd.TabIndex = 4;
            this.lblGrupAd.Text = "Grup Adı";
            // 
            // lblGrupKod
            // 
            this.lblGrupKod.Location = new System.Drawing.Point(5, 26);
            this.lblGrupKod.Name = "lblGrupKod";
            this.lblGrupKod.Size = new System.Drawing.Size(50, 13);
            this.lblGrupKod.TabIndex = 3;
            this.lblGrupKod.Text = "Grup Kodu";
            // 
            // txtGrupAd
            // 
            this.txtGrupAd.Location = new System.Drawing.Point(112, 45);
            this.txtGrupAd.Name = "txtGrupAd";
            this.txtGrupAd.Size = new System.Drawing.Size(100, 20);
            this.txtGrupAd.TabIndex = 1;
            // 
            // txtGrupKod
            // 
            this.txtGrupKod.Location = new System.Drawing.Point(5, 45);
            this.txtGrupKod.Name = "txtGrupKod";
            this.txtGrupKod.Size = new System.Drawing.Size(100, 20);
            this.txtGrupKod.TabIndex = 0;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAciklama.Location = new System.Drawing.Point(218, 45);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(404, 20);
            this.txtAciklama.TabIndex = 2;
            // 
            // lsbGruplar
            // 
            this.lsbGruplar.Dock = System.Windows.Forms.DockStyle.Left;
            this.lsbGruplar.FormattingEnabled = true;
            this.lsbGruplar.Location = new System.Drawing.Point(0, 116);
            this.lsbGruplar.Name = "lsbGruplar";
            this.lsbGruplar.Size = new System.Drawing.Size(120, 177);
            this.lsbGruplar.TabIndex = 3;
            // 
            // frmGrup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 293);
            this.Controls.Add(this.grdCtrlStokGrupKod);
            this.Controls.Add(this.lsbGruplar);
            this.Controls.Add(this.grpEkleGuncelle);
            this.IconOptions.Image = global::WinFormsUI.Properties.Resources.Stok_Grup16x16;
            this.Name = "frmGrup";
            this.Text = "Stok Grupları";
            this.Controls.SetChildIndex(this.btnBaseClose, 0);
            this.Controls.SetChildIndex(this.grpEkleGuncelle, 0);
            this.Controls.SetChildIndex(this.lsbGruplar, 0);
            this.Controls.SetChildIndex(this.grdCtrlStokGrupKod, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlStokGrupKod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpEkleGuncelle)).EndInit();
            this.grpEkleGuncelle.ResumeLayout(false);
            this.grpEkleGuncelle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdCtrlStokGrupKod;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colKod;
        private DevExpress.XtraGrid.Columns.GridColumn colAd;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private UserControls.gridButtons uscGrupButon;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraEditors.GroupControl grpEkleGuncelle;
        private DevExpress.XtraEditors.LabelControl lblGrupAciklama;
        private DevExpress.XtraEditors.LabelControl lblGrupAd;
        private DevExpress.XtraEditors.LabelControl lblGrupKod;
        private DevExpress.XtraEditors.TextEdit txtGrupAd;
        private DevExpress.XtraEditors.TextEdit txtGrupKod;
        private DevExpress.XtraEditors.TextEdit txtAciklama;
        private System.Windows.Forms.ListBox lsbGruplar;
    }
}