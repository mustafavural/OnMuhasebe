
namespace WinFormsUI.View.Moduller.Kasa
{
    partial class FrmKart
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
            this.gridButtons1 = new WinFormsUI.View.UserControls.gridButtons();
            this.memoKasaAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.btnKasaKod = new DevExpress.XtraEditors.ButtonEdit();
            this.txtKasaAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grdCtrlKasaTanim = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoKasaAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKasaKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlKasaTanim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnBaseClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBaseClose.FlatAppearance.BorderSize = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridButtons1);
            this.groupControl1.Controls.Add(this.memoKasaAciklama);
            this.groupControl1.Controls.Add(this.btnKasaKod);
            this.groupControl1.Controls.Add(this.txtKasaAd);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(365, 200);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Kasa Bilgileri";
            // 
            // gridButtons1
            // 
            this.gridButtons1.btnTemizleVisible = true;
            this.gridButtons1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridButtons1.Location = new System.Drawing.Point(2, 157);
            this.gridButtons1.Name = "gridButtons1";
            this.gridButtons1.Size = new System.Drawing.Size(361, 41);
            this.gridButtons1.TabIndex = 6;
            // 
            // memoKasaAciklama
            // 
            this.memoKasaAciklama.Location = new System.Drawing.Point(81, 84);
            this.memoKasaAciklama.Name = "memoKasaAciklama";
            this.memoKasaAciklama.Size = new System.Drawing.Size(272, 73);
            this.memoKasaAciklama.TabIndex = 5;
            // 
            // btnKasaKod
            // 
            this.btnKasaKod.Location = new System.Drawing.Point(81, 32);
            this.btnKasaKod.Name = "btnKasaKod";
            this.btnKasaKod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnKasaKod.Size = new System.Drawing.Size(272, 20);
            this.btnKasaKod.TabIndex = 1;
            this.btnKasaKod.Tag = "Kasa.frmListe";
            // 
            // txtKasaAd
            // 
            this.txtKasaAd.Location = new System.Drawing.Point(81, 58);
            this.txtKasaAd.Name = "txtKasaAd";
            this.txtKasaAd.Size = new System.Drawing.Size(272, 20);
            this.txtKasaAd.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 86);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Açıklama";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 61);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Kasa Adı";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kasa Kodu";
            // 
            // grdCtrlKasaTanim
            // 
            this.grdCtrlKasaTanim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCtrlKasaTanim.Location = new System.Drawing.Point(0, 200);
            this.grdCtrlKasaTanim.MainView = this.gridView1;
            this.grdCtrlKasaTanim.Name = "grdCtrlKasaTanim";
            this.grdCtrlKasaTanim.Size = new System.Drawing.Size(365, 208);
            this.grdCtrlKasaTanim.TabIndex = 1;
            this.grdCtrlKasaTanim.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdCtrlKasaTanim;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // frmKart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 408);
            this.Controls.Add(this.grdCtrlKasaTanim);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = global::WinFormsUI.Properties.Resources.Kasa_Karti16x16;
            this.Name = "frmKart";
            this.Text = "Kasa Tanımları";
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.grdCtrlKasaTanim, 0);
            this.Controls.SetChildIndex(this.btnBaseClose, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoKasaAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKasaKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlKasaTanim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.MemoEdit memoKasaAciklama;
        private DevExpress.XtraEditors.ButtonEdit btnKasaKod;
        private DevExpress.XtraEditors.TextEdit txtKasaAd;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl grdCtrlKasaTanim;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private UserControls.gridButtons gridButtons1;
    }
}