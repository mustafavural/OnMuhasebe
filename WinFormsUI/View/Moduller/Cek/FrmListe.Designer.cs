
namespace WinFormsUI.View.Moduller.Cek
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
            this.grdCtrlCekListe = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCekBanka = new DevExpress.XtraEditors.TextEdit();
            this.txtCekVade = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCekTutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCekKod = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCekAsilBorclu = new DevExpress.XtraEditors.TextEdit();
            this.txtCekCiroEden = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtCekKonum = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlCekListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekBanka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekVade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekAsilBorclu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekCiroEden.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekKonum.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCtrlCekListe
            // 
            this.grdCtrlCekListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCtrlCekListe.Location = new System.Drawing.Point(175, 0);
            this.grdCtrlCekListe.MainView = this.gridView1;
            this.grdCtrlCekListe.Name = "grdCtrlCekListe";
            this.grdCtrlCekListe.Size = new System.Drawing.Size(699, 453);
            this.grdCtrlCekListe.TabIndex = 3;
            this.grdCtrlCekListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdCtrlCekListe;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtCekKonum);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtCekBanka);
            this.groupControl1.Controls.Add(this.txtCekVade);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtCekTutar);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtCekKod);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtCekAsilBorclu);
            this.groupControl1.Controls.Add(this.txtCekCiroEden);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(175, 453);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Çek Bilgileri";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 251);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Asıl Borçlu";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 206);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Ciro Eden";
            // 
            // txtCekBanka
            // 
            this.txtCekBanka.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCekBanka.Location = new System.Drawing.Point(12, 180);
            this.txtCekBanka.Name = "txtCekBanka";
            this.txtCekBanka.Size = new System.Drawing.Size(157, 20);
            this.txtCekBanka.TabIndex = 7;
            // 
            // txtCekVade
            // 
            this.txtCekVade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCekVade.Location = new System.Drawing.Point(12, 135);
            this.txtCekVade.Name = "txtCekVade";
            this.txtCekVade.Size = new System.Drawing.Size(157, 20);
            this.txtCekVade.TabIndex = 5;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(12, 161);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(36, 13);
            this.labelControl9.TabIndex = 6;
            this.labelControl9.Text = "Bankası";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 116);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Vadesi";
            // 
            // txtCekTutar
            // 
            this.txtCekTutar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCekTutar.Location = new System.Drawing.Point(12, 90);
            this.txtCekTutar.Name = "txtCekTutar";
            this.txtCekTutar.Size = new System.Drawing.Size(157, 20);
            this.txtCekTutar.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(28, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tutarı";
            // 
            // txtCekKod
            // 
            this.txtCekKod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCekKod.Location = new System.Drawing.Point(12, 45);
            this.txtCekKod.Name = "txtCekKod";
            this.txtCekKod.Size = new System.Drawing.Size(157, 20);
            this.txtCekKod.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Çek Kodu";
            // 
            // txtCekAsilBorclu
            // 
            this.txtCekAsilBorclu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCekAsilBorclu.Location = new System.Drawing.Point(12, 270);
            this.txtCekAsilBorclu.Name = "txtCekAsilBorclu";
            this.txtCekAsilBorclu.Size = new System.Drawing.Size(157, 20);
            this.txtCekAsilBorclu.TabIndex = 11;
            // 
            // txtCekCiroEden
            // 
            this.txtCekCiroEden.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCekCiroEden.Location = new System.Drawing.Point(12, 225);
            this.txtCekCiroEden.Name = "txtCekCiroEden";
            this.txtCekCiroEden.Size = new System.Drawing.Size(157, 20);
            this.txtCekCiroEden.TabIndex = 9;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 296);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(47, 13);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Çekin Yeri";
            // 
            // txtCekKonum
            // 
            this.txtCekKonum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCekKonum.Location = new System.Drawing.Point(12, 315);
            this.txtCekKonum.Name = "txtCekKonum";
            this.txtCekKonum.Size = new System.Drawing.Size(157, 20);
            this.txtCekKonum.TabIndex = 13;
            // 
            // frmCekListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 453);
            this.Controls.Add(this.grdCtrlCekListe);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = global::WinFormsUI.Properties.Resources.Cek_MusteriLst16x16;
            this.Name = "frmCekListe";
            this.Text = "Portföydeki Çek Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlCekListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekBanka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekVade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekAsilBorclu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekCiroEden.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekKonum.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdCtrlCekListe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtCekBanka;
        private DevExpress.XtraEditors.TextEdit txtCekVade;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCekTutar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCekKod;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtCekAsilBorclu;
        private DevExpress.XtraEditors.TextEdit txtCekCiroEden;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtCekKonum;
    }
}