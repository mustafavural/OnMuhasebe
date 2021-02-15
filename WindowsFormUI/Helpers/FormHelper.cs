using System;
using System.Windows.Forms;

namespace WindowsFormUI.Helpers
{
    public class PageInfo
    {
        public Form Form { get; }
        //public DocumentManager DocManager { get; }
        public Type Tip { get; }
        public object[] Args { get; }

        //public PageInfo(Form form, DocumentManager docManager, Type tip, object[] args = null)
        //{
        //    Form = form;
        //    DocManager = docManager;
        //    Tip = tip;
        //    Args = args;
        //}

        public PageInfo(Type tip, object[] args = null)
        {
            Args = args;
            Tip = tip;
        }
    }

    public static class FormHelper
    {
        static PageInfo _pageInfo;
        static Form GetForm() => (Form) Activator.CreateInstance(_pageInfo.Tip, _pageInfo.Args);
        static void ShowDialog() => GetForm().ShowDialog();
        static void Show() => GetForm().Show();
        //static void ShowMDI()
        //{
        //    Form frm = GetForm();
        //    bool IsOpen = false;
        //    if (_pageInfo.Form.MdiChildren.Length > 0)
        //    {
        //        foreach (var item in _pageInfo.DocManager.View.Documents)
        //        {
        //            if (frm.Text == item.Form.Text)
        //            {
        //                _pageInfo.DocManager.View.ActivateDocument(item.Form);
        //                IsOpen = true;
        //                break;
        //            }
        //        }
        //    }
        //    if (!IsOpen)
        //    {
        //        frm.MdiParent = _pageInfo.Form;
        //        frm.Show();
        //    }
        //}

        //static void ValidationCheckIfFormExists(PageInfo pageInfo)
        //{
        //    if (pageInfo.Form == null)
        //        throw new ArgumentNullException("Form", "Form nesnesi eksik");
        //}

        //static void ValidationCheckIfDocManagerExists(PageInfo pageInfo)
        //{
        //    if (pageInfo.DocManager == null)
        //        throw new ArgumentNullException("DocManager", "DocumentManger nesnesi eksik");
        //}

        /// <summary>
        /// Modul pencerelerini açmak için kullanılır. Parametre olarak form nesnesi ve documentmanager nesnesi vermek zorunludur.
        /// </summary>
        /// <param name="pageInfo"></param>
        /// <exception cref="ArgumentNullException">Form veya DocumentManager nesneleri eksik ise fırlatılır.</exception>
        //public static void ModulAc(PageInfo pageInfo)
        //{
        //    ValidationCheckIfFormExists(pageInfo);
        //    ValidationCheckIfDocManagerExists(pageInfo);


        //    _pageInfo = pageInfo;
        //    ShowMDI();
        //}

        public static void DialogAc(PageInfo pageInfo)
        {
            _pageInfo = pageInfo;
            ShowDialog();
        }
        public static void FormAc(PageInfo pageInfo)
        {
            _pageInfo = pageInfo;
            Show();
        }
    }
}