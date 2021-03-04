
namespace WindowsFormUI.View.Moduls.Cariler
{
    partial class FrmCariListe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCariListe));
            this.dgvCariListe = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnvan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVergiDairesi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVergiNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTCNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpCariListe = new System.Windows.Forms.GroupBox();
            this.txtTCNo = new System.Windows.Forms.TextBox();
            this.lblTCNo = new System.Windows.Forms.Label();
            this.dgvGrupView = new System.Windows.Forms.DataGridView();
            this.colGrupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrupTur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrupAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtVergiNo = new System.Windows.Forms.TextBox();
            this.lblVergiNo = new System.Windows.Forms.Label();
            this.txtVergiDairesi = new System.Windows.Forms.TextBox();
            this.lblVergiDairesi = new System.Windows.Forms.Label();
            this.txtUnvan = new System.Windows.Forms.TextBox();
            this.lblUnvan = new System.Windows.Forms.Label();
            this.txtCariKod = new System.Windows.Forms.TextBox();
            this.lblCariKod = new System.Windows.Forms.Label();
            this.btnCariGrupSil = new System.Windows.Forms.Button();
            this.btnCariGrupEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariListe)).BeginInit();
            this.grpCariListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCariListe
            // 
            this.dgvCariListe.AllowUserToAddRows = false;
            this.dgvCariListe.AllowUserToDeleteRows = false;
            this.dgvCariListe.AllowUserToResizeRows = false;
            this.dgvCariListe.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCariListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCariListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCariListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colKod,
            this.colUnvan,
            this.colVergiDairesi,
            this.colVergiNo,
            this.colTCNo});
            this.dgvCariListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCariListe.Location = new System.Drawing.Point(216, 0);
            this.dgvCariListe.Name = "dgvCariListe";
            this.dgvCariListe.ReadOnly = true;
            this.dgvCariListe.RowHeadersVisible = false;
            this.dgvCariListe.RowTemplate.Height = 25;
            this.dgvCariListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCariListe.Size = new System.Drawing.Size(669, 452);
            this.dgvCariListe.TabIndex = 3;
            this.dgvCariListe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCariListe_CellDoubleClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.Frozen = true;
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colId.Visible = false;
            // 
            // colKod
            // 
            this.colKod.DataPropertyName = "Kod";
            this.colKod.Frozen = true;
            this.colKod.HeaderText = "Cari Kodu";
            this.colKod.Name = "colKod";
            this.colKod.ReadOnly = true;
            this.colKod.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colUnvan
            // 
            this.colUnvan.DataPropertyName = "Unvan";
            this.colUnvan.Frozen = true;
            this.colUnvan.HeaderText = "Unvanı";
            this.colUnvan.Name = "colUnvan";
            this.colUnvan.ReadOnly = true;
            this.colUnvan.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colUnvan.Width = 267;
            // 
            // colVergiDairesi
            // 
            this.colVergiDairesi.DataPropertyName = "VergiDairesi";
            this.colVergiDairesi.Frozen = true;
            this.colVergiDairesi.HeaderText = "Vergi Dairesi";
            this.colVergiDairesi.Name = "colVergiDairesi";
            this.colVergiDairesi.ReadOnly = true;
            this.colVergiDairesi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colVergiNo
            // 
            this.colVergiNo.DataPropertyName = "VergiNo";
            this.colVergiNo.Frozen = true;
            this.colVergiNo.HeaderText = "Vergi No";
            this.colVergiNo.Name = "colVergiNo";
            this.colVergiNo.ReadOnly = true;
            this.colVergiNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colTCNo
            // 
            this.colTCNo.DataPropertyName = "TCNo";
            this.colTCNo.Frozen = true;
            this.colTCNo.HeaderText = "TC No";
            this.colTCNo.Name = "colTCNo";
            this.colTCNo.ReadOnly = true;
            this.colTCNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // grpCariListe
            // 
            this.grpCariListe.Controls.Add(this.txtTCNo);
            this.grpCariListe.Controls.Add(this.lblTCNo);
            this.grpCariListe.Controls.Add(this.dgvGrupView);
            this.grpCariListe.Controls.Add(this.txtVergiNo);
            this.grpCariListe.Controls.Add(this.lblVergiNo);
            this.grpCariListe.Controls.Add(this.txtVergiDairesi);
            this.grpCariListe.Controls.Add(this.lblVergiDairesi);
            this.grpCariListe.Controls.Add(this.txtUnvan);
            this.grpCariListe.Controls.Add(this.lblUnvan);
            this.grpCariListe.Controls.Add(this.txtCariKod);
            this.grpCariListe.Controls.Add(this.lblCariKod);
            this.grpCariListe.Controls.Add(this.btnCariGrupSil);
            this.grpCariListe.Controls.Add(this.btnCariGrupEkle);
            this.grpCariListe.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpCariListe.Location = new System.Drawing.Point(0, 0);
            this.grpCariListe.Name = "grpCariListe";
            this.grpCariListe.Size = new System.Drawing.Size(216, 452);
            this.grpCariListe.TabIndex = 2;
            this.grpCariListe.TabStop = false;
            this.grpCariListe.Text = "Cari Bilgileri";
            // 
            // txtTCNo
            // 
            this.txtTCNo.Location = new System.Drawing.Point(6, 214);
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Size = new System.Drawing.Size(204, 23);
            this.txtTCNo.TabIndex = 11;
            this.txtTCNo.TextChanged += new System.EventHandler(this.TxtCariBilgiler_TextChanged);
            // 
            // lblTCNo
            // 
            this.lblTCNo.AutoSize = true;
            this.lblTCNo.Location = new System.Drawing.Point(6, 196);
            this.lblTCNo.Name = "lblTCNo";
            this.lblTCNo.Size = new System.Drawing.Size(39, 15);
            this.lblTCNo.TabIndex = 12;
            this.lblTCNo.Text = "TC No";
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
            this.dgvGrupView.Location = new System.Drawing.Point(6, 291);
            this.dgvGrupView.Name = "dgvGrupView";
            this.dgvGrupView.ReadOnly = true;
            this.dgvGrupView.RowHeadersVisible = false;
            this.dgvGrupView.RowTemplate.Height = 25;
            this.dgvGrupView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrupView.Size = new System.Drawing.Size(204, 155);
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
            // txtVergiNo
            // 
            this.txtVergiNo.Location = new System.Drawing.Point(6, 170);
            this.txtVergiNo.Name = "txtVergiNo";
            this.txtVergiNo.Size = new System.Drawing.Size(204, 23);
            this.txtVergiNo.TabIndex = 3;
            this.txtVergiNo.TextChanged += new System.EventHandler(this.TxtCariBilgiler_TextChanged);
            // 
            // lblVergiNo
            // 
            this.lblVergiNo.AutoSize = true;
            this.lblVergiNo.Location = new System.Drawing.Point(6, 152);
            this.lblVergiNo.Name = "lblVergiNo";
            this.lblVergiNo.Size = new System.Drawing.Size(52, 15);
            this.lblVergiNo.TabIndex = 9;
            this.lblVergiNo.Text = "Vergi No";
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(6, 125);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(204, 23);
            this.txtVergiDairesi.TabIndex = 2;
            this.txtVergiDairesi.TextChanged += new System.EventHandler(this.TxtCariBilgiler_TextChanged);
            // 
            // lblVergiDairesi
            // 
            this.lblVergiDairesi.AutoSize = true;
            this.lblVergiDairesi.Location = new System.Drawing.Point(6, 107);
            this.lblVergiDairesi.Name = "lblVergiDairesi";
            this.lblVergiDairesi.Size = new System.Drawing.Size(71, 15);
            this.lblVergiDairesi.TabIndex = 7;
            this.lblVergiDairesi.Text = "Vergi Dairesi";
            // 
            // txtUnvan
            // 
            this.txtUnvan.Location = new System.Drawing.Point(6, 81);
            this.txtUnvan.Name = "txtUnvan";
            this.txtUnvan.Size = new System.Drawing.Size(204, 23);
            this.txtUnvan.TabIndex = 1;
            this.txtUnvan.TextChanged += new System.EventHandler(this.TxtCariBilgiler_TextChanged);
            // 
            // lblUnvan
            // 
            this.lblUnvan.AutoSize = true;
            this.lblUnvan.Location = new System.Drawing.Point(6, 63);
            this.lblUnvan.Name = "lblUnvan";
            this.lblUnvan.Size = new System.Drawing.Size(44, 15);
            this.lblUnvan.TabIndex = 5;
            this.lblUnvan.Text = "Unvanı";
            // 
            // txtCariKod
            // 
            this.txtCariKod.Location = new System.Drawing.Point(6, 37);
            this.txtCariKod.Name = "txtCariKod";
            this.txtCariKod.Size = new System.Drawing.Size(204, 23);
            this.txtCariKod.TabIndex = 0;
            this.txtCariKod.TextChanged += new System.EventHandler(this.TxtCariBilgiler_TextChanged);
            // 
            // lblCariKod
            // 
            this.lblCariKod.AutoSize = true;
            this.lblCariKod.Location = new System.Drawing.Point(6, 19);
            this.lblCariKod.Name = "lblCariKod";
            this.lblCariKod.Size = new System.Drawing.Size(59, 15);
            this.lblCariKod.TabIndex = 3;
            this.lblCariKod.Text = "Cari Kodu";
            // 
            // btnCariGrupSil
            // 
            this.btnCariGrupSil.Image = ((System.Drawing.Image)(resources.GetObject("btnCariGrupSil.Image")));
            this.btnCariGrupSil.Location = new System.Drawing.Point(134, 245);
            this.btnCariGrupSil.Name = "btnCariGrupSil";
            this.btnCariGrupSil.Size = new System.Drawing.Size(43, 40);
            this.btnCariGrupSil.TabIndex = 5;
            this.btnCariGrupSil.UseVisualStyleBackColor = true;
            this.btnCariGrupSil.Click += new System.EventHandler(this.BtnCariGrupSil_Click);
            // 
            // btnCariGrupEkle
            // 
            this.btnCariGrupEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnCariGrupEkle.Image")));
            this.btnCariGrupEkle.Location = new System.Drawing.Point(45, 245);
            this.btnCariGrupEkle.Name = "btnCariGrupEkle";
            this.btnCariGrupEkle.Size = new System.Drawing.Size(43, 40);
            this.btnCariGrupEkle.TabIndex = 4;
            this.btnCariGrupEkle.UseVisualStyleBackColor = true;
            this.btnCariGrupEkle.Click += new System.EventHandler(this.BtnCariGrupEkle_Click);
            // 
            // FrmCariListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 452);
            this.Controls.Add(this.dgvCariListe);
            this.Controls.Add(this.grpCariListe);
            this.Name = "FrmCariListe";
            this.Text = "FrmCariListe";
            this.Load += new System.EventHandler(this.FrmCariListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariListe)).EndInit();
            this.grpCariListe.ResumeLayout(false);
            this.grpCariListe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCariListe;
        private System.Windows.Forms.GroupBox grpCariListe;
        private System.Windows.Forms.DataGridView dgvGrupView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrupTur;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrupAd;
        private System.Windows.Forms.TextBox txtVergiNo;
        private System.Windows.Forms.Label lblVergiNo;
        private System.Windows.Forms.TextBox txtVergiDairesi;
        private System.Windows.Forms.Label lblVergiDairesi;
        private System.Windows.Forms.TextBox txtUnvan;
        private System.Windows.Forms.Label lblUnvan;
        private System.Windows.Forms.TextBox txtCariKod;
        private System.Windows.Forms.Label lblCariKod;
        private System.Windows.Forms.Button btnCariGrupSil;
        private System.Windows.Forms.Button btnCariGrupEkle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnvan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVergiDairesi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVergiNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTCNo;
        private System.Windows.Forms.TextBox txtTCNo;
        private System.Windows.Forms.Label lblTCNo;
    }
}