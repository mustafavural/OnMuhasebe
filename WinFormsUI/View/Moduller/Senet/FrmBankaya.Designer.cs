
namespace WinFormsUI.View.Moduller.Senet
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
            this.grdSenetListesi = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtHesapBakiye = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnHesapKod = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtHesapAd = new DevExpress.XtraEditors.TextEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridButtons2 = new WinFormsUI.View.UserControls.gridButtons();
            this.btnSenetKodu = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSenetCiroEden = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtSenetTutari = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtSenetVadesi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtSenetAsilBorclu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridButtons1 = new WinFormsUI.View.UserControls.gridButtons();
            this.chkSenetBasim = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.txtSenetGenelToplam = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSenetListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapBakiye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHesapKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSenetKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetCiroEden.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetTutari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetVadesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetAsilBorclu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkSenetBasim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetGenelToplam.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSenetListesi
            // 
            this.grdSenetListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSenetListesi.Location = new System.Drawing.Point(0, 205);
            this.grdSenetListesi.MainView = this.gridView1;
            this.grdSenetListesi.Name = "grdSenetListesi";
            this.grdSenetListesi.Size = new System.Drawing.Size(917, 122);
            this.grdSenetListesi.TabIndex = 10;
            this.grdSenetListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdSenetListesi;
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
            this.groupControl1.Controls.Add(this.txtHesapAd);
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(917, 205);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "Banka Bilgileri";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(21, 55);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(31, 13);
            this.labelControl5.TabIndex = 19;
            this.labelControl5.Text = "Bakiye";
            // 
            // txtHesapBakiye
            // 
            this.txtHesapBakiye.Enabled = false;
            this.txtHesapBakiye.Location = new System.Drawing.Point(68, 52);
            this.txtHesapBakiye.Name = "txtHesapBakiye";
            this.txtHesapBakiye.Size = new System.Drawing.Size(127, 20);
            this.txtHesapBakiye.TabIndex = 20;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(183, 29);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 13);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "Hesap İsim";
            // 
            // btnHesapKod
            // 
            this.btnHesapKod.Location = new System.Drawing.Point(68, 26);
            this.btnHesapKod.Name = "btnHesapKod";
            this.btnHesapKod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnHesapKod.Size = new System.Drawing.Size(109, 20);
            this.btnHesapKod.TabIndex = 16;
            this.btnHesapKod.Tag = "Banka.frmListe";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 29);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 13);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "Hesap Kod";
            // 
            // txtHesapAd
            // 
            this.txtHesapAd.Enabled = false;
            this.txtHesapAd.Location = new System.Drawing.Point(241, 26);
            this.txtHesapAd.Name = "txtHesapAd";
            this.txtHesapAd.Size = new System.Drawing.Size(394, 20);
            this.txtHesapAd.TabIndex = 18;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gridButtons2);
            this.groupControl3.Controls.Add(this.btnSenetKodu);
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Controls.Add(this.txtSenetCiroEden);
            this.groupControl3.Controls.Add(this.labelControl10);
            this.groupControl3.Controls.Add(this.txtSenetTutari);
            this.groupControl3.Controls.Add(this.labelControl9);
            this.groupControl3.Controls.Add(this.txtSenetVadesi);
            this.groupControl3.Controls.Add(this.labelControl8);
            this.groupControl3.Controls.Add(this.txtSenetAsilBorclu);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(2, 78);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(913, 125);
            this.groupControl3.TabIndex = 11;
            this.groupControl3.Text = "Senet Bilgileri";
            // 
            // gridButtons2
            // 
            this.gridButtons2.btnTemizleVisible = true;
            this.gridButtons2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridButtons2.Location = new System.Drawing.Point(2, 87);
            this.gridButtons2.Name = "gridButtons2";
            this.gridButtons2.Size = new System.Drawing.Size(909, 36);
            this.gridButtons2.TabIndex = 20;
            // 
            // btnSenetKodu
            // 
            this.btnSenetKodu.Location = new System.Drawing.Point(73, 35);
            this.btnSenetKodu.Name = "btnSenetKodu";
            this.btnSenetKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnSenetKodu.Size = new System.Drawing.Size(102, 20);
            this.btnSenetKodu.TabIndex = 19;
            this.btnSenetKodu.Tag = "Senet.frmListe";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 13);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Ciro Eden Cari";
            // 
            // txtSenetCiroEden
            // 
            this.txtSenetCiroEden.Location = new System.Drawing.Point(86, 60);
            this.txtSenetCiroEden.Name = "txtSenetCiroEden";
            this.txtSenetCiroEden.Size = new System.Drawing.Size(308, 20);
            this.txtSenetCiroEden.TabIndex = 18;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(327, 38);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(28, 13);
            this.labelControl10.TabIndex = 10;
            this.labelControl10.Text = "Tutarı";
            // 
            // txtSenetTutari
            // 
            this.txtSenetTutari.Location = new System.Drawing.Point(361, 35);
            this.txtSenetTutari.Name = "txtSenetTutari";
            this.txtSenetTutari.Size = new System.Drawing.Size(100, 20);
            this.txtSenetTutari.TabIndex = 11;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(181, 38);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(31, 13);
            this.labelControl9.TabIndex = 8;
            this.labelControl9.Text = "Vadesi";
            // 
            // txtSenetVadesi
            // 
            this.txtSenetVadesi.Location = new System.Drawing.Point(221, 35);
            this.txtSenetVadesi.Name = "txtSenetVadesi";
            this.txtSenetVadesi.Size = new System.Drawing.Size(100, 20);
            this.txtSenetVadesi.TabIndex = 9;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(469, 38);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 13);
            this.labelControl8.TabIndex = 4;
            this.labelControl8.Text = "Asıl Borçlu";
            // 
            // txtSenetAsilBorclu
            // 
            this.txtSenetAsilBorclu.Location = new System.Drawing.Point(523, 35);
            this.txtSenetAsilBorclu.Name = "txtSenetAsilBorclu";
            this.txtSenetAsilBorclu.Size = new System.Drawing.Size(279, 20);
            this.txtSenetAsilBorclu.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 38);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(55, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Senet Kodu";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridButtons1);
            this.groupControl2.Controls.Add(this.chkSenetBasim);
            this.groupControl2.Controls.Add(this.labelControl17);
            this.groupControl2.Controls.Add(this.txtSenetGenelToplam);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 327);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(917, 61);
            this.groupControl2.TabIndex = 11;
            this.groupControl2.Text = "Alt Bilgiler";
            // 
            // gridButtons1
            // 
            this.gridButtons1.btnTemizleVisible = true;
            this.gridButtons1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridButtons1.Location = new System.Drawing.Point(673, 23);
            this.gridButtons1.Name = "gridButtons1";
            this.gridButtons1.Size = new System.Drawing.Size(242, 36);
            this.gridButtons1.TabIndex = 13;
            // 
            // chkSenetBasim
            // 
            this.chkSenetBasim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSenetBasim.EditValue = true;
            this.chkSenetBasim.Location = new System.Drawing.Point(610, 29);
            this.chkSenetBasim.Name = "chkSenetBasim";
            this.chkSenetBasim.Properties.Caption = "Basım";
            this.chkSenetBasim.Size = new System.Drawing.Size(57, 20);
            this.chkSenetBasim.TabIndex = 12;
            // 
            // labelControl17
            // 
            this.labelControl17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl17.Location = new System.Drawing.Point(434, 32);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(64, 13);
            this.labelControl17.TabIndex = 10;
            this.labelControl17.Text = "Genel Toplam";
            // 
            // txtSenetGenelToplam
            // 
            this.txtSenetGenelToplam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenetGenelToplam.Enabled = false;
            this.txtSenetGenelToplam.Location = new System.Drawing.Point(504, 29);
            this.txtSenetGenelToplam.Name = "txtSenetGenelToplam";
            this.txtSenetGenelToplam.Size = new System.Drawing.Size(100, 20);
            this.txtSenetGenelToplam.TabIndex = 11;
            // 
            // frmBankaya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 388);
            this.Controls.Add(this.grdSenetListesi);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.IconOptions.Image = global::WinFormsUI.Properties.Resources.Senet_Bankaya16x16;
            this.Name = "frmBankaya";
            this.Text = "Bankaya Senet Ciro Et";
            ((System.ComponentModel.ISupportInitialize)(this.grdSenetListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapBakiye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHesapKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSenetKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetCiroEden.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetTutari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetVadesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetAsilBorclu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkSenetBasim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetGenelToplam.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdSenetListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.ButtonEdit btnSenetKodu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSenetCiroEden;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtSenetTutari;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtSenetVadesi;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtSenetAsilBorclu;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.CheckEdit chkSenetBasim;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.TextEdit txtSenetGenelToplam;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtHesapBakiye;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ButtonEdit btnHesapKod;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtHesapAd;
        private UserControls.gridButtons gridButtons2;
        private UserControls.gridButtons gridButtons1;
    }
}