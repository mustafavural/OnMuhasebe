
namespace WinFormsUI.View.Moduller.Cek
{
    partial class FrmBankaya
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
            this.grdCekListesi = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtHesapBakiye = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnHesapKod = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridButtons1 = new WinFormsUI.View.UserControls.gridButtons();
            this.btnCekKodu = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCekCiroEden = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCekBankasi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtCekTutari = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtCekVadesi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtCekAsilBorclu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtHesapAd = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridButtons2 = new WinFormsUI.View.UserControls.gridButtons();
            this.chkCekBasim = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.txtCekGenelToplam = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCekListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapBakiye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHesapKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCekKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekCiroEden.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekBankasi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekTutari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekVadesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekAsilBorclu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkCekBasim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekGenelToplam.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCekListesi
            // 
            this.grdCekListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCekListesi.Location = new System.Drawing.Point(0, 208);
            this.grdCekListesi.MainView = this.gridView1;
            this.grdCekListesi.Name = "grdCekListesi";
            this.grdCekListesi.Size = new System.Drawing.Size(924, 95);
            this.grdCekListesi.TabIndex = 7;
            this.grdCekListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdCekListesi;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtHesapBakiye);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.btnHesapKod);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.txtHesapAd);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(924, 208);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Banka Bilgileri";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(19, 55);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(31, 13);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Bakiye";
            // 
            // txtHesapBakiye
            // 
            this.txtHesapBakiye.Enabled = false;
            this.txtHesapBakiye.Location = new System.Drawing.Point(66, 52);
            this.txtHesapBakiye.Name = "txtHesapBakiye";
            this.txtHesapBakiye.Size = new System.Drawing.Size(127, 20);
            this.txtHesapBakiye.TabIndex = 14;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(181, 29);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Hesap İsim";
            // 
            // btnHesapKod
            // 
            this.btnHesapKod.Location = new System.Drawing.Point(66, 26);
            this.btnHesapKod.Name = "btnHesapKod";
            this.btnHesapKod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnHesapKod.Size = new System.Drawing.Size(109, 20);
            this.btnHesapKod.TabIndex = 3;
            this.btnHesapKod.Tag = "Banka.frmListe";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 29);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Hesap Kod";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gridButtons1);
            this.groupControl3.Controls.Add(this.btnCekKodu);
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Controls.Add(this.txtCekCiroEden);
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Controls.Add(this.txtCekBankasi);
            this.groupControl3.Controls.Add(this.labelControl10);
            this.groupControl3.Controls.Add(this.txtCekTutari);
            this.groupControl3.Controls.Add(this.labelControl9);
            this.groupControl3.Controls.Add(this.txtCekVadesi);
            this.groupControl3.Controls.Add(this.labelControl8);
            this.groupControl3.Controls.Add(this.txtCekAsilBorclu);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(2, 76);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(920, 130);
            this.groupControl3.TabIndex = 11;
            this.groupControl3.Text = "Çek Bilgileri";
            // 
            // gridButtons1
            // 
            this.gridButtons1.btnTemizleVisible = true;
            this.gridButtons1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridButtons1.Location = new System.Drawing.Point(2, 91);
            this.gridButtons1.Name = "gridButtons1";
            this.gridButtons1.Size = new System.Drawing.Size(916, 37);
            this.gridButtons1.TabIndex = 20;
            // 
            // btnCekKodu
            // 
            this.btnCekKodu.Location = new System.Drawing.Point(64, 40);
            this.btnCekKodu.Name = "btnCekKodu";
            this.btnCekKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnCekKodu.Size = new System.Drawing.Size(109, 20);
            this.btnCekKodu.TabIndex = 19;
            this.btnCekKodu.Tag = "Cek.frmListe";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(185, 69);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 13);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Ciro Eden Cari";
            // 
            // txtCekCiroEden
            // 
            this.txtCekCiroEden.Location = new System.Drawing.Point(259, 66);
            this.txtCekCiroEden.Name = "txtCekCiroEden";
            this.txtCekCiroEden.Size = new System.Drawing.Size(308, 20);
            this.txtCekCiroEden.TabIndex = 18;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(10, 69);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 13);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Bankası";
            // 
            // txtCekBankasi
            // 
            this.txtCekBankasi.Location = new System.Drawing.Point(64, 66);
            this.txtCekBankasi.Name = "txtCekBankasi";
            this.txtCekBankasi.Size = new System.Drawing.Size(109, 20);
            this.txtCekBankasi.TabIndex = 16;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(325, 43);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(28, 13);
            this.labelControl10.TabIndex = 10;
            this.labelControl10.Text = "Tutarı";
            // 
            // txtCekTutari
            // 
            this.txtCekTutari.Location = new System.Drawing.Point(359, 40);
            this.txtCekTutari.Name = "txtCekTutari";
            this.txtCekTutari.Size = new System.Drawing.Size(100, 20);
            this.txtCekTutari.TabIndex = 11;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(179, 43);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(31, 13);
            this.labelControl9.TabIndex = 8;
            this.labelControl9.Text = "Vadesi";
            // 
            // txtCekVadesi
            // 
            this.txtCekVadesi.Location = new System.Drawing.Point(219, 40);
            this.txtCekVadesi.Name = "txtCekVadesi";
            this.txtCekVadesi.Size = new System.Drawing.Size(100, 20);
            this.txtCekVadesi.TabIndex = 9;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(467, 43);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 13);
            this.labelControl8.TabIndex = 4;
            this.labelControl8.Text = "Asıl Borçlu";
            // 
            // txtCekAsilBorclu
            // 
            this.txtCekAsilBorclu.Location = new System.Drawing.Point(521, 40);
            this.txtCekAsilBorclu.Name = "txtCekAsilBorclu";
            this.txtCekAsilBorclu.Size = new System.Drawing.Size(222, 20);
            this.txtCekAsilBorclu.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(10, 43);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(45, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Çek Kodu";
            // 
            // txtHesapAd
            // 
            this.txtHesapAd.Enabled = false;
            this.txtHesapAd.Location = new System.Drawing.Point(239, 26);
            this.txtHesapAd.Name = "txtHesapAd";
            this.txtHesapAd.Size = new System.Drawing.Size(394, 20);
            this.txtHesapAd.TabIndex = 5;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridButtons2);
            this.groupControl2.Controls.Add(this.chkCekBasim);
            this.groupControl2.Controls.Add(this.labelControl17);
            this.groupControl2.Controls.Add(this.txtCekGenelToplam);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 303);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(924, 62);
            this.groupControl2.TabIndex = 8;
            this.groupControl2.Text = "Alt Bilgiler";
            // 
            // gridButtons2
            // 
            this.gridButtons2.btnTemizleVisible = true;
            this.gridButtons2.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridButtons2.Location = new System.Drawing.Point(680, 23);
            this.gridButtons2.Name = "gridButtons2";
            this.gridButtons2.Size = new System.Drawing.Size(242, 37);
            this.gridButtons2.TabIndex = 21;
            // 
            // chkCekBasim
            // 
            this.chkCekBasim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCekBasim.EditValue = true;
            this.chkCekBasim.Location = new System.Drawing.Point(616, 30);
            this.chkCekBasim.Name = "chkCekBasim";
            this.chkCekBasim.Properties.Caption = "Basım";
            this.chkCekBasim.Size = new System.Drawing.Size(57, 20);
            this.chkCekBasim.TabIndex = 12;
            // 
            // labelControl17
            // 
            this.labelControl17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl17.Location = new System.Drawing.Point(440, 33);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(64, 13);
            this.labelControl17.TabIndex = 10;
            this.labelControl17.Text = "Genel Toplam";
            // 
            // txtCekGenelToplam
            // 
            this.txtCekGenelToplam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCekGenelToplam.Enabled = false;
            this.txtCekGenelToplam.Location = new System.Drawing.Point(510, 30);
            this.txtCekGenelToplam.Name = "txtCekGenelToplam";
            this.txtCekGenelToplam.Size = new System.Drawing.Size(100, 20);
            this.txtCekGenelToplam.TabIndex = 11;
            // 
            // frmBankaya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 365);
            this.Controls.Add(this.grdCekListesi);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.IconOptions.Image = global::WinFormsUI.Properties.Resources.Cek_Bankaya16x16;
            this.Name = "frmBankaya";
            this.Text = "Bankaya Çek Ciro Et";
            ((System.ComponentModel.ISupportInitialize)(this.grdCekListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapBakiye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHesapKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCekKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekCiroEden.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekBankasi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekTutari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekVadesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekAsilBorclu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkCekBasim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekGenelToplam.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdCekListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtHesapBakiye;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ButtonEdit btnHesapKod;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.ButtonEdit btnCekKodu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCekCiroEden;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtCekBankasi;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtCekTutari;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtCekVadesi;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtCekAsilBorclu;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtHesapAd;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.CheckEdit chkCekBasim;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.TextEdit txtCekGenelToplam;
        private UserControls.gridButtons gridButtons1;
        private UserControls.gridButtons gridButtons2;
    }
}