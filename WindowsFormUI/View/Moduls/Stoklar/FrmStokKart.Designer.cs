
namespace WindowsFormUI.View.Moduls.Stoklar
{
    partial class FrmStokKart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStokKart));
            this.grpStok = new System.Windows.Forms.GroupBox();
            this.btnStokBul = new System.Windows.Forms.Button();
            this.txtStokKDV = new System.Windows.Forms.TextBox();
            this.txtStokAd = new System.Windows.Forms.TextBox();
            this.txtStokBarkod = new System.Windows.Forms.TextBox();
            this.txtStokKod = new System.Windows.Forms.TextBox();
            this.lblStokKDV = new System.Windows.Forms.Label();
            this.lblStokAd = new System.Windows.Forms.Label();
            this.lblStokBarkod = new System.Windows.Forms.Label();
            this.lblStokKod = new System.Windows.Forms.Label();
            this.grpBirim = new System.Windows.Forms.GroupBox();
            this.txtStokOran3 = new System.Windows.Forms.TextBox();
            this.txtStokBirim3 = new System.Windows.Forms.TextBox();
            this.txtStokBirim2 = new System.Windows.Forms.TextBox();
            this.txtStokOran2 = new System.Windows.Forms.TextBox();
            this.txtStokBirim = new System.Windows.Forms.TextBox();
            this.lblStokOran3 = new System.Windows.Forms.Label();
            this.lblStokBirim3 = new System.Windows.Forms.Label();
            this.lblStokOran2 = new System.Windows.Forms.Label();
            this.lblStokBirim2 = new System.Windows.Forms.Label();
            this.lblStokBirim = new System.Windows.Forms.Label();
            this.grpGrup = new System.Windows.Forms.GroupBox();
            this.dgvGrupView = new System.Windows.Forms.DataGridView();
            this.colGrupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrupTur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrupAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGrupSil = new System.Windows.Forms.Button();
            this.btnGrupEkle = new System.Windows.Forms.Button();
            this.uscStokEkleSilButon = new WindowsFormUI.View.UserControls.UscFormButtons();
            this.dgvStokListe = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBarkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirim2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOran2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirim3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOran3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpStok.SuspendLayout();
            this.grpBirim.SuspendLayout();
            this.grpGrup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokListe)).BeginInit();
            this.SuspendLayout();
            // 
            // grpStok
            // 
            this.grpStok.Controls.Add(this.btnStokBul);
            this.grpStok.Controls.Add(this.txtStokKDV);
            this.grpStok.Controls.Add(this.txtStokAd);
            this.grpStok.Controls.Add(this.txtStokBarkod);
            this.grpStok.Controls.Add(this.txtStokKod);
            this.grpStok.Controls.Add(this.lblStokKDV);
            this.grpStok.Controls.Add(this.lblStokAd);
            this.grpStok.Controls.Add(this.lblStokBarkod);
            this.grpStok.Controls.Add(this.lblStokKod);
            this.grpStok.Controls.Add(this.grpBirim);
            this.grpStok.Controls.Add(this.grpGrup);
            this.grpStok.Controls.Add(this.uscStokEkleSilButon);
            this.grpStok.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpStok.Location = new System.Drawing.Point(0, 0);
            this.grpStok.Name = "grpStok";
            this.grpStok.Size = new System.Drawing.Size(778, 253);
            this.grpStok.TabIndex = 0;
            this.grpStok.TabStop = false;
            this.grpStok.Text = "Stok Bilgileri";
            // 
            // btnStokBul
            // 
            this.btnStokBul.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStokBul.Image = ((System.Drawing.Image)(resources.GetObject("btnStokBul.Image")));
            this.btnStokBul.Location = new System.Drawing.Point(438, 22);
            this.btnStokBul.Name = "btnStokBul";
            this.btnStokBul.Size = new System.Drawing.Size(24, 23);
            this.btnStokBul.TabIndex = 2;
            this.btnStokBul.UseVisualStyleBackColor = true;
            this.btnStokBul.Click += new System.EventHandler(this.BtnStokBul_Click);
            // 
            // txtStokKDV
            // 
            this.txtStokKDV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStokKDV.Location = new System.Drawing.Point(74, 109);
            this.txtStokKDV.Name = "txtStokKDV";
            this.txtStokKDV.Size = new System.Drawing.Size(388, 23);
            this.txtStokKDV.TabIndex = 8;
            this.txtStokKDV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HarfEngelle_KeyPress);
            // 
            // txtStokAd
            // 
            this.txtStokAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStokAd.Location = new System.Drawing.Point(74, 80);
            this.txtStokAd.Name = "txtStokAd";
            this.txtStokAd.Size = new System.Drawing.Size(388, 23);
            this.txtStokAd.TabIndex = 6;
            // 
            // txtStokBarkod
            // 
            this.txtStokBarkod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStokBarkod.Location = new System.Drawing.Point(74, 51);
            this.txtStokBarkod.Name = "txtStokBarkod";
            this.txtStokBarkod.Size = new System.Drawing.Size(388, 23);
            this.txtStokBarkod.TabIndex = 4;
            // 
            // txtStokKod
            // 
            this.txtStokKod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStokKod.Location = new System.Drawing.Point(74, 22);
            this.txtStokKod.Name = "txtStokKod";
            this.txtStokKod.Size = new System.Drawing.Size(358, 23);
            this.txtStokKod.TabIndex = 1;
            this.txtStokKod.Leave += new System.EventHandler(this.TxtStokKod_Leave);
            // 
            // lblStokKDV
            // 
            this.lblStokKDV.AutoSize = true;
            this.lblStokKDV.Location = new System.Drawing.Point(39, 112);
            this.lblStokKDV.Name = "lblStokKDV";
            this.lblStokKDV.Size = new System.Drawing.Size(29, 15);
            this.lblStokKDV.TabIndex = 7;
            this.lblStokKDV.Text = "KDV";
            // 
            // lblStokAd
            // 
            this.lblStokAd.AutoSize = true;
            this.lblStokAd.Location = new System.Drawing.Point(17, 83);
            this.lblStokAd.Name = "lblStokAd";
            this.lblStokAd.Size = new System.Drawing.Size(51, 15);
            this.lblStokAd.TabIndex = 5;
            this.lblStokAd.Text = "Stok Adı";
            // 
            // lblStokBarkod
            // 
            this.lblStokBarkod.AutoSize = true;
            this.lblStokBarkod.Location = new System.Drawing.Point(17, 54);
            this.lblStokBarkod.Name = "lblStokBarkod";
            this.lblStokBarkod.Size = new System.Drawing.Size(51, 15);
            this.lblStokBarkod.TabIndex = 3;
            this.lblStokBarkod.Text = "Barkodu";
            // 
            // lblStokKod
            // 
            this.lblStokKod.AutoSize = true;
            this.lblStokKod.Location = new System.Drawing.Point(7, 25);
            this.lblStokKod.Name = "lblStokKod";
            this.lblStokKod.Size = new System.Drawing.Size(61, 15);
            this.lblStokKod.TabIndex = 0;
            this.lblStokKod.Text = "Stok Kodu";
            // 
            // grpBirim
            // 
            this.grpBirim.Controls.Add(this.txtStokOran3);
            this.grpBirim.Controls.Add(this.txtStokBirim3);
            this.grpBirim.Controls.Add(this.txtStokBirim2);
            this.grpBirim.Controls.Add(this.txtStokOran2);
            this.grpBirim.Controls.Add(this.txtStokBirim);
            this.grpBirim.Controls.Add(this.lblStokOran3);
            this.grpBirim.Controls.Add(this.lblStokBirim3);
            this.grpBirim.Controls.Add(this.lblStokOran2);
            this.grpBirim.Controls.Add(this.lblStokBirim2);
            this.grpBirim.Controls.Add(this.lblStokBirim);
            this.grpBirim.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpBirim.Location = new System.Drawing.Point(3, 138);
            this.grpBirim.Name = "grpBirim";
            this.grpBirim.Size = new System.Drawing.Size(465, 66);
            this.grpBirim.TabIndex = 9;
            this.grpBirim.TabStop = false;
            this.grpBirim.Text = "Birimler";
            // 
            // txtStokOran3
            // 
            this.txtStokOran3.Enabled = false;
            this.txtStokOran3.Location = new System.Drawing.Point(376, 37);
            this.txtStokOran3.Name = "txtStokOran3";
            this.txtStokOran3.Size = new System.Drawing.Size(79, 23);
            this.txtStokOran3.TabIndex = 9;
            this.txtStokOran3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HarfEngelle_KeyPress);
            // 
            // txtStokBirim3
            // 
            this.txtStokBirim3.Enabled = false;
            this.txtStokBirim3.Location = new System.Drawing.Point(291, 37);
            this.txtStokBirim3.Name = "txtStokBirim3";
            this.txtStokBirim3.Size = new System.Drawing.Size(79, 23);
            this.txtStokBirim3.TabIndex = 7;
            this.txtStokBirim3.TextChanged += new System.EventHandler(this.TxtStokBirim3_TextChanged);
            // 
            // txtStokBirim2
            // 
            this.txtStokBirim2.Enabled = false;
            this.txtStokBirim2.Location = new System.Drawing.Point(109, 37);
            this.txtStokBirim2.Name = "txtStokBirim2";
            this.txtStokBirim2.Size = new System.Drawing.Size(79, 23);
            this.txtStokBirim2.TabIndex = 3;
            this.txtStokBirim2.TextChanged += new System.EventHandler(this.TxtStokBirim2_TextChanged);
            // 
            // txtStokOran2
            // 
            this.txtStokOran2.Enabled = false;
            this.txtStokOran2.Location = new System.Drawing.Point(194, 37);
            this.txtStokOran2.Name = "txtStokOran2";
            this.txtStokOran2.Size = new System.Drawing.Size(79, 23);
            this.txtStokOran2.TabIndex = 6;
            this.txtStokOran2.TextChanged += new System.EventHandler(this.TxtStokOran2_TextChanged);
            this.txtStokOran2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HarfEngelle_KeyPress);
            // 
            // txtStokBirim
            // 
            this.txtStokBirim.Location = new System.Drawing.Point(9, 37);
            this.txtStokBirim.Name = "txtStokBirim";
            this.txtStokBirim.Size = new System.Drawing.Size(79, 23);
            this.txtStokBirim.TabIndex = 1;
            this.txtStokBirim.TextChanged += new System.EventHandler(this.TxtStokBirim_TextChanged);
            // 
            // lblStokOran3
            // 
            this.lblStokOran3.AutoSize = true;
            this.lblStokOran3.Location = new System.Drawing.Point(376, 19);
            this.lblStokOran3.Name = "lblStokOran3";
            this.lblStokOran3.Size = new System.Drawing.Size(79, 15);
            this.lblStokOran3.TabIndex = 8;
            this.lblStokOran3.Text = "3. Birim Oranı";
            // 
            // lblStokBirim3
            // 
            this.lblStokBirim3.AutoSize = true;
            this.lblStokBirim3.Location = new System.Drawing.Point(291, 19);
            this.lblStokBirim3.Name = "lblStokBirim3";
            this.lblStokBirim3.Size = new System.Drawing.Size(50, 15);
            this.lblStokBirim3.TabIndex = 7;
            this.lblStokBirim3.Text = "3. Birimi";
            // 
            // lblStokOran2
            // 
            this.lblStokOran2.AutoSize = true;
            this.lblStokOran2.Location = new System.Drawing.Point(194, 19);
            this.lblStokOran2.Name = "lblStokOran2";
            this.lblStokOran2.Size = new System.Drawing.Size(79, 15);
            this.lblStokOran2.TabIndex = 4;
            this.lblStokOran2.Text = "2. Birim Oranı";
            // 
            // lblStokBirim2
            // 
            this.lblStokBirim2.AutoSize = true;
            this.lblStokBirim2.Location = new System.Drawing.Point(109, 19);
            this.lblStokBirim2.Name = "lblStokBirim2";
            this.lblStokBirim2.Size = new System.Drawing.Size(50, 15);
            this.lblStokBirim2.TabIndex = 2;
            this.lblStokBirim2.Text = "2. Birimi";
            // 
            // lblStokBirim
            // 
            this.lblStokBirim.AutoSize = true;
            this.lblStokBirim.Location = new System.Drawing.Point(9, 19);
            this.lblStokBirim.Name = "lblStokBirim";
            this.lblStokBirim.Size = new System.Drawing.Size(38, 15);
            this.lblStokBirim.TabIndex = 0;
            this.lblStokBirim.Text = "Birimi";
            // 
            // grpGrup
            // 
            this.grpGrup.Controls.Add(this.dgvGrupView);
            this.grpGrup.Controls.Add(this.btnGrupSil);
            this.grpGrup.Controls.Add(this.btnGrupEkle);
            this.grpGrup.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpGrup.Location = new System.Drawing.Point(468, 19);
            this.grpGrup.Name = "grpGrup";
            this.grpGrup.Size = new System.Drawing.Size(307, 185);
            this.grpGrup.TabIndex = 10;
            this.grpGrup.TabStop = false;
            this.grpGrup.Text = "Grup Bilgileri";
            // 
            // dgvGrupView
            // 
            this.dgvGrupView.AllowUserToAddRows = false;
            this.dgvGrupView.AllowUserToDeleteRows = false;
            this.dgvGrupView.AllowUserToResizeRows = false;
            this.dgvGrupView.BackgroundColor = System.Drawing.Color.White;
            this.dgvGrupView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGrupId,
            this.colGrupTur,
            this.colGrupAd});
            this.dgvGrupView.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvGrupView.Location = new System.Drawing.Point(3, 19);
            this.dgvGrupView.Name = "dgvGrupView";
            this.dgvGrupView.ReadOnly = true;
            this.dgvGrupView.RowHeadersVisible = false;
            this.dgvGrupView.RowTemplate.Height = 25;
            this.dgvGrupView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrupView.Size = new System.Drawing.Size(240, 163);
            this.dgvGrupView.TabIndex = 0;
            this.dgvGrupView.TabStop = false;
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
            // btnGrupSil
            // 
            this.btnGrupSil.Image = ((System.Drawing.Image)(resources.GetObject("btnGrupSil.Image")));
            this.btnGrupSil.Location = new System.Drawing.Point(258, 85);
            this.btnGrupSil.Name = "btnGrupSil";
            this.btnGrupSil.Size = new System.Drawing.Size(40, 42);
            this.btnGrupSil.TabIndex = 2;
            this.btnGrupSil.UseVisualStyleBackColor = true;
            this.btnGrupSil.Click += new System.EventHandler(this.BtnGrupSil_Click);
            // 
            // btnGrupEkle
            // 
            this.btnGrupEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnGrupEkle.Image")));
            this.btnGrupEkle.Location = new System.Drawing.Point(258, 22);
            this.btnGrupEkle.Name = "btnGrupEkle";
            this.btnGrupEkle.Size = new System.Drawing.Size(40, 45);
            this.btnGrupEkle.TabIndex = 1;
            this.btnGrupEkle.UseVisualStyleBackColor = true;
            this.btnGrupEkle.Click += new System.EventHandler(this.BtnGrupEkle_Click);
            // 
            // uscStokEkleSilButon
            // 
            this.uscStokEkleSilButon.BtnClear_Visible = true;
            this.uscStokEkleSilButon.BtnDelete_Enable = false;
            this.uscStokEkleSilButon.BtnDelete_Text = "Sil     ";
            this.uscStokEkleSilButon.BtnSave_Enable = true;
            this.uscStokEkleSilButon.BtnSave_Text = "Ekle";
            this.uscStokEkleSilButon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uscStokEkleSilButon.Location = new System.Drawing.Point(3, 204);
            this.uscStokEkleSilButon.Name = "uscStokEkleSilButon";
            this.uscStokEkleSilButon.Size = new System.Drawing.Size(772, 46);
            this.uscStokEkleSilButon.TabIndex = 11;
            this.uscStokEkleSilButon.ClickClear += new System.EventHandler(this.UscStokEkleSilButon_ClickEkraniTemizle);
            this.uscStokEkleSilButon.ClickSave += new System.EventHandler(this.UscStokEkleSilButon_ClickEkleGuncelle);
            this.uscStokEkleSilButon.ClickCancel += new System.EventHandler(this.UscStokEkleSilButon_ClickSecileniSil);
            // 
            // dgvStokListe
            // 
            this.dgvStokListe.AllowUserToAddRows = false;
            this.dgvStokListe.AllowUserToDeleteRows = false;
            this.dgvStokListe.AllowUserToResizeRows = false;
            this.dgvStokListe.BackgroundColor = System.Drawing.Color.White;
            this.dgvStokListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStokListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.colKod,
            this.colBarkod,
            this.dataGridViewTextBoxColumn2,
            this.colKDV,
            this.colBirim,
            this.colBirim2,
            this.colOran2,
            this.colBirim3,
            this.colOran3});
            this.dgvStokListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStokListe.Location = new System.Drawing.Point(0, 253);
            this.dgvStokListe.Name = "dgvStokListe";
            this.dgvStokListe.ReadOnly = true;
            this.dgvStokListe.RowHeadersVisible = false;
            this.dgvStokListe.RowTemplate.Height = 25;
            this.dgvStokListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStokListe.Size = new System.Drawing.Size(778, 184);
            this.dgvStokListe.TabIndex = 1;
            this.dgvStokListe.TabStop = false;
            this.dgvStokListe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStokListe_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // colKod
            // 
            this.colKod.DataPropertyName = "Kod";
            this.colKod.Frozen = true;
            this.colKod.HeaderText = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.ReadOnly = true;
            // 
            // colBarkod
            // 
            this.colBarkod.DataPropertyName = "Barkod";
            this.colBarkod.Frozen = true;
            this.colBarkod.HeaderText = "Barkod";
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ad";
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Ad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // colKDV
            // 
            this.colKDV.DataPropertyName = "KDV";
            this.colKDV.Frozen = true;
            this.colKDV.HeaderText = "KDV";
            this.colKDV.Name = "colKDV";
            this.colKDV.ReadOnly = true;
            // 
            // colBirim
            // 
            this.colBirim.DataPropertyName = "Birim";
            this.colBirim.Frozen = true;
            this.colBirim.HeaderText = "Birim";
            this.colBirim.Name = "colBirim";
            this.colBirim.ReadOnly = true;
            // 
            // colBirim2
            // 
            this.colBirim2.DataPropertyName = "Birim2";
            this.colBirim2.Frozen = true;
            this.colBirim2.HeaderText = "Birim2";
            this.colBirim2.Name = "colBirim2";
            this.colBirim2.ReadOnly = true;
            // 
            // colOran2
            // 
            this.colOran2.DataPropertyName = "Birim2Oran";
            this.colOran2.Frozen = true;
            this.colOran2.HeaderText = "Birim2Oran";
            this.colOran2.Name = "colOran2";
            this.colOran2.ReadOnly = true;
            // 
            // colBirim3
            // 
            this.colBirim3.DataPropertyName = "Birim3";
            this.colBirim3.Frozen = true;
            this.colBirim3.HeaderText = "Birim3";
            this.colBirim3.Name = "colBirim3";
            this.colBirim3.ReadOnly = true;
            // 
            // colOran3
            // 
            this.colOran3.DataPropertyName = "Birim3Oran";
            this.colOran3.Frozen = true;
            this.colOran3.HeaderText = "Birim3Oran";
            this.colOran3.Name = "colOran3";
            this.colOran3.ReadOnly = true;
            // 
            // FrmStokKart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 437);
            this.Controls.Add(this.dgvStokListe);
            this.Controls.Add(this.grpStok);
            this.Name = "FrmStokKart";
            this.Text = "FrmStokKart";
            this.Load += new System.EventHandler(this.FrmStokKart_Load);
            this.grpStok.ResumeLayout(false);
            this.grpStok.PerformLayout();
            this.grpBirim.ResumeLayout(false);
            this.grpBirim.PerformLayout();
            this.grpGrup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpStok;
        private System.Windows.Forms.GroupBox grpGrup;
        private UserControls.UscFormButtons uscStokEkleSilButon;
        private System.Windows.Forms.GroupBox grpBirim;
        private System.Windows.Forms.TextBox txtStokKDV;
        private System.Windows.Forms.TextBox txtStokAd;
        private System.Windows.Forms.TextBox txtStokBarkod;
        private System.Windows.Forms.TextBox txtStokKod;
        private System.Windows.Forms.Label lblStokKDV;
        private System.Windows.Forms.Label lblStokAd;
        private System.Windows.Forms.Label lblStokBarkod;
        private System.Windows.Forms.Label lblStokKod;
        private System.Windows.Forms.Label lblStokOran3;
        private System.Windows.Forms.Label lblStokBirim3;
        private System.Windows.Forms.Label lblStokOran2;
        private System.Windows.Forms.Label lblStokBirim2;
        private System.Windows.Forms.Label lblStokBirim;
        private System.Windows.Forms.Button btnStokBul;
        private System.Windows.Forms.TextBox txtStokOran3;
        private System.Windows.Forms.TextBox txtStokBirim3;
        private System.Windows.Forms.TextBox txtStokBirim2;
        private System.Windows.Forms.TextBox txtStokOran2;
        private System.Windows.Forms.TextBox txtStokBirim;
        private System.Windows.Forms.Button btnGrupSil;
        private System.Windows.Forms.Button btnGrupEkle;
        private System.Windows.Forms.DataGridView dgvStokListe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBirim;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBirim2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOran2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBirim3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOran3;
        private System.Windows.Forms.DataGridView dgvGrupView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrupTur;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrupAd;
    }
}