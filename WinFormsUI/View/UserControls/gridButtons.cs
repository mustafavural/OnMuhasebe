using System;
using System.Windows.Forms;

namespace WinFormsUI.View.UserControls
{
    public partial class gridButtons : UserControl
    {
        public gridButtons()
        {
            InitializeComponent();
            this.Dock = DockStyle.Bottom;

            this.btnClear.Click += (o, e) => { this.clickClear?.Invoke(o, e); };
            this.btnCancel.Click += (o, e) => { this.clickCancel?.Invoke(o, e); };
            this.btnSave.Click += (o, e) => { this.clickSave?.Invoke(o, e); };
        }

        public event EventHandler clickClear;
        public event EventHandler clickSave;
        public event EventHandler clickCancel;

        public string btnCancel_Text { get { return btnCancel.Text; } set { btnCancel.Text = value; } }

        public bool btnTemizleVisible { get { return btnClear.Visible; } set { btnClear.Visible = value; } }

        public bool btnCancelEnable { get { return btnClear.Enabled; } set { btnCancel.Enabled = value; } }

        public bool btnSaveEnable { get { return btnSave.Enabled; } set { btnSave.Enabled = value; } }
    }
}