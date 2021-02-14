
namespace WinFormsUI.View.UserControls
{
    partial class InformationSetupDialogForm
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
            this.txtInfo = new DevExpress.XtraEditors.TextEdit();
            this.lblInfo = new DevExpress.XtraEditors.LabelControl();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtInfo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBaseClose
            // 
            this.btnBaseClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBaseClose.FlatAppearance.BorderSize = 0;
            this.btnBaseClose.Location = new System.Drawing.Point(-121, -30);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(12, 31);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(248, 20);
            this.txtInfo.TabIndex = 1;
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(12, 12);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(72, 13);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Açıklama Girin :";
            // 
            // btnOk
            // 
            this.btnOk.ImageOptions.Image = global::WinFormsUI.Properties.Resources.Kaydet24x24;
            this.btnOk.Location = new System.Drawing.Point(114, 67);
            this.btnOk.Name = "btnOk";
            this.btnOk.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnOk.Size = new System.Drawing.Size(70, 34);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Tamam";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = global::WinFormsUI.Properties.Resources.Sil24x24;
            this.btnCancel.Location = new System.Drawing.Point(190, 67);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnCancel.Size = new System.Drawing.Size(70, 34);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "İptal";
            this.btnCancel.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // InformationSetupDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 113);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtInfo);
            this.IconOptions.Image = global::WinFormsUI.Properties.Resources.Fatura_Alis16x16;
            this.Name = "InformationSetupDialogForm";
            this.Text = "InformationSetupDialogForm";
            this.Controls.SetChildIndex(this.btnBaseClose, 0);
            this.Controls.SetChildIndex(this.txtInfo, 0);
            this.Controls.SetChildIndex(this.lblInfo, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.txtInfo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtInfo;
        private DevExpress.XtraEditors.LabelControl lblInfo;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}