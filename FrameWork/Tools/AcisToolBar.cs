using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel.Design;
using System.Data.Linq;
using System.Linq.Expressions;
using FrameWork.EnumLst;

namespace FrameWork
{
    [ToolboxItem(true)]
    [ToolboxBitmap(typeof(ToolStrip))]
    public partial class AcisToolBar : ToolStrip
    {
        public Mode CurrentMode;
        public AcisToolBar()
        {

            InitializeComponent();
            SetMode(Mode.New);
            Btn_New.DisplayStyle = ToolStripItemDisplayStyle.Image;
            
            Btn_Save.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Edit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Delete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Refresh.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Print.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Search.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_First.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Next.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Previous.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Last.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Language.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_ReSize.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Close.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Sort.DisplayStyle = ToolStripItemDisplayStyle.Image;
        
               }


        public Bol.Permission CurrentPermissionToolBar = new Bol.Permission();

        protected override void OnRightToLeftChanged(EventArgs e)
        {
            base.OnRightToLeftChanged(e);
            if (RightToLeft == System.Windows.Forms.RightToLeft.Yes)
            {
                #region ChangeText
                Btn_New.Text = "جديد";
                Btn_Edit.Text = "تعديل";
                Btn_Delete.Text = "حذف";
                Btn_Save.Text = "حفظ";
                Btn_Refresh.Text = "تحديث";
                Btn_Search.Text = "بحث";
                Btn_Print.Text = "طباعة";
                Btn_First.Text = "الاول";
                Btn_Next.Text = "التالى";
                Btn_Previous.Text = "السابق";
                Btn_Last.Text = "الاخير";
                Btn_Sort.Text = "ترتيب";
                if (Btn_ReSize.Text == "Expand")
                {
                    Btn_ReSize.Text = "توسيع";
                }
                else if (Btn_ReSize.Text == "Collapse")
                {
                    Btn_ReSize.Text = "تصغير";
                }
                else
                {
                    Btn_ReSize.Text = "توسيع";
                }

                Btn_Language.Text = "English";
                Btn_Close.Text = "خروج";

                #endregion
                #region ChangeImage
                Btn_Language.Image = global::FrameWork.Properties.Resources.en;
                Btn_First.Image = global::FrameWork.Properties.Resources.last;
                Btn_Next.Image = global ::FrameWork.Properties.Resources.prev;
                Btn_Previous.Image = global::FrameWork.Properties.Resources.next;
                Btn_Last.Image = global::FrameWork.Properties.Resources.first;
                #endregion
            }

            else
            {
                #region ChangeText
                Btn_New.Text = "New";
                Btn_Edit.Text = "Edit";
                Btn_Delete.Text = "Delete";
                Btn_Save.Text = "Save";
                Btn_Search.Text = "Search";
                Btn_Refresh.Text = "Refresh";
                Btn_Print.Text = "Print";
                Btn_First.Text = "First";
                Btn_Next.Text = "Next";
                Btn_Previous.Text = "Previous";
                Btn_Last.Text = "Last";
                Btn_Sort.Text = "Sort";
                if (Btn_ReSize.Text == "توسيع")
                {
                    Btn_ReSize.Text = "Expand";
                }
                else if (Btn_ReSize.Text == "تصغير")
                {
                    Btn_ReSize.Text = "Collapse";
                }
                else
                {
                    Btn_ReSize.Text = "Expand";
                }
                Btn_Language.Text = "عربي";
                Btn_Close.Text = "Exit";
                #endregion
                #region ChangeImage
                Btn_Language.Image = global::FrameWork.Properties.Resources.ar;
                Btn_First.Image = global::FrameWork.Properties.Resources.first;
                Btn_Next.Image = global ::FrameWork.Properties.Resources.next;
                Btn_Previous.Image = global::FrameWork.Properties.Resources.prev;
                Btn_Last.Image = global::FrameWork.Properties.Resources.last;
                #endregion
            }
        }

        public void SetPermission<T>(T CurrentPermission)
        {
            SetPermissionBol<T>(CurrentPermission);
            Btn_New.Enabled = CurrentPermissionToolBar.Save;
            Btn_Save.Enabled = CurrentPermissionToolBar.Save;
            Btn_Edit.Enabled = CurrentPermissionToolBar.Edit;
            Btn_Delete.Enabled = CurrentPermissionToolBar.Delete;
            Btn_Print.Enabled = CurrentPermissionToolBar.Print;
            Btn_Search.Enabled = CurrentPermissionToolBar.View;
            Btn_First.Enabled = CurrentPermissionToolBar.View;
            Btn_Next.Enabled = CurrentPermissionToolBar.View;
            Btn_Previous.Enabled = CurrentPermissionToolBar.View;
            Btn_Last.Enabled = CurrentPermissionToolBar.View;

            SetMode(Mode.New);
        }

        private void SetPermissionBol<T>(T CurrentPermission)
        {

            Type Current = typeof(T);
            CurrentPermissionToolBar.Save = Current.GetProperty("PrivilegeSave").GetValue(CurrentPermission, null).AsBool();
            CurrentPermissionToolBar.Edit = Current.GetProperty("PrivilegeEdit").GetValue(CurrentPermission, null).AsBool();
            CurrentPermissionToolBar.Delete = Current.GetProperty("PrivilegeDelete").GetValue(CurrentPermission, null).AsBool();
            CurrentPermissionToolBar.Print = Current.GetProperty("PrivilegePrint").GetValue(CurrentPermission, null).AsBool();
            CurrentPermissionToolBar.View = Current.GetProperty("PrivilegeBrowse").GetValue(CurrentPermission, null).AsBool();
        }

