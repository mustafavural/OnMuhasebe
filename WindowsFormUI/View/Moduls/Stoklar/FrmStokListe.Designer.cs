
namespace WindowsFormUI.View.Moduls.Stoklar
{
    partial class FrmStokListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStokListe));
            this.grpStokListe = new System.Windows.Forms.GroupBox();
            this.dgvGrupView = new System.Windows.Forms.DataGridView();
            this.colGrupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrupTur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrupAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtKDV = new System.Windows.Forms.TextBox();
            this.lblKDV = new System.Windows.Forms.Label();
            this.txtStokAd = new System.Windows.Forms.TextBox();
            this.lblStokAd = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.lblBarkod = new System.Windows.Forms.Label();
            this.txtStokKod = new System.Windows.Forms.TextBox();
            this.lblStokKod = new System.Windows.Forms.Label();
            this.btnStokGrupSil = new System.Windows.Forms.Button();
            this.btnStokGrupEkle = new System.Windows.Forms.Button();
            this.dgvStokListe = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBarkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirim2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOran2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirim3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOran3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpStokListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokListe)).BeginInit();
            this.SuspendLayout();
            // 
            // grpStokListe
            // 
            this.grpStokListe.Controls.Add(this.dgvGrupView);
            this.grpStokListe.Controls.Add(this.txtKDV);
            this.grpStokListe.Controls.Add(this.lblKDV);
            this.grpStokListe.Controls.Add(this.txtStokAd);
            this.grpStokListe.Controls.Add(this.lblStokAd);
            this.grpStokListe.Controls.Add(this.txtBarkod);
            this.grpStokListe.Controls.Add(this.lblBarkod);
            this.grpStokListe.Controls.Add(this.txtStokKod);
            this.grpStokListe.Controls.Add(this.lblStokKod);
            this.grpStokListe.Controls.Add(this.btnStokGrupSil);
            this.grpStokListe.Controls.Add(this.btnStokGrupEkle);
            this.grpStokListe.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpStokListe.Location = new System.Drawing.Point(0, 0);
            this.grpStokListe.Name = "grpStokListe";
            this.grpStokListe.Size = new System.Drawing.Size(216, 443);
            this.grpStokListe.TabIndex = 0;
            this.grpStokListe.TabStop = false;
            this.grpStokListe.Text = "Stok Bilgileri";
            // 
            // dgvGrupView
            // 
            this.dgvGrupView.AllowUserToAddRows = false;
            this.dgvGrupView.AllowUserToDeleteRows = false;
            this.dgvGrupView.AllowUserToResizeRows = false;
            this.dgvGrupView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvGrupView.BackgroundColor = System.Drawing.Color.White;
            this.dgvGrupView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGrupId,
            this.colGrupTur,
            this.colGrupAd});
            this.dgvGrupView.Location = new System.Drawing.Point(6, 260);
            this.dgvGrupView.Name = "dgvGrupView";
            this.dgvGrupView.ReadOnly = true;
            this.dgvGrupView.RowHeadersVisible = false;
            this.dgvGrupView.RowTemplate.Height = 25;
            this.dgvGrupView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrupView.Size = new System.Drawing.Size(204, 177);
            this.dgvGrupView.TabIndex = 10;
            // 
            // colGrupId
            // 
            this.colGrupId.DataPropertyName = "Id";
            this.colGrupId.Frozen = true;
            this.colGrupId.HeaderText = "Id";
            this.colGrupId.Name = "colGrupId";
            this.colGrupId.ReadOnly = true;
            this.colGrupId.Visible = false;
            // 
            // colGrupTur
            // 
            this.colGrupTur.DataPropertyName = "Tur";
            this.colGrupTur.Frozen = true;
            this.colGrupTur.HeaderText = "Grup Türü";
            this.colGrupTur.Name = "colGrupTur";
            this.colGrupTur.ReadOnly = true;
            this.colGrupTur.Width = 90;
            // 
            // colGrupAd
            // 
            this.colGrupAd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGrupAd.DataPropertyName = "Ad";
            this.colGrupAd.HeaderText = "Grup Adı";
            this.colGrupAd.Name = "colGrupAd";
            this.colGrupAd.ReadOnly = true;
            // 
            // txtKDV
            // 
            this.txtKDV.Location = new System.Drawing.Point(6, 185);
            this.txtKDV.Name = "txtKDV";
            this.txtKDV.Size = new System.Drawing.Size(204, 23);
            this.txtKDV.TabIndex = 3;
            this.txtKDV.TextChanged += new System.EventHandler(this.TxtStokBilgiler_TextChanged);
            // 
            // lblKDV
            // 
            this.lblKDV.AutoSize = true;
            this.lblKDV.Location = new System.Drawing.Point(6, 167);
            this.lblKDV.Name = "lblKDV";
            this.lblKDV.Size = new System.Drawing.Size(29, 15);
            this.lblKDV.TabIndex = 9;
            this.lblKDV.Text = "KDV";
            // 
            // txtStokAd
            // 
            this.txtStokAd.Location = new System.Drawing.Point(6, 140);
            this.txtStokAd.Name = "txtStokAd";
            this.txtStokAd.Size = new System.Drawing.Size(204, 23);
            this.txtStokAd.TabIndex = 2;
            this.txtStokAd.TextChanged += new System.EventHandler(this.TxtStokBilgiler_TextChanged);
            // 
            // lblStokAd
            // 
            this.lblStokAd.AutoSize = true;
            this.lblStokAd.Location = new System.Drawing.Point(6, 122);
            this.lblStokAd.Name = "lblStokAd";
            this.lblStokAd.Size = new System.Drawing.Size(51, 15);
            this.lblStokAd.TabIndex = 7;
            this.lblStokAd.Text = "Stok Adı";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(6, 95);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(204, 23);
            this.txtBarkod.TabIndex = 1;
            this.txtBarkod.TextChanged += new System.EventHandler(this.TxtStokBilgiler_TextChanged);
            // 
            // lblBarkod
            // 
            this.lblBarkod.AutoSize = true;
            this.lblBarkod.Location = new System.Drawing.Point(6, 77);
            this.lblBarkod.Name = "lblBarkod";
            this.lblBarkod.Size = new System.Drawing.Size(51, 15);
            this.lblBarkod.TabIndex = 5;
            this.lblBarkod.Text = "Barkodu";
            // 
            // txtStokKod
            // 
            this.txtStokKod.Location = new System.Drawing.Point(6, 50);
            this.txtStokKod.Name = "txtStokKod";
            this.txtStokKod.Size = new System.Drawing.Size(204, 23);
            this.txtStokKod.TabIndex = 0;
            this.txtStokKod.TextChanged += new System.EventHandler(this.TxtStokBilgiler_TextChanged);
            // 
            // lblStokKod
            // 
            this.lblStokKod.AutoSize = true;
            this.lblStokKod.Location = new System.Drawing.Point(6, 32);
            this.lblStokKod.Name = "lblStokKod";
            this.lblStokKod.Size = new System.Drawing.Size(61, 15);
            this.lblStokKod.TabIndex = 3;
            this.lblStokKod.Text = "Stok Kodu";
            // 
            // btnStokGrupSil
            // 
            this.btnStokGrupSil.Image = ((System.Drawing.Image)(resources.GetObject("btnStokGrupSil.Image")));
            this.btnStokGrupSil.Location = new System.Drawing.Point(133, 214);
            this.btnStokGrupSil.Name = "btnStokGrupSil";
            this.btnStokGrupSil.Size = new System.Drawing.Size(43, 40);
            this.btnStokGrupSil.TabIndex = 5;
            this.btnStokGrupSil.UseVisualStyleBackColor = true;
            this.btnStokGrupSil.Click += new System.EventHandler(this.BtnStokGrupSil_Click);
            // 
            // btnStokGrupEkle
            // 
            this.btnStokGrupEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnStokGrupEkle.Image")));
            this.btnStokGrupEkle.Location = new System.Drawing.Point(44, 214);
            this.btnStokGrupEkle.Name = "btnStokGrupEkle";
            this.btnStokGrupEkle.Size = new System.Drawing.Size(43, 40);
            this.btnStokGrupEkle.TabIndex = 4;
            this.btnStokGrupEkle.UseVisualStyleBackColor = true;
            this.btnStokGrupEkle.Click += new System.EventHandler(this.BtnStokGrupEkle_Click);
            // 
            // dgvStokListe
            // 
            this.dgvStokListe.AllowUserToAddRows = false;
            this.dgvStokListe.AllowUserToDeleteRows = false;
            this.dgvStokListe.AllowUserToResizeRows = false;
            this.dgvStokListe.BackgroundColor = System.Drawing.Color.White;
            this.dgvStokListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStokListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colKod,
            this.colBarkod,
            this.colAd,
            this.colKDV,
            this.colBirim,
            this.colBirim2,
            this.colOran2,
            this.colBirim3,
            this.colOran3});
            this.dgvStokListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStokListe.Location = new System.Drawing.Point(216, 0);
            this.dgvStokListe.Name = "dgvStokListe";
            this.dgvStokListe.ReadOnly = true;
            this.dgvStokListe.RowHeadersVisible = false;
            this.dgvStokListe.RowTemplate.Height = 25;
            this.dgvStokListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStokListe.Size = new System.Drawing.Size(570, 443);
            this.dgvStokListe.TabIndex = 1;
            this.dgvStokListe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStokListe_CellDoubleClick);
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
            // colKod
            // 
            this.colKod.DataPropertyName = "Kod";
            this.colKod.Frozen = true;
            this.colKod.HeaderText = "Stok Kodu";
            this.colKod.Name = "colKod";
            this.colKod.ReadOnly = true;
            this.colKod.Width = 150;
            // 
            // colBarkod
            // 
            this.colBarkod.DataPropertyName = "Barkod";
            this.colBarkod.Frozen = true;
            this.colBarkod.HeaderText = "Barkodu";
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.ReadOnly = true;
            this.colBarkod.Width = 150;
            // 
            // colAd
            // 
            this.colAd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colAd.DataPropertyName = "Ad";
            this.colAd.Frozen = true;
            this.colAd.HeaderText = "Stok Adı";
            this.colAd.Name = "colAd";
            this.colAd.ReadOnly = true;
            this.colAd.Width = 267;
            // 
            // colKDV
            // 
            this.colKDV.DataPropertyName = "KDV";
            this.colKDV.Frozen = true;
            this.colKDV.HeaderText = "KDV";
            this.colKDV.Name = "colKDV";
            this.colKDV.ReadOnly = true;
            this.colKDV.Visible = false;
            // 
            // colBirim
            // 
            this.colBirim.DataPropertyName = "Birim";
            this.colBirim.Frozen = true;
            this.colBirim.HeaderText = "Birim";
            this.colBirim.Name = "colBirim";
            this.colBirim.ReadOnly = true;
            this.colBirim.Visible = false;
            // 
            // colBirim2
            // 
            this.colBirim2.DataPropertyName = "Birim2";
            this.colBirim2.Frozen = true;
            this.colBirim2.HeaderText = "Birim2";
            this.colBirim2.Name = "colBirim2";
            this.colBirim2.ReadOnly = true;
            this.colBirim2.Visible = false;
            // 
            // colOran2
            // 
            this.colOran2.DataPropertyName = "Birim2Oran";
            this.colOran2.Frozen = true;
            this.colOran2.HeaderText = "Birim2Oran";
            this.colOran2.Name = "colOran2";
            this.colOran2.ReadOnly = true;
            this.colOran2.Visible = false;
            // 
            // colBirim3
            // 
            this.colBirim3.DataPropertyName = "Birim3";
            this.colBirim3.Frozen = true;
            this.colBirim3.HeaderText = "Birim3";
            this.colBirim3.Name = "colBirim3";
            this.colBirim3.ReadOnly = true;
            this.colBirim3.Visible = false;
            // 
            // colOran3
            // 
            this.colOran3.DataPropertyName = "Birim3Oran";
            this.colOran3.Frozen = true;
            this.colOran3.HeaderText = "Birim3Oran";
            this.colOran3.Name = "colOran3";
            this.colOran3.ReadOnly = true;
            this.colOran3.Visible = false;
            // 
            // FrmStokListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 443);
            this.Controls.Add(this.dgvStokListe);
            this.Controls.Add(this.grpStokListe);
            this.Name = "FrmStokListe";
            this.Text = "FrmStokListe";
            this.Load += new System.EventHandler(this.FrmStokListe_Load);
            this.grpStokListe.ResumeLayout(false);
            this.grpStokListe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpStokListe;
        private System.Windows.Forms.DataGridView dgvStokListe;
        private System.Windows.Forms.TextBox txtKDV;
        private System.Windows.Forms.Label lblKDV;
        private System.Windows.Forms.TextBox txtStokAd;
        private System.Windows.Forms.Label lblStokAd;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label lblBarkod;
        private System.Windows.Forms.TextBox txtStokKod;
        private System.Windows.Forms.Label lblStokKod;
        private System.Windows.Forms.Button btnStokGrupSil;
        private System.Windows.Forms.Button btnStokGrupEkle;
        private System.Windows.Forms.DataGridView dgvGrupView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrupTur;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrupAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBirim;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBirim2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOran2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBirim3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOran3;
    }
}