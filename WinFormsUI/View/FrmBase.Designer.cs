
namespace WinFormsUI.View
{
    partial class FrmBase
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
            this.btnBaseClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBaseClose
            // 
            this.btnBaseClose.Location = new System.Drawing.Point(-10, -10);
            this.btnBaseClose.Name = "btnBaseClose";
            this.btnBaseClose.Size = new System.Drawing.Size(5, 5);
            this.btnBaseClose.TabIndex = 0;
            this.btnBaseClose.Visible = false;
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 332);
            this.Controls.Add(this.btnBaseClose);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBase";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmBase";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnBaseClose;
    }
}