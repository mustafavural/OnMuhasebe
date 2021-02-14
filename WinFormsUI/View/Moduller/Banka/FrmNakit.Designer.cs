
namespace WinFormsUI.View.Moduller.Banka
{
    partial class FrmNakit
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
            this.txtBakiye = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtBankaIBANno = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtHesapAd = new DevExpress.XtraEditors.TextEdit();
            this.btnBankaHesapKod = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridButtons1 = new WinFormsUI.View.UserControls.gridButtons();
            this.grpIslemTuru = new System.Windows.Forms.GroupBox();
            this.rdbParaCek = new System.Windows.Forms.RadioButton();
            this.rdbParaYatir = new System.Windows.Forms.RadioButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtTutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtBelgeNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.memoAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.dateTarih = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBakiye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaIBANno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBankaHesapKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.grpIslemTuru.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelgeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTarih.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnBaseClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBaseClose.FlatAppearance.BorderSize = 0;
            this.btnBaseClose.Location = new System.Drawing.Point(-10, 3);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtBakiye);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtBankaIBANno);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtHesapAd);
            this.groupControl1.Controls.Add(this.btnBankaHesapKod);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(424, 103);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Hesap Bilgileri";
            // 
            // txtBakiye
            // 
            this.txtBakiye.Enabled = false;
            this.txtBakiye.Location = new System.Drawing.Point(72, 78);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(100, 20);
            this.txtBakiye.TabIndex = 17;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(9, 81);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 13);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Bakiye";
            // 
            // txtBankaIBANno
            // 
            this.txtBankaIBANno.Location = new System.Drawing.Point(72, 52);
            this.txtBankaIBANno.Name = "txtBankaIBANno";
            this.txtBankaIBANno.Size = new System.Drawing.Size(343, 20);
            this.txtBankaIBANno.TabIndex = 15;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(9, 55);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(40, 13);
            this.labelControl6.TabIndex = 14;
            this.labelControl6.Text = "IBAN No";
            // 
            // txtHesapAd
            // 
            this.txtHesapAd.Enabled = false;
            this.txtHesapAd.Location = new System.Drawing.Point(178, 26);
            this.txtHesapAd.Name = "txtHesapAd";
            this.txtHesapAd.Size = new System.Drawing.Size(237, 20);
            this.txtHesapAd.TabIndex = 13;
            // 
            // btnBankaHesapKod
            // 
            this.btnBankaHesapKod.Location = new System.Drawing.Point(72, 26);
            this.btnBankaHesapKod.Name = "btnBankaHesapKod";
            this.btnBankaHesapKod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnBankaHesapKod.Size = new System.Drawing.Size(100, 20);
            this.btnBankaHesapKod.TabIndex = 3;
            this.btnBankaHesapKod.Tag = "Banka.frmListe";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Hesap Kodu";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridButtons1);
            this.groupControl2.Controls.Add(this.grpIslemTuru);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.txtTutar);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.txtBelgeNo);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.memoAciklama);
            this.groupControl2.Controls.Add(this.dateTarih);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 103);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(424, 222);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "İşlem Bilgileri";
            // 
            // gridButtons1
            // 
            this.gridButtons1.btnTemizleVisible = true;
            this.gridButtons1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridButtons1.Location = new System.Drawing.Point(2, 178);
            this.gridButtons1.Name = "gridButtons1";
            this.gridButtons1.Size = new System.Drawing.Size(420, 42);
            this.gridButtons1.TabIndex = 35;
            // 
            // grpIslemTuru
            // 
            this.grpIslemTuru.Controls.Add(this.rdbParaCek);
            this.grpIslemTuru.Controls.Add(this.rdbParaYatir);
            this.grpIslemTuru.Location = new System.Drawing.Point(259, 29);
            this.grpIslemTuru.Name = "grpIslemTuru";
            this.grpIslemTuru.Size = new System.Drawing.Size(153, 69);
            this.grpIslemTuru.TabIndex = 34;
            this.grpIslemTuru.TabStop = false;
            this.grpIslemTuru.Text = "İşlem Türü";
            // 
            // rdbParaCek
            // 
            this.rdbParaCek.AutoSize = true;
            this.rdbParaCek.Location = new System.Drawing.Point(34, 43);
            this.rdbParaCek.Name = "rdbParaCek";
            this.rdbParaCek.Size = new System.Drawing.Size(68, 17);
            this.rdbParaCek.TabIndex = 1;
            this.rdbParaCek.Text = "Para Çek";
            this.rdbParaCek.UseVisualStyleBackColor = true;
            // 
            // rdbParaYatir
            // 
            this.rdbParaYatir.AutoSize = true;
            this.rdbParaYatir.Checked = true;
            this.rdbParaYatir.Location = new System.Drawing.Point(34, 21);
            this.rdbParaYatir.Name = "rdbParaYatir";
            this.rdbParaYatir.Size = new System.Drawing.Size(72, 17);
            this.rdbParaYatir.TabIndex = 0;
            this.rdbParaYatir.TabStop = true;
            this.rdbParaYatir.Text = "Para Yatır";
            this.rdbParaYatir.UseVisualStyleBackColor = true;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(9, 107);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(41, 13);
            this.labelControl7.TabIndex = 32;
            this.labelControl7.Text = "Açıklama";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(72, 78);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(181, 20);
            this.txtTutar.TabIndex = 31;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(9, 81);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(26, 13);
            this.labelControl5.TabIndex = 30;
            this.labelControl5.Text = "Tutar";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(9, 55);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 13);
            this.labelControl4.TabIndex = 28;
            this.labelControl4.Text = "Tarih";
            // 
            // txtBelgeNo
            // 
            this.txtBelgeNo.Location = new System.Drawing.Point(72, 26);
            this.txtBelgeNo.Name = "txtBelgeNo";
            this.txtBelgeNo.Size = new System.Drawing.Size(181, 20);
            this.txtBelgeNo.TabIndex = 27;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(9, 29);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 13);
            this.labelControl3.TabIndex = 26;
            this.labelControl3.Text = "Belge No";
            // 
            // memoAciklama
            // 
            this.memoAciklama.Location = new System.Drawing.Point(72, 104);
            this.memoAciklama.Name = "memoAciklama";
            this.memoAciklama.Size = new System.Drawing.Size(340, 70);
            this.memoAciklama.TabIndex = 33;
            // 
            // dateTarih
            // 
            this.dateTarih.EditValue = null;
            this.dateTarih.Location = new System.Drawing.Point(72, 52);
            this.dateTarih.Name = "dateTarih";
            this.dateTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTarih.Properties.DisplayFormat.FormatString = "";
            this.dateTarih.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateTarih.Properties.EditFormat.FormatString = "";
            this.dateTarih.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateTarih.Properties.MaskSettings.Set("mask", "");
            this.dateTarih.Size = new System.Drawing.Size(181, 20);
            this.dateTarih.TabIndex = 29;
            // 
            // frmNakit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 325);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = global::WinFormsUI.Properties.Resources.Banka_Islem16x16;
            this.Name = "frmNakit";
            this.Text = "Para Yatır / Çek";
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.groupControl2, 0);
            this.Controls.SetChildIndex(this.btnBaseClose, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBakiye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaIBANno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBankaHesapKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.grpIslemTuru.ResumeLayout(false);
            this.grpIslemTuru.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelgeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTarih.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.ButtonEdit btnBankaHesapKod;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtHesapAd;
        private DevExpress.XtraEditors.TextEdit txtBakiye;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtBankaIBANno;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.GroupBox grpIslemTuru;
        private System.Windows.Forms.RadioButton rdbParaCek;
        private System.Windows.Forms.RadioButton rdbParaYatir;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtTutar;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtBelgeNo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit memoAciklama;
        private DevExpress.XtraEditors.DateEdit dateTarih;
        private UserControls.gridButtons gridButtons1;
    }
}