        public void SortGrid<T>(ref DataGridView CurrentGrid, EnumLst.Languages CurrentLanguage, string ColNameAr, string ColNameEn = "")
        {
            Type Cls = typeof(T);
            if (Sort == SortType.Asc)
            {
                if (CurrentLanguage == EnumLst.Languages.Arabic)
                {
                    CurrentGrid.DataSource = ((List<T>)CurrentGrid.DataSource).OrderBy(x => Cls.GetProperty(ColNameAr).GetValue(x, null)).ToList();
                }
                else
                {
                    if (!string.IsNullOrEmpty(ColNameEn))
                    {
                        CurrentGrid.DataSource = ((List<T>)CurrentGrid.DataSource).OrderBy(x => Cls.GetProperty(ColNameEn).GetValue(x, null)).ToList();

                    }
                }
            }

            else
            {
                if (CurrentLanguage == EnumLst.Languages.Arabic)
                {
                    CurrentGrid.DataSource = ((List<T>)CurrentGrid.DataSource).OrderByDescending(x => Cls.GetProperty(ColNameAr).GetValue(x, null)).ToList();
                }
                else
                {
                    if (!string.IsNullOrEmpty(ColNameEn))
                    {
                        CurrentGrid.DataSource = ((List<T>)CurrentGrid.DataSource).OrderByDescending(x => Cls.GetProperty(ColNameEn).GetValue(x, null)).ToList();

                    }
                }
            }
        }

        public void SetMode(Mode ThistMode)
        {
            CurrentMode = ThistMode;
            switch (CurrentMode)
            {
                case Mode.New:
                    if (CurrentPermissionToolBar.Save)
                    {
                        Btn_Save.Enabled = true;
                    }
                    Btn_Edit.Enabled = false;
                    Btn_Delete.Enabled = false;
                    if (dataMode == DataMode.TransactionData)
                        Btn_Print.Enabled = false;

                    break;

                case Mode.Read:
                    Btn_Save.Enabled = false;
                    if (CurrentPermissionToolBar.Edit)
                    {
                        Btn_Edit.Enabled = true;
                    }
                    if (CurrentPermissionToolBar.Delete)
                    {
                        Btn_Delete.Enabled = true;
                    }
                    if (CurrentPermissionToolBar.Print)
                    {
                        Btn_Print.Enabled = true;
                    }
                    break;

                case Mode.search:
                    foreach (var item in this.Items)
                    {
                        if (item is ToolStripItem)
                            ((ToolStripItem)item).Visible = false;
                    }

                    Btn_Search.Visible = true;
                    Btn_Language.Visible = true;
                    Btn_Sort.Visible = true;
                    Btn_Refresh.Visible = true;
                    Btn_Print.Visible = true;
                    Btn_Close.Visible = true;
                    this.ToolStripSeparator1.Visible = true;
                    this.ToolStripSeparator2.Visible = true;
                    break;
                case Mode.SearchWithExtend:
                    foreach (var item in this.Items)
                    {
                        if (item is ToolStripItem)
                            ((ToolStripItem)item).Visible = false;
                    }

                    Btn_Search.Visible = true;
                    Btn_Language.Visible = true;
                    Btn_Sort.Visible = true;
                    Btn_Refresh.Visible = true;
                    Btn_First.Visible = true;
                    Btn_Next.Visible = true;
                    Btn_Previous.Visible = true;
                    Btn_Last.Visible = true;
                    Btn_Print.Visible = true;
                    Btn_ReSize.Visible = true;
                    Btn_Close.Visible = true;
                    this.ToolStripSeparator1.Visible = true;
                    this.ToolStripSeparator2.Visible = true;
                    this.ToolStripSeparator3.Visible = true;
                    break;
                case Mode.SaveOnly:
                    foreach (var item in this.Items)
                    {
                        if (item is ToolStripItem)
                            ((ToolStripItem)item).Visible = false;
                    }
                    Btn_Save.Visible = true;
                    Btn_Language.Visible = true;
                    Btn_Refresh.Visible = true;
                    Btn_Close.Visible = true;
                    Btn_ReSize.Visible = true;
                    this.ToolStripSeparator2.Visible = true;
                    break;
                case Mode.SaveAndSearch:
                    foreach (var item in this.Items)
                    {
                        if (item is ToolStripItem)
                            ((ToolStripItem)item).Visible = false;
                    }
                    Btn_Save.Visible = true;
                    Btn_Language.Visible = true;
                    Btn_Refresh.Visible = true;
                    Btn_Search.Visible = true;
                    Btn_Close.Visible = true;
                    Btn_ReSize.Visible = true;
                    this.ToolStripSeparator2.Visible = true;
                    break;
                case Mode.Print:
                    foreach (var item in this.Items)
                    {
                        if (item is ToolStripItem)
                            ((ToolStripItem)item).Visible = false;
                    }
                    Btn_New.Visible = true;
                    Btn_Sort.Visible = true;
                    Btn_Print.Visible = true;
                    Btn_Search.Visible = true;
                    Btn_Language.Visible = true;
                    Btn_Close.Visible = true;
                    Btn_ReSize.Visible = true;
                    Btn_Refresh.Visible = true;
                    this.ToolStripSeparator1.Visible = true;
                    this.ToolStripSeparator2.Visible = true;
                    this.ToolStripSeparator4.Visible = true;
                    break;
                default:
                    break;
            }

        }

        private SortType _sort = SortType.Asc;

        public SortType Sort
        {
            get { return _sort; }
            set { _sort = value; }
        }

        private DataMode _dataMode = DataMode.TransactionData;

        public DataMode dataMode
        {
            get { return _dataMode; }
            set
            {
                if (value == DataMode.TransactionData)
                    Btn_Print.Enabled = false;
                else
                    Btn_Print.Enabled = true;

                _dataMode = value;
            }
        }







    }


}
