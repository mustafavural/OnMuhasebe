using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.ComponentModel;
using System.Drawing;

namespace WinformUI.UserControls
{
    public class BaseGridControl : GridControl
    {
        private GridView _gridView1 = new GridView();
        private GridColumn _colid = new GridColumn();
        private GridColumn _colKod = new GridColumn();
        private GridColumn _colAd = new GridColumn();
        private GridColumn _colAciklama = new GridColumn();
        public BaseGridControl()
        {
            ((ISupportInitialize)(this)).BeginInit();
            ((ISupportInitialize)(this._gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCtrlStokGrupKod
            // 
            this.Location = new Point(285, 82);
            this.MainView = this._gridView1;
            this.Name = "BaseGridControl";
            this.Size = new Size(409, 245);
            this.TabIndex = 2;
            this.ViewCollection.AddRange(new BaseView[] {
            this._gridView1
            });
            // 
            // gridView1
            // 
            this._gridView1.Columns.AddRange(new GridColumn[] {
            this._colid,
            this._colKod,
            this._colAd,
            this._colAciklama});
            this._gridView1.GridControl = this;
            this._gridView1.Name = "GridView";
            this._gridView1.OptionsBehavior.AllowAddRows = DefaultBoolean.False;
            this._gridView1.OptionsBehavior.AllowDeleteRows = DefaultBoolean.False;
            this._gridView1.OptionsBehavior.CacheValuesOnRowUpdating = CacheRowValuesMode.Disabled;
            this._gridView1.OptionsBehavior.ReadOnly = true;
            this._gridView1.OptionsCustomization.AllowFilter = false;
            this._gridView1.OptionsCustomization.AllowGroup = false;
            this._gridView1.OptionsMenu.EnableColumnMenu = false;
            this._gridView1.OptionsMenu.EnableFooterMenu = false;
            this._gridView1.OptionsMenu.EnableGroupPanelMenu = false;
            this._gridView1.OptionsMenu.ShowGroupSortSummaryItems = false;
            this._gridView1.OptionsView.ShowGroupPanel = false;
            this._gridView1.SortInfo.AddRange(new GridColumnSortInfo[] {
            new GridColumnSortInfo(this._colKod, ColumnSortOrder.Ascending)});
            // 
            // colid
            // 
            this._colid.Caption = "Id";
            this._colid.FieldName = "Id";
            this._colid.Name = "colid";
            this._colid.OptionsColumn.AllowEdit = false;
            this._colid.OptionsColumn.AllowGroup = DefaultBoolean.False;
            this._colid.OptionsColumn.AllowShowHide = false;
            this._colid.OptionsColumn.AllowSort = DefaultBoolean.False;
            this._colid.Width = 102;
            // 
            // colKod
            // 
            this._colKod.Caption = "Kodu";
            this._colKod.FieldName = "No";
            this._colKod.Name = "colKod";
            this._colKod.OptionsColumn.AllowEdit = false;
            this._colKod.OptionsColumn.AllowGroup = DefaultBoolean.False;
            this._colKod.OptionsColumn.AllowShowHide = false;
            this._colKod.OptionsColumn.AllowSort = DefaultBoolean.False;
            this._colKod.OptionsColumn.FixedWidth = true;
            this._colKod.Visible = true;
            this._colKod.VisibleIndex = 0;
            // 
            // colAd
            // 
            this._colAd.Caption = "Adı";
            this._colAd.FieldName = "Adi";
            this._colAd.Name = "colAd";
            this._colAd.OptionsColumn.AllowEdit = false;
            this._colAd.OptionsColumn.AllowGroup = DefaultBoolean.False;
            this._colAd.OptionsColumn.AllowShowHide = false;
            this._colAd.OptionsColumn.AllowSort = DefaultBoolean.False;
            this._colAd.OptionsColumn.FixedWidth = true;
            this._colAd.Visible = true;
            this._colAd.VisibleIndex = 1;
            this._colAd.Width = 102;
            // 
            // colAciklama
            // 
            this._colAciklama.Caption = "Açıklama";
            this._colAciklama.FieldName = "Aciklama";
            this._colAciklama.Name = "colAciklama";
            this._colAciklama.OptionsColumn.AllowEdit = false;
            this._colAciklama.OptionsColumn.AllowGroup = DefaultBoolean.False;
            this._colAciklama.OptionsColumn.AllowShowHide = false;
            this._colAciklama.OptionsColumn.AllowSort = DefaultBoolean.False;
            this._colAciklama.Visible = true;
            this._colAciklama.VisibleIndex = 2;
            this._colAciklama.Width = 479;
            ((ISupportInitialize)(this._gridView1)).EndInit();
            ((ISupportInitialize)(this)).EndInit();
            this.ResumeLayout();
        }
    }
}