
namespace WindowsFormUI.View.Moduls.Stok
{
    partial class FrmStokGrup
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
            this.GrpEkleGuncelle = new System.Windows.Forms.GroupBox();
            this.UscGruplar = new WindowsFormUI.View.UserControls.UscFormButtons();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtGrupAciklama = new System.Windows.Forms.TextBox();
            this.TxtGrupAd = new System.Windows.Forms.TextBox();
            this.TxtGrupKod = new System.Windows.Forms.TextBox();
            this.LsbGruplar = new System.Windows.Forms.ListBox();
            this.DgvGruplar = new System.Windows.Forms.DataGridView();
            this.ColKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrpEkleGuncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGruplar)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpEkleGuncelle
            // 
            this.GrpEkleGuncelle.Controls.Add(this.UscGruplar);
            this.GrpEkleGuncelle.Controls.Add(this.label3);
            this.GrpEkleGuncelle.Controls.Add(this.label2);
            this.GrpEkleGuncelle.Controls.Add(this.label1);
            this.GrpEkleGuncelle.Controls.Add(this.TxtGrupAciklama);
            this.GrpEkleGuncelle.Controls.Add(this.TxtGrupAd);
            this.GrpEkleGuncelle.Controls.Add(this.TxtGrupKod);
            this.GrpEkleGuncelle.Dock = System.Windows.Forms.DockStyle.Top;
            this.GrpEkleGuncelle.Location = new System.Drawing.Point(0, 0);
            this.GrpEkleGuncelle.Name = "GrpEkleGuncelle";
            this.GrpEkleGuncelle.Size = new System.Drawing.Size(697, 127);
            this.GrpEkleGuncelle.TabIndex = 0;
            this.GrpEkleGuncelle.TabStop = false;
            this.GrpEkleGuncelle.Text = "Grup Ekle Güncelle";
            // 
            // UscGruplar
            // 
            this.UscGruplar.BtnClear_Visible = true;
            this.UscGruplar.BtnDelete_Enable = true;
            this.UscGruplar.BtnDelete_Text = "Sil     ";
            this.UscGruplar.BtnSave_Enable = true;
            this.UscGruplar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UscGruplar.Location = new System.Drawing.Point(3, 72);
            this.UscGruplar.Name = "UscGruplar";
            this.UscGruplar.Size = new System.Drawing.Size(691, 52);
            this.UscGruplar.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Açıklama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Grup Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Grup Kodu";
            // 
            // TxtGrupAciklama
            // 
            this.TxtGrupAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtGrupAciklama.Location = new System.Drawing.Point(224, 42);
            this.TxtGrupAciklama.Name = "TxtGrupAciklama";
            this.TxtGrupAciklama.Size = new System.Drawing.Size(461, 23);
            this.TxtGrupAciklama.TabIndex = 2;
            // 
            // TxtGrupAd
            // 
            this.TxtGrupAd.Location = new System.Drawing.Point(118, 42);
            this.TxtGrupAd.Name = "TxtGrupAd";
            this.TxtGrupAd.Size = new System.Drawing.Size(100, 23);
            this.TxtGrupAd.TabIndex = 1;
            // 
            // TxtGrupKod
            // 
            this.TxtGrupKod.Location = new System.Drawing.Point(12, 42);
            this.TxtGrupKod.Name = "TxtGrupKod";
            this.TxtGrupKod.Size = new System.Drawing.Size(100, 23);
            this.TxtGrupKod.TabIndex = 0;
            // 
            // LsbGruplar
            // 
            this.LsbGruplar.Dock = System.Windows.Forms.DockStyle.Left;
            this.LsbGruplar.FormattingEnabled = true;
            this.LsbGruplar.ItemHeight = 15;
            this.LsbGruplar.Location = new System.Drawing.Point(0, 127);
            this.LsbGruplar.Name = "LsbGruplar";
            this.LsbGruplar.Size = new System.Drawing.Size(120, 196);
            this.LsbGruplar.TabIndex = 1;
            // 
            // DgvGruplar
            // 
            this.DgvGruplar.AllowUserToAddRows = false;
            this.DgvGruplar.AllowUserToDeleteRows = false;
            this.DgvGruplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGruplar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColKodu,
            this.ColAd,
            this.ColAciklama});
            this.DgvGruplar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvGruplar.Location = new System.Drawing.Point(120, 127);
            this.DgvGruplar.Name = "DgvGruplar";
            this.DgvGruplar.ReadOnly = true;
            this.DgvGruplar.Size = new System.Drawing.Size(577, 196);
            this.DgvGruplar.TabIndex = 2;
            // 
            // ColKodu
            // 
            this.ColKodu.HeaderText = "Kodu";
            this.ColKodu.Name = "ColKodu";
            this.ColKodu.ReadOnly = true;
            // 
            // ColAd
            // 
            this.ColAd.HeaderText = "Adı";
            this.ColAd.Name = "ColAd";
            this.ColAd.ReadOnly = true;
            this.ColAd.Width = 150;
            // 
            // ColAciklama
            // 
            this.ColAciklama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColAciklama.HeaderText = "Açıklama";
            this.ColAciklama.Name = "ColAciklama";
            this.ColAciklama.ReadOnly = true;
            // 
            // FrmStokGrup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 323);
            this.Controls.Add(this.DgvGruplar);
            this.Controls.Add(this.LsbGruplar);
            this.Controls.Add(this.GrpEkleGuncelle);
            this.Name = "FrmStokGrup";
            this.Text = "Stok Grupları";
            this.GrpEkleGuncelle.ResumeLayout(false);
            this.GrpEkleGuncelle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGruplar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpEkleGuncelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtGrupAciklama;
        private System.Windows.Forms.TextBox TxtGrupAd;
        private System.Windows.Forms.TextBox TxtGrupKod;
        private UserControls.UscFormButtons UscGruplar;
        private System.Windows.Forms.ListBox LsbGruplar;
        private System.Windows.Forms.DataGridView DgvGruplar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAciklama;
    }
}