﻿
namespace WinFormsUI.View.Moduller.Kasa
{
    partial class FrmMuhtelif
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
            this.grdCtrlKasaCari = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridButtons1 = new WinFormsUI.View.UserControls.gridButtons();
            this.txtKasaAciklamasi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtTutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtFisNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtKasaAd = new DevExpress.XtraEditors.TextEdit();
            this.btnKasaKod = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtnTediye = new System.Windows.Forms.RadioButton();
            this.rdbtnTahsilat = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlKasaCari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAciklamasi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFisNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKasaKod.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnBaseClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBaseClose.FlatAppearance.BorderSize = 0;
            // 
            // grdCtrlKasaCari
            // 
            this.grdCtrlKasaCari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCtrlKasaCari.Location = new System.Drawing.Point(0, 123);
            this.grdCtrlKasaCari.MainView = this.gridView1;
            this.grdCtrlKasaCari.Name = "grdCtrlKasaCari";
            this.grdCtrlKasaCari.Size = new System.Drawing.Size(912, 282);
            this.grdCtrlKasaCari.TabIndex = 3;
            this.grdCtrlKasaCari.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdCtrlKasaCari;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridButtons1);
            this.groupControl1.Controls.Add(this.txtKasaAciklamasi);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtTutar);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtFisNo);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtKasaAd);
            this.groupControl1.Controls.Add(this.btnKasaKod);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(912, 123);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Bilgiler";
            // 
            // gridButtons1
            // 
            this.gridButtons1.btnTemizleVisible = true;
            this.gridButtons1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridButtons1.Location = new System.Drawing.Point(2, 81);
            this.gridButtons1.Name = "gridButtons1";
            this.gridButtons1.Size = new System.Drawing.Size(908, 40);
            this.gridButtons1.TabIndex = 17;
            // 
            // txtKasaAciklamasi
            // 
            this.txtKasaAciklamasi.Location = new System.Drawing.Point(677, 46);
            this.txtKasaAciklamasi.Name = "txtKasaAciklamasi";
            this.txtKasaAciklamasi.Size = new System.Drawing.Size(163, 20);
            this.txtKasaAciklamasi.TabIndex = 16;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(677, 27);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(74, 13);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "Kasa Açıklaması";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(543, 46);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(128, 20);
            this.txtTutar.TabIndex = 14;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(543, 27);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(26, 13);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "Tutar";
            // 
            // txtFisNo
            // 
            this.txtFisNo.Location = new System.Drawing.Point(426, 46);
            this.txtFisNo.Name = "txtFisNo";
            this.txtFisNo.Size = new System.Drawing.Size(111, 20);
            this.txtFisNo.TabIndex = 12;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(426, 27);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(29, 13);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Fiş No";
            // 
            // txtKasaAd
            // 
            this.txtKasaAd.Enabled = false;
            this.txtKasaAd.Location = new System.Drawing.Point(260, 46);
            this.txtKasaAd.Name = "txtKasaAd";
            this.txtKasaAd.Size = new System.Drawing.Size(160, 20);
            this.txtKasaAd.TabIndex = 10;
            // 
            // btnKasaKod
            // 
            this.btnKasaKod.Location = new System.Drawing.Point(164, 46);
            this.btnKasaKod.Name = "btnKasaKod";
            this.btnKasaKod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnKasaKod.Size = new System.Drawing.Size(90, 20);
            this.btnKasaKod.TabIndex = 9;
            this.btnKasaKod.Tag = "Kasa.frmListe";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(164, 27);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(50, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Kasa Kodu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtnTediye);
            this.groupBox1.Controls.Add(this.rdbtnTahsilat);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş / Çıkış";
            // 
            // rdbtnTediye
            // 
            this.rdbtnTediye.AutoSize = true;
            this.rdbtnTediye.Location = new System.Drawing.Point(74, 21);
            this.rdbtnTediye.Name = "rdbtnTediye";
            this.rdbtnTediye.Size = new System.Drawing.Size(57, 17);
            this.rdbtnTediye.TabIndex = 1;
            this.rdbtnTediye.TabStop = true;
            this.rdbtnTediye.Text = "Tediye";
            this.rdbtnTediye.UseVisualStyleBackColor = true;
            // 
            // rdbtnTahsilat
            // 
            this.rdbtnTahsilat.AutoSize = true;
            this.rdbtnTahsilat.Location = new System.Drawing.Point(6, 21);
            this.rdbtnTahsilat.Name = "rdbtnTahsilat";
            this.rdbtnTahsilat.Size = new System.Drawing.Size(62, 17);
            this.rdbtnTahsilat.TabIndex = 0;
            this.rdbtnTahsilat.TabStop = true;
            this.rdbtnTahsilat.Text = "Tahsilat";
            this.rdbtnTahsilat.UseVisualStyleBackColor = true;
            // 
            // frmMuhtelif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 405);
            this.Controls.Add(this.grdCtrlKasaCari);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = global::WinFormsUI.Properties.Resources.Kasa_Odeme16x16;
            this.Name = "frmMuhtelif";
            this.Text = "Kasa Kayıtları - Muhtelif";
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.grdCtrlKasaCari, 0);
            this.Controls.SetChildIndex(this.btnBaseClose, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlKasaCari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAciklamasi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFisNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKasaKod.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdCtrlKasaCari;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtKasaAciklamasi;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtTutar;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtFisNo;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtKasaAd;
        private DevExpress.XtraEditors.ButtonEdit btnKasaKod;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbtnTediye;
        private System.Windows.Forms.RadioButton rdbtnTahsilat;
        private UserControls.gridButtons gridButtons1;
    }
}