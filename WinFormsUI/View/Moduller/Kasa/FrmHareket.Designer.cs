
namespace WinFormsUI.View.Moduller.Kasa
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
            this.grdCtrlKasaHareket = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtKasaBakiye = new DevExpress.XtraEditors.TextEdit();
            this.txtKasaToplamCikan = new DevExpress.XtraEditors.TextEdit();
            this.txtKasaToplamGiren = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtKasaAd = new DevExpress.XtraEditors.TextEdit();
            this.btnKasaKod = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlKasaHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaBakiye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaToplamCikan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaToplamGiren.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKasaKod.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnBaseClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBaseClose.FlatAppearance.BorderSize = 0;
            // 
            // grdCtrlKasaHareket
            // 
            this.grdCtrlKasaHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCtrlKasaHareket.Location = new System.Drawing.Point(0, 84);
            this.grdCtrlKasaHareket.MainView = this.gridView1;
            this.grdCtrlKasaHareket.Name = "grdCtrlKasaHareket";
            this.grdCtrlKasaHareket.Size = new System.Drawing.Size(796, 303);
            this.grdCtrlKasaHareket.TabIndex = 3;
            this.grdCtrlKasaHareket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdCtrlKasaHareket;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtKasaBakiye);
            this.groupControl1.Controls.Add(this.txtKasaToplamCikan);
            this.groupControl1.Controls.Add(this.txtKasaToplamGiren);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtKasaAd);
            this.groupControl1.Controls.Add(this.btnKasaKod);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(796, 84);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Kasa Bilgileri";
            // 
            // txtKasaBakiye
            // 
            this.txtKasaBakiye.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKasaBakiye.Enabled = false;
            this.txtKasaBakiye.Location = new System.Drawing.Point(677, 58);
            this.txtKasaBakiye.Name = "txtKasaBakiye";
            this.txtKasaBakiye.Size = new System.Drawing.Size(107, 20);
            this.txtKasaBakiye.TabIndex = 8;
            // 
            // txtKasaToplamCikan
            // 
            this.txtKasaToplamCikan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKasaToplamCikan.Enabled = false;
            this.txtKasaToplamCikan.Location = new System.Drawing.Point(527, 58);
            this.txtKasaToplamCikan.Name = "txtKasaToplamCikan";
            this.txtKasaToplamCikan.Size = new System.Drawing.Size(107, 20);
            this.txtKasaToplamCikan.TabIndex = 6;
            // 
            // txtKasaToplamGiren
            // 
            this.txtKasaToplamGiren.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKasaToplamGiren.Enabled = false;
            this.txtKasaToplamGiren.Location = new System.Drawing.Point(340, 58);
            this.txtKasaToplamGiren.Name = "txtKasaToplamGiren";
            this.txtKasaToplamGiren.Size = new System.Drawing.Size(107, 20);
            this.txtKasaToplamGiren.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Location = new System.Drawing.Point(453, 61);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(63, 13);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Toplam Çıkan";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(640, 61);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(31, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Bakiye";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(276, 61);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Toplam Giren";
            // 
            // txtKasaAd
            // 
            this.txtKasaAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKasaAd.Enabled = false;
            this.txtKasaAd.Location = new System.Drawing.Point(191, 32);
            this.txtKasaAd.Name = "txtKasaAd";
            this.txtKasaAd.Size = new System.Drawing.Size(593, 20);
            this.txtKasaAd.TabIndex = 2;
            // 
            // btnKasaKod
            // 
            this.btnKasaKod.Location = new System.Drawing.Point(66, 32);
            this.btnKasaKod.Name = "btnKasaKod";
            this.btnKasaKod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnKasaKod.Size = new System.Drawing.Size(119, 20);
            this.btnKasaKod.TabIndex = 1;
            this.btnKasaKod.Tag = "Kasa.frmListe";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kasa Kodu";
            // 
            // frmHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 387);
            this.Controls.Add(this.grdCtrlKasaHareket);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = global::WinFormsUI.Properties.Resources.Kasa_Hareket16x16;
            this.Name = "frmHareket";
            this.Text = "Kasa Hareketleri";
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.grdCtrlKasaHareket, 0);
            this.Controls.SetChildIndex(this.btnBaseClose, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlKasaHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaBakiye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaToplamCikan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaToplamGiren.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKasaKod.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdCtrlKasaHareket;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtKasaBakiye;
        private DevExpress.XtraEditors.TextEdit txtKasaToplamCikan;
        private DevExpress.XtraEditors.TextEdit txtKasaToplamGiren;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtKasaAd;
        private DevExpress.XtraEditors.ButtonEdit btnKasaKod;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}