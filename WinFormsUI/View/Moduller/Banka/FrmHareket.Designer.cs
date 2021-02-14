
namespace WinFormsUI.View.Moduller.Banka
{
    partial class FrmHareket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit btnBankaHesapKod;
        private DevExpress.XtraGrid.GridControl grdctrlBankaHareket;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtBankaBakiye;
        private DevExpress.XtraEditors.TextEdit txtBankaCikis;
        private DevExpress.XtraEditors.TextEdit txtBankaGiris;
        private DevExpress.XtraEditors.TextEdit txtBankaIBANNo;
        private DevExpress.XtraEditors.TextEdit txtBankaHesapAd;
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
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtBankaBakiye = new DevExpress.XtraEditors.TextEdit();
            this.txtBankaCikis = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnBankaHesapKod = new DevExpress.XtraEditors.ButtonEdit();
            this.txtBankaGiris = new DevExpress.XtraEditors.TextEdit();
            this.txtBankaIBANNo = new DevExpress.XtraEditors.TextEdit();
            this.txtBankaHesapAd = new DevExpress.XtraEditors.TextEdit();
            this.grdctrlBankaHareket = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaBakiye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaCikis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBankaHesapKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaGiris.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaIBANNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaHesapAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdctrlBankaHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBaseClose
            // 
            this.btnBaseClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBaseClose.FlatAppearance.BorderSize = 0;
            this.btnBaseClose.Location = new System.Drawing.Point(-10, -10);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtBankaBakiye);
            this.groupControl1.Controls.Add(this.txtBankaCikis);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnBankaHesapKod);
            this.groupControl1.Controls.Add(this.txtBankaGiris);
            this.groupControl1.Controls.Add(this.txtBankaIBANNo);
            this.groupControl1.Controls.Add(this.txtBankaHesapAd);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(463, 121);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Hesap Hareketleri";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(203, 96);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(31, 13);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Bakiye";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(107, 96);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(21, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Çıkış";
            // 
            // txtBankaBakiye
            // 
            this.txtBankaBakiye.Enabled = false;
            this.txtBankaBakiye.Location = new System.Drawing.Point(240, 93);
            this.txtBankaBakiye.Name = "txtBankaBakiye";
            this.txtBankaBakiye.Size = new System.Drawing.Size(63, 20);
            this.txtBankaBakiye.TabIndex = 7;
            // 
            // txtBankaCikis
            // 
            this.txtBankaCikis.Enabled = false;
            this.txtBankaCikis.Location = new System.Drawing.Point(134, 93);
            this.txtBankaCikis.Name = "txtBankaCikis";
            this.txtBankaCikis.Size = new System.Drawing.Size(63, 20);
            this.txtBankaCikis.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 96);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(20, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Giriş";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "IBAN No";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Hesap Kod";
            // 
            // btnBankaHesapKod
            // 
            this.btnBankaHesapKod.Location = new System.Drawing.Point(69, 33);
            this.btnBankaHesapKod.Name = "btnBankaHesapKod";
            this.btnBankaHesapKod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnBankaHesapKod.Size = new System.Drawing.Size(111, 20);
            this.btnBankaHesapKod.TabIndex = 4;
            this.btnBankaHesapKod.Tag = "Banka.frmListe";
            this.btnBankaHesapKod.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnBankaHesapKod_ButtonClick);
            // 
            // txtBankaGiris
            // 
            this.txtBankaGiris.Enabled = false;
            this.txtBankaGiris.Location = new System.Drawing.Point(38, 93);
            this.txtBankaGiris.Name = "txtBankaGiris";
            this.txtBankaGiris.Size = new System.Drawing.Size(63, 20);
            this.txtBankaGiris.TabIndex = 5;
            // 
            // txtBankaIBANNo
            // 
            this.txtBankaIBANNo.Enabled = false;
            this.txtBankaIBANNo.Location = new System.Drawing.Point(69, 62);
            this.txtBankaIBANNo.Name = "txtBankaIBANNo";
            this.txtBankaIBANNo.Size = new System.Drawing.Size(234, 20);
            this.txtBankaIBANNo.TabIndex = 5;
            // 
            // txtBankaHesapAd
            // 
            this.txtBankaHesapAd.Enabled = false;
            this.txtBankaHesapAd.Location = new System.Drawing.Point(186, 33);
            this.txtBankaHesapAd.Name = "txtBankaHesapAd";
            this.txtBankaHesapAd.Size = new System.Drawing.Size(117, 20);
            this.txtBankaHesapAd.TabIndex = 5;
            // 
            // grdctrlBankaHareket
            // 
            this.grdctrlBankaHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdctrlBankaHareket.Location = new System.Drawing.Point(0, 121);
            this.grdctrlBankaHareket.MainView = this.gridView1;
            this.grdctrlBankaHareket.Name = "grdctrlBankaHareket";
            this.grdctrlBankaHareket.Size = new System.Drawing.Size(463, 255);
            this.grdctrlBankaHareket.TabIndex = 1;
            this.grdctrlBankaHareket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdctrlBankaHareket;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // FrmHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 376);
            this.Controls.Add(this.grdctrlBankaHareket);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = global::WinFormsUI.Properties.Resources.Banka_Hareket16x16;
            this.IconOptions.ShowIcon = false;
            this.Name = "FrmHareket";
            this.Text = "Banka Hesap Hareketleri";
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.grdctrlBankaHareket, 0);
            this.Controls.SetChildIndex(this.btnBaseClose, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaBakiye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaCikis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBankaHesapKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaGiris.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaIBANNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaHesapAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdctrlBankaHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

    }
}