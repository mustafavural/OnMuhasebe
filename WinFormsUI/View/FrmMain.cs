using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using System;
using WinFormsUI.Helpers;

namespace WinFormsUI.View
{
    public partial class FrmMain : RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BarBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            var modul = e.Item.Tag.ToString();
            Type tip = Type.GetType("WinFormsUI.View.Moduller." + modul);
            FormHelper.ModulAc(new PageInfo(this, docManModulYonetim, tip));
        }
    }
}