
namespace WinFormsUI.View.Moduller.Senet
{
    partial class FrmMusteri
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
            this.txtSenetBakiye = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnCariKod = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridButtons2 = new WinFormsUI.View.UserControls.gridButtons();
            this.btnSenetKodu = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSenetCiroEden = new DevExpress.XtraEditors.TextEdit();
            this.grbSenetIslemTuru = new System.Windows.Forms.GroupBox();
            this.rdbSenetAlis = new System.Windows.Forms.RadioButton();
            this.rdbSenetCikis = new System.Windows.Forms.RadioButton();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtSenetTutari = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtSenetVadesi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtSenetAsilBorclu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtSenetCariAd = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridButtons1 = new WinFormsUI.View.UserControls.gridButtons();
            this.chkSenetBasim = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.txtSenetGenelToplam = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSenetListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetBakiye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCariKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSenetKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetCiroEden.Properties)).BeginInit();
            this.grbSenetIslemTuru.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetTutari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetVadesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetAsilBorclu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetCariAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkSenetBasim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetGenelToplam.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnBaseClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBaseClose.FlatAppearance.BorderSize = 0;
            // 
            // grdSenetListesi
            // 
            this.grdSenetListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSenetListesi.Location = new System.Drawing.Point(0, 208);
            this.grdSenetListesi.MainView = this.gridView1;
            this.grdSenetListesi.Name = "grdSenetListesi";
            this.grdSenetListesi.Size = new System.Drawing.Size(911, 228);
            this.grdSenetListesi.TabIndex = 7;
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
            this.groupControl1.Controls.Add(this.txtSenetBakiye);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.btnCariKod);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.txtSenetCariAd);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(911, 208);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Cari Bilgileri";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(19, 55);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(31, 13);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Bakiye";
            // 
            // txtSenetBakiye
            // 
            this.txtSenetBakiye.Enabled = false;
            this.txtSenetBakiye.Location = new System.Drawing.Point(66, 52);
            this.txtSenetBakiye.Name = "txtSenetBakiye";
            this.txtSenetBakiye.Size = new System.Drawing.Size(127, 20);
            this.txtSenetBakiye.TabIndex = 14;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(181, 29);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Cari İsim";
            // 
            // btnCariKod
            // 
            this.btnCariKod.Location = new System.Drawing.Point(66, 26);
            this.btnCariKod.Name = "btnCariKod";
            this.btnCariKod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnCariKod.Size = new System.Drawing.Size(109, 20);
            this.btnCariKod.TabIndex = 3;
            this.btnCariKod.Tag = "Cari.frmListe";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 29);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Cari Kod";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gridButtons2);
            this.groupControl3.Controls.Add(this.btnSenetKodu);
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Controls.Add(this.txtSenetCiroEden);
            this.groupControl3.Controls.Add(this.grbSenetIslemTuru);
            this.groupControl3.Controls.Add(this.labelControl10);
            this.groupControl3.Controls.Add(this.txtSenetTutari);
            this.groupControl3.Controls.Add(this.labelControl9);
            this.groupControl3.Controls.Add(this.txtSenetVadesi);
            this.groupControl3.Controls.Add(this.labelControl8);
            this.groupControl3.Controls.Add(this.txtSenetAsilBorclu);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(2, 76);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(907, 130);
            this.groupControl3.TabIndex = 11;
            this.groupControl3.Text = "Senet Bilgileri";
            // 
            // gridButtons2
            // 
            this.gridButtons2.btnTemizleVisible = true;
            this.gridButtons2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridButtons2.Location = new System.Drawing.Point(2, 92);
            this.gridButtons2.Name = "gridButtons2";
            this.gridButtons2.Size = new System.Drawing.Size(903, 36);
            this.gridButtons2.TabIndex = 20;
            // 
            // btnSenetKodu
            // 
            this.btnSenetKodu.Location = new System.Drawing.Point(168, 43);
            this.btnSenetKodu.Name = "btnSenetKodu";
            this.btnSenetKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnSenetKodu.Size = new System.Drawing.Size(102, 20);
            this.btnSenetKodu.TabIndex = 19;
            this.btnSenetKodu.Tag = "Senet.frmListe";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(107, 71);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 13);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Ciro Eden Cari";
            // 
            // txtSenetCiroEden
            // 
            this.txtSenetCiroEden.Location = new System.Drawing.Point(181, 68);
            this.txtSenetCiroEden.Name = "txtSenetCiroEden";
            this.txtSenetCiroEden.Size = new System.Drawing.Size(308, 20);
            this.txtSenetCiroEden.TabIndex = 18;
            // 
            // grbSenetIslemTuru
            // 
            this.grbSenetIslemTuru.Controls.Add(this.rdbSenetAlis);
            this.grbSenetIslemTuru.Controls.Add(this.rdbSenetCikis);
            this.grbSenetIslemTuru.Location = new System.Drawing.Point(10, 26);
            this.grbSenetIslemTuru.Name = "grbSenetIslemTuru";
            this.grbSenetIslemTuru.Size = new System.Drawing.Size(91, 65);
            this.grbSenetIslemTuru.TabIndex = 12;
            this.grbSenetIslemTuru.TabStop = false;
            this.grbSenetIslemTuru.Text = "İşlem Türü";
            // 
            // rdbSenetAlis
            // 
            this.rdbSenetAlis.AutoSize = true;
            this.rdbSenetAlis.Checked = true;
            this.rdbSenetAlis.Location = new System.Drawing.Point(6, 20);
            this.rdbSenetAlis.Name = "rdbSenetAlis";
            this.rdbSenetAlis.Size = new System.Drawing.Size(76, 17);
            this.rdbSenetAlis.TabIndex = 1;
            this.rdbSenetAlis.TabStop = true;
            this.rdbSenetAlis.Text = "Senet Giriş";
            this.rdbSenetAlis.UseVisualStyleBackColor = true;
            // 
            // rdbSenetCikis
            // 
            this.rdbSenetCikis.AutoSize = true;
            this.rdbSenetCikis.Location = new System.Drawing.Point(5, 43);
            this.rdbSenetCikis.Name = "rdbSenetCikis";
            this.rdbSenetCikis.Size = new System.Drawing.Size(77, 17);
            this.rdbSenetCikis.TabIndex = 0;
            this.rdbSenetCikis.Text = "Senet Çıkış";
            this.rdbSenetCikis.UseVisualStyleBackColor = true;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(422, 46);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(28, 13);
            this.labelControl10.TabIndex = 10;
            this.labelControl10.Text = "Tutarı";
            // 
            // txtSenetTutari
            // 
            this.txtSenetTutari.Location = new System.Drawing.Point(456, 43);
            this.txtSenetTutari.Name = "txtSenetTutari";
            this.txtSenetTutari.Size = new System.Drawing.Size(100, 20);
            this.txtSenetTutari.TabIndex = 11;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(276, 46);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(31, 13);
            this.labelControl9.TabIndex = 8;
            this.labelControl9.Text = "Vadesi";
            // 
            // txtSenetVadesi
            // 
            this.txtSenetVadesi.Location = new System.Drawing.Point(316, 43);
            this.txtSenetVadesi.Name = "txtSenetVadesi";
            this.txtSenetVadesi.Size = new System.Drawing.Size(100, 20);
            this.txtSenetVadesi.TabIndex = 9;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(564, 46);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 13);
            this.labelControl8.TabIndex = 4;
            this.labelControl8.Text = "Asıl Borçlu";
            // 
            // txtSenetAsilBorclu
            // 
            this.txtSenetAsilBorclu.Location = new System.Drawing.Point(618, 43);
            this.txtSenetAsilBorclu.Name = "txtSenetAsilBorclu";
            this.txtSenetAsilBorclu.Size = new System.Drawing.Size(279, 20);
            this.txtSenetAsilBorclu.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(107, 46);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(55, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Senet Kodu";
            // 
            // txtSenetCariAd
            // 
            this.txtSenetCariAd.Enabled = false;
            this.txtSenetCariAd.Location = new System.Drawing.Point(228, 26);
            this.txtSenetCariAd.Name = "txtSenetCariAd";
            this.txtSenetCariAd.Size = new System.Drawing.Size(394, 20);
            this.txtSenetCariAd.TabIndex = 5;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridButtons1);
            this.groupControl2.Controls.Add(this.chkSenetBasim);
            this.groupControl2.Controls.Add(this.labelControl17);
            this.groupControl2.Controls.Add(this.txtSenetGenelToplam);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 371);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(911, 65);
            this.groupControl2.TabIndex = 8;
            this.groupControl2.Text = "Toplam Bilgiler";
            // 
            // gridButtons1
            // 
            this.gridButtons1.btnTemizleVisible = true;
            this.gridButtons1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridButtons1.Location = new System.Drawing.Point(667, 23);
            this.gridButtons1.Name = "gridButtons1";
            this.gridButtons1.Size = new System.Drawing.Size(242, 40);
            this.gridButtons1.TabIndex = 18;
            // 
            // chkSenetBasim
            // 
            this.chkSenetBasim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSenetBasim.EditValue = true;
            this.chkSenetBasim.Location = new System.Drawing.Point(604, 33);
            this.chkSenetBasim.Name = "chkSenetBasim";
            this.chkSenetBasim.Properties.Caption = "Basım";
            this.chkSenetBasim.Size = new System.Drawing.Size(57, 20);
            this.chkSenetBasim.TabIndex = 1;
            // 
            // labelControl17
            // 
            this.labelControl17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl17.Location = new System.Drawing.Point(428, 36);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(64, 13);
            this.labelControl17.TabIndex = 16;
            this.labelControl17.Text = "Genel Toplam";
            // 
            // txtSenetGenelToplam
            // 
            this.txtSenetGenelToplam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenetGenelToplam.Enabled = false;
            this.txtSenetGenelToplam.Location = new System.Drawing.Point(498, 33);
            this.txtSenetGenelToplam.Name = "txtSenetGenelToplam";
            this.txtSenetGenelToplam.Size = new System.Drawing.Size(100, 20);
            this.txtSenetGenelToplam.TabIndex = 0;
            // 
            // frmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 436);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.grdSenetListesi);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = global::WinFormsUI.Properties.Resources.Senet_MusteriLst16x16;
            this.Name = "frmMusteri";
            this.Text = "Müşteri Senedi İşlemleri";
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.grdSenetListesi, 0);
            this.Controls.SetChildIndex(this.btnBaseClose, 0);
            this.Controls.SetChildIndex(this.groupControl2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grdSenetListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetBakiye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCariKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSenetKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetCiroEden.Properties)).EndInit();
            this.grbSenetIslemTuru.ResumeLayout(false);
            this.grbSenetIslemTuru.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetTutari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetVadesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetAsilBorclu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetCariAd.Properties)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtSenetBakiye;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ButtonEdit btnCariKod;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.ButtonEdit btnSenetKodu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSenetCiroEden;
        private System.Windows.Forms.GroupBox grbSenetIslemTuru;
        private System.Windows.Forms.RadioButton rdbSenetAlis;
        private System.Windows.Forms.RadioButton rdbSenetCikis;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtSenetTutari;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtSenetVadesi;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtSenetAsilBorclu;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtSenetCariAd;
        private UserControls.gridButtons gridButtons2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private UserControls.gridButtons gridButtons1;
        private DevExpress.XtraEditors.CheckEdit chkSenetBasim;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.TextEdit txtSenetGenelToplam;
    }
}