using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Windows.Forms;

namespace WinFormsUI.View.UIComponents
{
    public class BTNBelgeNo : ButtonEdit
    {
        private void InitializeComponent()
        {
            this.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.Location = new System.Drawing.Point(59, 30);
            this.Name = "btnBelgeNo";
            this.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton() });
            this.Size = new System.Drawing.Size(100, 20);
            this.TabIndex = 0;
            this.Tag = "Fatura.frmListe";
            this.ButtonClick += new ButtonPressedEventHandler(this.btnBelgeNo_ButtonClick);
            this.KeyPress += new KeyPressEventHandler(this.btnBelgeNo_KeyPress);
            this.Leave += new EventHandler(this.btnBelgeNo_OnLeave);
        }

        public BTNBelgeNo()
        {
            InitializeComponent();
        }

        private void btnBelgeNo_ButtonClick(object sender, ButtonPressedEventArgs e)
        {

        }

        private void btnBelgeNo_OnLeave(object sender, EventArgs e)
        {
            if (this.Text == "")
            {
                MessageBox.Show("Belge No boş geçilemez...");
                this.Focus();
            }
        }

        private void btnBelgeNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextEdit txt = (TextEdit)sender;
            if (txt.Text.Length >= 12)
                e.Handled = e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete;
        }
    }
}