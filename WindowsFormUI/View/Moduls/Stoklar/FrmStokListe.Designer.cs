
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
            this.txtKDV = new System.Windows.Forms.TextBox();
            this.lblKDV = new System.Windows.Forms.Label();
            this.txtStokAd = new System.Windows.Forms.TextBox();
            this.lblStokAd = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.lblBarkod = new System.Windows.Forms.Label();
            this.txtStokKod = new System.Windows.Forms.TextBox();
            this.lblStokKod = new System.Windows.Forms.Label();
            this.lstGrupView = new System.Windows.Forms.ListView();
            this.colGrupTur = new System.Windows.Forms.ColumnHeader();
            this.colGrupAd = new System.Windows.Forms.ColumnHeader();
            this.btnStokGrupSil = new System.Windows.Forms.Button();
            this.btnStokGrupEkle = new System.Windows.Forms.Button();
            this.dgvStokListe = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBarkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpStokListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokListe)).BeginInit();
            this.SuspendLayout();
            // 
            // grpStokListe
            // 
            this.grpStokListe.Controls.Add(this.txtKDV);
            this.grpStokListe.Controls.Add(this.lblKDV);
            this.grpStokListe.Controls.Add(this.txtStokAd);
            this.grpStokListe.Controls.Add(this.lblStokAd);
            this.grpStokListe.Controls.Add(this.txtBarkod);
            this.grpStokListe.Controls.Add(this.lblBarkod);
            this.grpStokListe.Controls.Add(this.txtStokKod);
            this.grpStokListe.Controls.Add(this.lblStokKod);
            this.grpStokListe.Controls.Add(this.lstGrupView);
            this.grpStokListe.Controls.Add(this.btnStokGrupSil);
            this.grpStokListe.Controls.Add(this.btnStokGrupEkle);
            this.grpStokListe.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpStokListe.Location = new System.Drawing.Point(0, 0);
            this.grpStokListe.Name = "grpStokListe";
            this.grpStokListe.Size = new System.Drawing.Size(216, 437);
            this.grpStokListe.TabIndex = 0;
            this.grpStokListe.TabStop = false;
            this.grpStokListe.Text = "Stok Bilgileri";
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
            // lstGrupView
            // 
            this.lstGrupView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstGrupView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colGrupTur,
            this.colGrupAd});
            this.lstGrupView.FullRowSelect = true;
            this.lstGrupView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstGrupView.HideSelection = false;
            this.lstGrupView.Location = new System.Drawing.Point(6, 260);
            this.lstGrupView.Name = "lstGrupView";
            this.lstGrupView.Size = new System.Drawing.Size(204, 171);
            this.lstGrupView.TabIndex = 6;
            this.lstGrupView.UseCompatibleStateImageBehavior = false;
            this.lstGrupView.View = System.Windows.Forms.View.Details;
            // 
            // colGrupTur
            // 
            this.colGrupTur.Text = "Grup Türü";
            this.colGrupTur.Width = 100;
            // 
            // colGrupAd
            // 
            this.colGrupAd.Text = "Grup Adı";
            this.colGrupAd.Width = 100;
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
            this.dgvStokListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStokListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colKod,
            this.colBarkod,
            this.colAd});
            this.dgvStokListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStokListe.GridColor = System.Drawing.Color.White;
            this.dgvStokListe.Location = new System.Drawing.Point(216, 0);
            this.dgvStokListe.Name = "dgvStokListe";
            this.dgvStokListe.ReadOnly = true;
            this.dgvStokListe.RowHeadersVisible = false;
            this.dgvStokListe.RowTemplate.Height = 25;
            this.dgvStokListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStokListe.Size = new System.Drawing.Size(560, 437);
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
            this.colAd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAd.DataPropertyName = "Ad";
            this.colAd.HeaderText = "Stok Adı";
            this.colAd.Name = "colAd";
            this.colAd.ReadOnly = true;
            // 
            // FrmStokListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 437);
            this.Controls.Add(this.dgvStokListe);
            this.Controls.Add(this.grpStokListe);
            this.Name = "FrmStokListe";
            this.Text = "FrmStokListe";
            this.Load += new System.EventHandler(this.FrmStokListe_Load);
            this.grpStokListe.ResumeLayout(false);
            this.grpStokListe.PerformLayout();
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
        private System.Windows.Forms.ListView lstGrupView;
        private System.Windows.Forms.Button btnStokGrupSil;
        private System.Windows.Forms.Button btnStokGrupEkle;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.ColumnHeader colGrupTur;
        private System.Windows.Forms.ColumnHeader colGrupAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAd;
    }
}