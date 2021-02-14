
namespace WinFormsUI.View.Moduller.Senet
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
            this.grdCtrlSenetListe = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSenetVade = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSenetTutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSenetKod = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSenetAsilBorclu = new DevExpress.XtraEditors.TextEdit();
            this.txtSenetCiroEden = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtSenetKonum = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlSenetListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetVade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetAsilBorclu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetCiroEden.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetKonum.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCtrlSenetListe
            // 
            this.grdCtrlSenetListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCtrlSenetListe.Location = new System.Drawing.Point(175, 0);
            this.grdCtrlSenetListe.MainView = this.gridView1;
            this.grdCtrlSenetListe.Name = "grdCtrlSenetListe";
            this.grdCtrlSenetListe.Size = new System.Drawing.Size(666, 452);
            this.grdCtrlSenetListe.TabIndex = 5;
            this.grdCtrlSenetListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdCtrlSenetListe;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtSenetKonum);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtSenetVade);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtSenetTutar);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtSenetKod);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtSenetAsilBorclu);
            this.groupControl1.Controls.Add(this.txtSenetCiroEden);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(175, 452);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Senet Bilgileri";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 206);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Asıl Borçlu";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 161);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Ciro Eden";
            // 
            // txtSenetVade
            // 
            this.txtSenetVade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenetVade.Location = new System.Drawing.Point(12, 135);
            this.txtSenetVade.Name = "txtSenetVade";
            this.txtSenetVade.Size = new System.Drawing.Size(157, 20);
            this.txtSenetVade.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 116);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Vadesi";
            // 
            // txtSenetTutar
            // 
            this.txtSenetTutar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenetTutar.Location = new System.Drawing.Point(12, 90);
            this.txtSenetTutar.Name = "txtSenetTutar";
            this.txtSenetTutar.Size = new System.Drawing.Size(157, 20);
            this.txtSenetTutar.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(28, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tutarı";
            // 
            // txtSenetKod
            // 
            this.txtSenetKod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenetKod.Location = new System.Drawing.Point(12, 45);
            this.txtSenetKod.Name = "txtSenetKod";
            this.txtSenetKod.Size = new System.Drawing.Size(157, 20);
            this.txtSenetKod.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Senet Kodu";
            // 
            // txtSenetAsilBorclu
            // 
            this.txtSenetAsilBorclu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenetAsilBorclu.Location = new System.Drawing.Point(12, 225);
            this.txtSenetAsilBorclu.Name = "txtSenetAsilBorclu";
            this.txtSenetAsilBorclu.Size = new System.Drawing.Size(157, 20);
            this.txtSenetAsilBorclu.TabIndex = 11;
            // 
            // txtSenetCiroEden
            // 
            this.txtSenetCiroEden.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenetCiroEden.Location = new System.Drawing.Point(12, 180);
            this.txtSenetCiroEden.Name = "txtSenetCiroEden";
            this.txtSenetCiroEden.Size = new System.Drawing.Size(157, 20);
            this.txtSenetCiroEden.TabIndex = 9;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 251);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(57, 13);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Senetin Yeri";
            // 
            // txtSenetKonum
            // 
            this.txtSenetKonum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenetKonum.Location = new System.Drawing.Point(12, 270);
            this.txtSenetKonum.Name = "txtSenetKonum";
            this.txtSenetKonum.Size = new System.Drawing.Size(157, 20);
            this.txtSenetKonum.TabIndex = 13;
            // 
            // frmSenetListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 452);
            this.Controls.Add(this.grdCtrlSenetListe);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = global::WinFormsUI.Properties.Resources.Senet_Cariye16x16;
            this.Name = "frmSenetListe";
            this.Text = "Portföydeki Senet Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlSenetListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetVade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetAsilBorclu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetCiroEden.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenetKonum.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdCtrlSenetListe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtSenetVade;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtSenetTutar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSenetKod;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSenetAsilBorclu;
        private DevExpress.XtraEditors.TextEdit txtSenetCiroEden;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtSenetKonum;
    }
}