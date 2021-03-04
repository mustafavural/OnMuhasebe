
namespace WindowsFormUI.View.Moduls.Cariler
{
    partial class FrmCariGrup
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
            this.dgvGruplar = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpEkleGuncelle = new System.Windows.Forms.GroupBox();
            this.uscGruplar = new WindowsFormUI.View.UserControls.UscFormButtons();
            this.lblGrupAd = new System.Windows.Forms.Label();
            this.lblGrupKod = new System.Windows.Forms.Label();
            this.txtGrupKodAd = new System.Windows.Forms.TextBox();
            this.txtGrupKodTur = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGruplar)).BeginInit();
            this.grpEkleGuncelle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGruplar
            // 
            this.dgvGruplar.AllowUserToAddRows = false;
            this.dgvGruplar.AllowUserToDeleteRows = false;
            this.dgvGruplar.AllowUserToResizeRows = false;
            this.dgvGruplar.BackgroundColor = System.Drawing.Color.White;
            this.dgvGruplar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvGruplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGruplar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colTur,
            this.colAd});
            this.dgvGruplar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGruplar.Location = new System.Drawing.Point(0, 127);
            this.dgvGruplar.MultiSelect = false;
            this.dgvGruplar.Name = "dgvGruplar";
            this.dgvGruplar.ReadOnly = true;
            this.dgvGruplar.RowHeadersVisible = false;
            this.dgvGruplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGruplar.Size = new System.Drawing.Size(522, 232);
            this.dgvGruplar.TabIndex = 4;
            this.dgvGruplar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGruplar_CellDoubleClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.Frozen = true;
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colTur
            // 
            this.colTur.DataPropertyName = "Tur";
            this.colTur.Frozen = true;
            this.colTur.HeaderText = "Grup Türü";
            this.colTur.Name = "colTur";
            this.colTur.ReadOnly = true;
            this.colTur.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTur.Width = 150;
            // 
            // colAd
            // 
            this.colAd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAd.DataPropertyName = "Ad";
            this.colAd.HeaderText = "Grup Adı";
            this.colAd.Name = "colAd";
            this.colAd.ReadOnly = true;
            this.colAd.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // grpEkleGuncelle
            // 
            this.grpEkleGuncelle.Controls.Add(this.uscGruplar);
            this.grpEkleGuncelle.Controls.Add(this.lblGrupAd);
            this.grpEkleGuncelle.Controls.Add(this.lblGrupKod);
            this.grpEkleGuncelle.Controls.Add(this.txtGrupKodAd);
            this.grpEkleGuncelle.Controls.Add(this.txtGrupKodTur);
            this.grpEkleGuncelle.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpEkleGuncelle.Location = new System.Drawing.Point(0, 0);
            this.grpEkleGuncelle.Name = "grpEkleGuncelle";
            this.grpEkleGuncelle.Size = new System.Drawing.Size(522, 127);
            this.grpEkleGuncelle.TabIndex = 3;
            this.grpEkleGuncelle.TabStop = false;
            this.grpEkleGuncelle.Text = "Grup Ekle Güncelle";
            // 
            // uscGruplar
            // 
            this.uscGruplar.BtnClear_Visible = true;
            this.uscGruplar.BtnDelete_Enable = true;
            this.uscGruplar.BtnDelete_Text = "Sil     ";
            this.uscGruplar.BtnSave_Enable = true;
            this.uscGruplar.BtnSave_Text = "Kaydet";
            this.uscGruplar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uscGruplar.Location = new System.Drawing.Point(3, 71);
            this.uscGruplar.Name = "uscGruplar";
            this.uscGruplar.Size = new System.Drawing.Size(516, 53);
            this.uscGruplar.TabIndex = 4;
            this.uscGruplar.ClickClear += new System.EventHandler(this.UscGruplar_ClickClear);
            this.uscGruplar.ClickSave += new System.EventHandler(this.UscGruplar_GrupEkleGuncelle);
            this.uscGruplar.ClickCancel += new System.EventHandler(this.UscGruplar_GrupSil);
            // 
            // lblGrupAd
            // 
            this.lblGrupAd.AutoSize = true;
            this.lblGrupAd.Location = new System.Drawing.Point(202, 24);
            this.lblGrupAd.Name = "lblGrupAd";
            this.lblGrupAd.Size = new System.Drawing.Size(54, 15);
            this.lblGrupAd.TabIndex = 3;
            this.lblGrupAd.Text = "Grup Adı";
            // 
            // lblGrupKod
            // 
            this.lblGrupKod.AutoSize = true;
            this.lblGrupKod.Location = new System.Drawing.Point(12, 24);
            this.lblGrupKod.Name = "lblGrupKod";
            this.lblGrupKod.Size = new System.Drawing.Size(60, 15);
            this.lblGrupKod.TabIndex = 3;
            this.lblGrupKod.Text = "Grup Türü";
            // 
            // txtGrupKodAd
            // 
            this.txtGrupKodAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGrupKodAd.Location = new System.Drawing.Point(202, 42);
            this.txtGrupKodAd.Name = "txtGrupKodAd";
            this.txtGrupKodAd.Size = new System.Drawing.Size(314, 23);
            this.txtGrupKodAd.TabIndex = 1;
            // 
            // txtGrupKodTur
            // 
            this.txtGrupKodTur.Location = new System.Drawing.Point(12, 42);
            this.txtGrupKodTur.Name = "txtGrupKodTur";
            this.txtGrupKodTur.Size = new System.Drawing.Size(184, 23);
            this.txtGrupKodTur.TabIndex = 0;
            // 
            // FrmCariGrup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 359);
            this.Controls.Add(this.dgvGruplar);
            this.Controls.Add(this.grpEkleGuncelle);
            this.Name = "FrmCariGrup";
            this.Text = "Cari Grupları";
            this.Load += new System.EventHandler(this.FrmCariGrup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGruplar)).EndInit();
            this.grpEkleGuncelle.ResumeLayout(false);
            this.grpEkleGuncelle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGruplar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTur;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAd;
        private System.Windows.Forms.GroupBox grpEkleGuncelle;
        private UserControls.UscFormButtons uscGruplar;
        private System.Windows.Forms.Label lblGrupAd;
        private System.Windows.Forms.Label lblGrupKod;
        private System.Windows.Forms.TextBox txtGrupKodAd;
        private System.Windows.Forms.TextBox txtGrupKodTur;
    }
}