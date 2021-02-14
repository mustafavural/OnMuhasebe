
namespace WinFormsUI.View.Moduller.Cari
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
            this.txtCariBakiye = new DevExpress.XtraEditors.TextEdit();
            this.txtCariToplamCikan = new DevExpress.XtraEditors.TextEdit();
            this.txtCariToplamGiren = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCariAd = new DevExpress.XtraEditors.TextEdit();
            this.btnCariKod = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grdCtrlCariHareket = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colharId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colharTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colharBorc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colharAlacak = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colharAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariBakiye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariToplamCikan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariToplamGiren.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCariKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlCariHareket)).BeginInit();
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
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.txtCariBakiye);
            this.groupControl1.Controls.Add(this.txtCariToplamCikan);
            this.groupControl1.Controls.Add(this.txtCariToplamGiren);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtCariAd);
            this.groupControl1.Controls.Add(this.btnCariKod);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(756, 66);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Cari Bilgileri";
            // 
            // txtCariBakiye
            // 
            this.txtCariBakiye.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCariBakiye.Enabled = false;
            this.txtCariBakiye.Location = new System.Drawing.Point(637, 38);
            this.txtCariBakiye.Name = "txtCariBakiye";
            this.txtCariBakiye.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtCariBakiye.Size = new System.Drawing.Size(107, 18);
            this.txtCariBakiye.TabIndex = 8;
            // 
            // txtCariToplamCikan
            // 
            this.txtCariToplamCikan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCariToplamCikan.Enabled = false;
            this.txtCariToplamCikan.Location = new System.Drawing.Point(487, 38);
            this.txtCariToplamCikan.Name = "txtCariToplamCikan";
            this.txtCariToplamCikan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtCariToplamCikan.Size = new System.Drawing.Size(107, 18);
            this.txtCariToplamCikan.TabIndex = 6;
            // 
            // txtCariToplamGiren
            // 
            this.txtCariToplamGiren.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCariToplamGiren.Enabled = false;
            this.txtCariToplamGiren.Location = new System.Drawing.Point(300, 38);
            this.txtCariToplamGiren.Name = "txtCariToplamGiren";
            this.txtCariToplamGiren.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtCariToplamGiren.Size = new System.Drawing.Size(107, 18);
            this.txtCariToplamGiren.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Location = new System.Drawing.Point(413, 41);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(68, 13);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Toplam Alacak";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(600, 41);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(31, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Bakiye";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(236, 41);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Toplam Borç";
            // 
            // txtCariAd
            // 
            this.txtCariAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCariAd.Enabled = false;
            this.txtCariAd.Location = new System.Drawing.Point(191, 12);
            this.txtCariAd.Name = "txtCariAd";
            this.txtCariAd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtCariAd.Size = new System.Drawing.Size(553, 18);
            this.txtCariAd.TabIndex = 2;
            // 
            // btnCariKod
            // 
            this.btnCariKod.Location = new System.Drawing.Point(66, 12);
            this.btnCariKod.Name = "btnCariKod";
            this.btnCariKod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnCariKod.Size = new System.Drawing.Size(119, 20);
            this.btnCariKod.TabIndex = 1;
            this.btnCariKod.Tag = "Cari.frmListe";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Cari Kodu";
            // 
            // grdCtrlCariHareket
            // 
            this.grdCtrlCariHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCtrlCariHareket.Location = new System.Drawing.Point(0, 66);
            this.grdCtrlCariHareket.MainView = this.gridView1;
            this.grdCtrlCariHareket.Name = "grdCtrlCariHareket";
            this.grdCtrlCariHareket.Size = new System.Drawing.Size(756, 339);
            this.grdCtrlCariHareket.TabIndex = 1;
            this.grdCtrlCariHareket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colharId,
            this.colharTarih,
            this.colharBorc,
            this.colharAlacak,
            this.colharAciklama});
            this.gridView1.GridControl = this.grdCtrlCariHareket;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colharId
            // 
            this.colharId.FieldName = "c_har_Id";
            this.colharId.Name = "colharId";
            // 
            // colharTarih
            // 
            this.colharTarih.Caption = "Tarih";
            this.colharTarih.FieldName = "c_har_Tarih";
            this.colharTarih.Name = "colharTarih";
            this.colharTarih.Visible = true;
            this.colharTarih.VisibleIndex = 0;
            // 
            // colharBorc
            // 
            this.colharBorc.Caption = "Borç";
            this.colharBorc.FieldName = "c_har_Borc";
            this.colharBorc.Name = "colharBorc";
            this.colharBorc.Visible = true;
            this.colharBorc.VisibleIndex = 1;
            // 
            // colharAlacak
            // 
            this.colharAlacak.Caption = "Alacak";
            this.colharAlacak.FieldName = "c_har_Alacak";
            this.colharAlacak.Name = "colharAlacak";
            this.colharAlacak.Visible = true;
            this.colharAlacak.VisibleIndex = 2;
            // 
            // colharAciklama
            // 
            this.colharAciklama.Caption = "Açıklama";
            this.colharAciklama.FieldName = "c_har_Aciklama";
            this.colharAciklama.Name = "colharAciklama";
            this.colharAciklama.Visible = true;
            this.colharAciklama.VisibleIndex = 3;
            // 
            // frmHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 405);
            this.Controls.Add(this.grdCtrlCariHareket);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = global::WinFormsUI.Properties.Resources.Cari_Hareket16x16;
            this.Name = "frmHareket";
            this.Text = "Cari Hareketleri";
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.grdCtrlCariHareket, 0);
            this.Controls.SetChildIndex(this.btnBaseClose, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariBakiye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariToplamCikan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariToplamGiren.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCariKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlCariHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl grdCtrlCariHareket;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtCariBakiye;
        private DevExpress.XtraEditors.TextEdit txtCariToplamCikan;
        private DevExpress.XtraEditors.TextEdit txtCariToplamGiren;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCariAd;
        private DevExpress.XtraEditors.ButtonEdit btnCariKod;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colharId;
        private DevExpress.XtraGrid.Columns.GridColumn colharTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colharBorc;
        private DevExpress.XtraGrid.Columns.GridColumn colharAlacak;
        private DevExpress.XtraGrid.Columns.GridColumn colharAciklama;
    }
}