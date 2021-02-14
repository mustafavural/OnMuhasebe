
namespace WinFormsUI.View.Moduller.Banka
{
    partial class FrmListe
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
            this.grdCtrlHesapListe = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtHesapNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtHesapSubesi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtHesapAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtHesapKod = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtHesapAciklama = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlHesapListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapSubesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapAciklama.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCtrlHesapListe
            // 
            this.grdCtrlHesapListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCtrlHesapListe.Location = new System.Drawing.Point(162, 0);
            this.grdCtrlHesapListe.MainView = this.gridView1;
            this.grdCtrlHesapListe.Name = "grdCtrlHesapListe";
            this.grdCtrlHesapListe.Size = new System.Drawing.Size(505, 401);
            this.grdCtrlHesapListe.TabIndex = 5;
            this.grdCtrlHesapListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdCtrlHesapListe;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtHesapAciklama);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtHesapNo);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtHesapSubesi);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtHesapAd);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtHesapKod);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(162, 401);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Hesap Bilgileri";
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHesapNo.Location = new System.Drawing.Point(12, 90);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(144, 20);
            this.txtHesapNo.TabIndex = 21;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 71);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 13);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "Hesap No";
            // 
            // txtHesapSubesi
            // 
            this.txtHesapSubesi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHesapSubesi.Location = new System.Drawing.Point(12, 180);
            this.txtHesapSubesi.Name = "txtHesapSubesi";
            this.txtHesapSubesi.Size = new System.Drawing.Size(144, 20);
            this.txtHesapSubesi.TabIndex = 19;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 161);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 13);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Hesap Şube Adı";
            // 
            // txtHesapAd
            // 
            this.txtHesapAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHesapAd.Location = new System.Drawing.Point(12, 135);
            this.txtHesapAd.Name = "txtHesapAd";
            this.txtHesapAd.Size = new System.Drawing.Size(144, 20);
            this.txtHesapAd.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 116);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Hesap Adı";
            // 
            // txtHesapKod
            // 
            this.txtHesapKod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHesapKod.Location = new System.Drawing.Point(12, 45);
            this.txtHesapKod.Name = "txtHesapKod";
            this.txtHesapKod.Size = new System.Drawing.Size(144, 20);
            this.txtHesapKod.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Hesap Kodu";
            // 
            // txtHesapAciklama
            // 
            this.txtHesapAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHesapAciklama.Location = new System.Drawing.Point(12, 225);
            this.txtHesapAciklama.Name = "txtHesapAciklama";
            this.txtHesapAciklama.Size = new System.Drawing.Size(144, 20);
            this.txtHesapAciklama.TabIndex = 23;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 206);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 13);
            this.labelControl5.TabIndex = 22;
            this.labelControl5.Text = "Açıklama";
            // 
            // frmBankaListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 401);
            this.Controls.Add(this.grdCtrlHesapListe);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmBankaListe";
            this.Text = "Banka Listeleri";
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlHesapListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapSubesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapAciklama.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdCtrlHesapListe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtHesapSubesi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtHesapAd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtHesapKod;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtHesapNo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtHesapAciklama;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}