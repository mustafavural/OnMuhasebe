
namespace WinFormsUI.View.Moduller.Senet
{
    partial class FrmBorc
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
            this.grdCtrlSenetBorc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridButtons1 = new WinFormsUI.View.UserControls.gridButtons();
            this.chkSenetBasim = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.txtSenetGenelToplam = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtSenetCariBakiye = new DevExpress.XtraEditors.TextEdit();
            this.txtSenetCariAd = new DevExpress.XtraEditors.TextEdit();
            this.btnCariKod = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridButtons2 = new WinFormsUI.View.UserControls.gridButtons();
            this.txtSenetTutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtSenetVade = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnSenetKod = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbSenetBanka = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlSenetBorc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkSenetBasim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetGenelToplam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetCariBakiye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetCariAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCariKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetVade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSenetKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSenetBanka.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnBaseClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBaseClose.FlatAppearance.BorderSize = 0;
            // 
            // grdCtrlSenetBorc
            // 
            this.grdCtrlSenetBorc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCtrlSenetBorc.Location = new System.Drawing.Point(0, 136);
            this.grdCtrlSenetBorc.MainView = this.gridView1;
            this.grdCtrlSenetBorc.Name = "grdCtrlSenetBorc";
            this.grdCtrlSenetBorc.Size = new System.Drawing.Size(937, 268);
            this.grdCtrlSenetBorc.TabIndex = 4;
            this.grdCtrlSenetBorc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdCtrlSenetBorc;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gridButtons1);
            this.groupControl3.Controls.Add(this.chkSenetBasim);
            this.groupControl3.Controls.Add(this.labelControl17);
            this.groupControl3.Controls.Add(this.txtSenetGenelToplam);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(0, 404);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(937, 62);
            this.groupControl3.TabIndex = 5;
            this.groupControl3.Text = "Toplam Bilgiler";
            // 
            // gridButtons1
            // 
            this.gridButtons1.btnTemizleVisible = true;
            this.gridButtons1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridButtons1.Location = new System.Drawing.Point(693, 23);
            this.gridButtons1.Name = "gridButtons1";
            this.gridButtons1.Size = new System.Drawing.Size(242, 37);
            this.gridButtons1.TabIndex = 18;
            // 
            // chkSenetBasim
            // 
            this.chkSenetBasim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSenetBasim.EditValue = true;
            this.chkSenetBasim.Location = new System.Drawing.Point(630, 30);
            this.chkSenetBasim.Name = "chkSenetBasim";
            this.chkSenetBasim.Properties.Caption = "Basım";
            this.chkSenetBasim.Size = new System.Drawing.Size(57, 20);
            this.chkSenetBasim.TabIndex = 1;
            // 
            // labelControl17
            // 
            this.labelControl17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl17.Location = new System.Drawing.Point(454, 33);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(64, 13);
            this.labelControl17.TabIndex = 16;
            this.labelControl17.Text = "Genel Toplam";
            // 
            // txtSenetGenelToplam
            // 
            this.txtSenetGenelToplam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenetGenelToplam.Enabled = false;
            this.txtSenetGenelToplam.Location = new System.Drawing.Point(524, 30);
            this.txtSenetGenelToplam.Name = "txtSenetGenelToplam";
            this.txtSenetGenelToplam.Size = new System.Drawing.Size(100, 20);
            this.txtSenetGenelToplam.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtSenetCariBakiye);
            this.groupControl1.Controls.Add(this.txtSenetCariAd);
            this.groupControl1.Controls.Add(this.btnCariKod);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(937, 136);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Cari Bilgileri";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(195, 29);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(41, 13);
            this.labelControl7.TabIndex = 7;
            this.labelControl7.Text = "Cari İsim";
            // 
            // txtSenetCariBakiye
            // 
            this.txtSenetCariBakiye.Enabled = false;
            this.txtSenetCariBakiye.Location = new System.Drawing.Point(425, 26);
            this.txtSenetCariBakiye.Name = "txtSenetCariBakiye";
            this.txtSenetCariBakiye.Size = new System.Drawing.Size(132, 20);
            this.txtSenetCariBakiye.TabIndex = 2;
            // 
            // txtSenetCariAd
            // 
            this.txtSenetCariAd.Enabled = false;
            this.txtSenetCariAd.Location = new System.Drawing.Point(241, 26);
            this.txtSenetCariAd.Name = "txtSenetCariAd";
            this.txtSenetCariAd.Size = new System.Drawing.Size(132, 20);
            this.txtSenetCariAd.TabIndex = 1;
            // 
            // btnCariKod
            // 
            this.btnCariKod.Location = new System.Drawing.Point(57, 26);
            this.btnCariKod.Name = "btnCariKod";
            this.btnCariKod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnCariKod.Size = new System.Drawing.Size(132, 20);
            this.btnCariKod.TabIndex = 0;
            this.btnCariKod.Tag = "Cari.frmListe";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(379, 29);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Bakiye";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Cari Kod";
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl2.Controls.Add(this.gridButtons2);
            this.groupControl2.Controls.Add(this.txtSenetTutar);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.txtSenetVade);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.btnSenetKod);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.cmbSenetBanka);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(2, 54);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(933, 80);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Senet Bilgileri";
            // 
            // gridButtons2
            // 
            this.gridButtons2.btnTemizleVisible = true;
            this.gridButtons2.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridButtons2.Location = new System.Drawing.Point(690, 23);
            this.gridButtons2.Name = "gridButtons2";
            this.gridButtons2.Size = new System.Drawing.Size(241, 55);
            this.gridButtons2.TabIndex = 12;
            // 
            // txtSenetTutar
            // 
            this.txtSenetTutar.Location = new System.Drawing.Point(295, 52);
            this.txtSenetTutar.Name = "txtSenetTutar";
            this.txtSenetTutar.Size = new System.Drawing.Size(200, 20);
            this.txtSenetTutar.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(214, 55);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(67, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Senetin Tutarı";
            // 
            // txtSenetVade
            // 
            this.txtSenetVade.Location = new System.Drawing.Point(93, 52);
            this.txtSenetVade.Name = "txtSenetVade";
            this.txtSenetVade.Size = new System.Drawing.Size(115, 20);
            this.txtSenetVade.TabIndex = 2;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 55);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(70, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Senetin Vadesi";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(214, 29);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Senetin Bankası";
            // 
            // btnSenetKod
            // 
            this.btnSenetKod.Location = new System.Drawing.Point(93, 26);
            this.btnSenetKod.Name = "btnSenetKod";
            this.btnSenetKod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnSenetKod.Size = new System.Drawing.Size(115, 20);
            this.btnSenetKod.TabIndex = 0;
            this.btnSenetKod.Tag = "Senet.frmListe";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 29);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Senet Kodu";
            // 
            // cmbSenetBanka
            // 
            this.cmbSenetBanka.Location = new System.Drawing.Point(295, 26);
            this.cmbSenetBanka.Name = "cmbSenetBanka";
            this.cmbSenetBanka.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSenetBanka.Size = new System.Drawing.Size(200, 20);
            this.cmbSenetBanka.TabIndex = 1;
            // 
            // frmBorc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 466);
            this.Controls.Add(this.grdCtrlSenetBorc);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = global::WinFormsUI.Properties.Resources.Senet_Kendi16x16;
            this.Name = "frmBorc";
            this.Text = "Borç Senedi İşlemleri";
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.groupControl3, 0);
            this.Controls.SetChildIndex(this.grdCtrlSenetBorc, 0);
            this.Controls.SetChildIndex(this.btnBaseClose, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlSenetBorc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkSenetBasim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetGenelToplam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetCariBakiye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetCariAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCariKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetVade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSenetKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSenetBanka.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdCtrlSenetBorc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.CheckEdit chkSenetBasim;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.TextEdit txtSenetGenelToplam;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtSenetCariBakiye;
        private DevExpress.XtraEditors.TextEdit txtSenetCariAd;
        private DevExpress.XtraEditors.ButtonEdit btnCariKod;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtSenetTutar;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtSenetVade;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ButtonEdit btnSenetKod;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cmbSenetBanka;
        private UserControls.gridButtons gridButtons1;
        private UserControls.gridButtons gridButtons2;
    }
}