using System;
using System.Windows.Forms;

namespace WinFormsUI.View.UserControls
{
    public partial class InformationSetupDialogForm : FrmBase
    {
        public string Info { get; set; }
        public InformationSetupDialogForm()
        {
            InitializeComponent();
        }

        public InformationSetupDialogForm(string text, string caption, string info)
        {
            InitializeComponent();
            lblInfo.Text = text;
            this.Text = caption;
            txtInfo.Text = info;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Info = txtInfo.Text;
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Info = null;
            this.Close();
        }
    }
}