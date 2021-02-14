
namespace WinFormsUI.View.Moduller.Banka
{
    partial class FrmHesap
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
            this.grdctrlBankaHesap = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridButtons1 = new WinFormsUI.View.UserControls.gridButtons();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtBankaYetkiliEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtBankaYetkiliAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtHesapAd = new DevExpress.XtraEditors.TextEdit();
            this.txtBankaIBANno = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtBankaHesapNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnBankaHesapKod = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtBankaSubeTel = new DevExpress.XtraEditors.TextEdit();
            this.txtBankaSube = new DevExpress.XtraEditors.TextEdit();
            this.memoBankaSubeAdres = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grdctrlBankaHesap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaYetkiliEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaYetkiliAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaIBANno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaHesapNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBankaHesapKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaSubeTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaSube.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoBankaSubeAdres.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnBaseClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBaseClose.FlatAppearance.BorderSize = 0;
            // 
            // grdctrlBankaHesap
            // 
            this.grdctrlBankaHesap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdctrlBankaHesap.Location = new System.Drawing.Point(0, 274);
            this.grdctrlBankaHesap.MainView = this.gridView1;
            this.grdctrlBankaHesap.Name = "grdctrlBankaHesap";
            this.grdctrlBankaHesap.Size = new System.Drawing.Size(370, 256);
            this.grdctrlBankaHesap.TabIndex = 0;
            this.grdctrlBankaHesap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdctrlBankaHesap;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridButtons1);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtBankaYetkiliEmail);
            this.groupControl1.Controls.Add(this.txtBankaYetkiliAd);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtHesapAd);
            this.groupControl1.Controls.Add(this.txtBankaIBANno);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtBankaHesapNo);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.btnBankaHesapKod);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtBankaSubeTel);
            this.groupControl1.Controls.Add(this.txtBankaSube);
            this.groupControl1.Controls.Add(this.memoBankaSubeAdres);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(370, 274);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Banka Hesapları";
            // 
            // gridButtons1
            // 
            this.gridButtons1.btnTemizleVisible = true;
            this.gridButtons1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridButtons1.Location = new System.Drawing.Point(2, 235);
            this.gridButtons1.Name = "gridButtons1";
            this.gridButtons1.Size = new System.Drawing.Size(366, 37);
            this.gridButtons1.TabIndex = 20;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(181, 212);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 13);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "Yetkili Email";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(11, 212);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(45, 13);
            this.labelControl8.TabIndex = 18;
            this.labelControl8.Text = "Yetkili Adı";
            // 
            // txtBankaYetkiliEmail
            // 
            this.txtBankaYetkiliEmail.Location = new System.Drawing.Point(241, 209);
            this.txtBankaYetkiliEmail.Name = "txtBankaYetkiliEmail";
            this.txtBankaYetkiliEmail.Size = new System.Drawing.Size(110, 20);
            this.txtBankaYetkiliEmail.TabIndex = 16;
            // 
            // txtBankaYetkiliAd
            // 
            this.txtBankaYetkiliAd.Location = new System.Drawing.Point(74, 209);
            this.txtBankaYetkiliAd.Name = "txtBankaYetkiliAd";
            this.txtBankaYetkiliAd.Size = new System.Drawing.Size(100, 20);
            this.txtBankaYetkiliAd.TabIndex = 17;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 139);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 13);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "Şube Adres";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(182, 113);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(63, 13);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Şube Telefon";
            // 
            // txtHesapAd
            // 
            this.txtHesapAd.Enabled = false;
            this.txtHesapAd.Location = new System.Drawing.Point(181, 32);
            this.txtHesapAd.Name = "txtHesapAd";
            this.txtHesapAd.Size = new System.Drawing.Size(171, 20);
            this.txtHesapAd.TabIndex = 12;
            // 
            // txtBankaIBANno
            // 
            this.txtBankaIBANno.Location = new System.Drawing.Point(75, 84);
            this.txtBankaIBANno.Name = "txtBankaIBANno";
            this.txtBankaIBANno.Size = new System.Drawing.Size(277, 20);
            this.txtBankaIBANno.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 87);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(40, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "IBAN No";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 113);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(42, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Şube Adı";
            // 
            // txtBankaHesapNo
            // 
            this.txtBankaHesapNo.Location = new System.Drawing.Point(75, 58);
            this.txtBankaHesapNo.Name = "txtBankaHesapNo";
            this.txtBankaHesapNo.Size = new System.Drawing.Size(100, 20);
            this.txtBankaHesapNo.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 61);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Hesap No";
            // 
            // btnBankaHesapKod
            // 
            this.btnBankaHesapKod.Location = new System.Drawing.Point(75, 32);
            this.btnBankaHesapKod.Name = "btnBankaHesapKod";
            this.btnBankaHesapKod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnBankaHesapKod.Size = new System.Drawing.Size(100, 20);
            this.btnBankaHesapKod.TabIndex = 1;
            this.btnBankaHesapKod.Tag = "Banka.frmListe";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Hesap Kodu";
            // 
            // txtBankaSubeTel
            // 
            this.txtBankaSubeTel.Location = new System.Drawing.Point(252, 110);
            this.txtBankaSubeTel.Name = "txtBankaSubeTel";
            this.txtBankaSubeTel.Size = new System.Drawing.Size(100, 20);
            this.txtBankaSubeTel.TabIndex = 9;
            // 
            // txtBankaSube
            // 
            this.txtBankaSube.Location = new System.Drawing.Point(75, 110);
            this.txtBankaSube.Name = "txtBankaSube";
            this.txtBankaSube.Size = new System.Drawing.Size(100, 20);
            this.txtBankaSube.TabIndex = 9;
            // 
            // memoBankaSubeAdres
            // 
            this.memoBankaSubeAdres.Location = new System.Drawing.Point(75, 136);
            this.memoBankaSubeAdres.Name = "memoBankaSubeAdres";
            this.memoBankaSubeAdres.Size = new System.Drawing.Size(277, 70);
            this.memoBankaSubeAdres.TabIndex = 14;
            // 
            // frmHesap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 530);
            this.Controls.Add(this.grdctrlBankaHesap);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = global::WinFormsUI.Properties.Resources.Banka_Kartı16x16;
            this.Name = "frmHesap";
            this.Text = "Banka Hesapları";
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.grdctrlBankaHesap, 0);
            this.Controls.SetChildIndex(this.btnBaseClose, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grdctrlBankaHesap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaYetkiliEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaYetkiliAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaIBANno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaHesapNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBankaHesapKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaSubeTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaSube.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoBankaSubeAdres.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdctrlBankaHesap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtBankaYetkiliEmail;
        private DevExpress.XtraEditors.TextEdit txtBankaYetkiliAd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtHesapAd;
        private DevExpress.XtraEditors.TextEdit txtBankaIBANno;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtBankaHesapNo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ButtonEdit btnBankaHesapKod;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtBankaSubeTel;
        private DevExpress.XtraEditors.TextEdit txtBankaSube;
        private DevExpress.XtraEditors.MemoEdit memoBankaSubeAdres;
        private UserControls.gridButtons gridButtons1;
    }
}