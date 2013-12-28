﻿using System;
using System.Windows.Forms;
using FrameWork.EnumLst;
namespace FrameWork
{

    partial class AcisToolBar
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

        #region Component Designer generated code


        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {

            this.Btn_New = new System.Windows.Forms.ToolStripButton();
            this.Btn_Save = new System.Windows.Forms.ToolStripButton();
            this.Btn_Edit = new System.Windows.Forms.ToolStripButton();
            this.Btn_Delete = new System.Windows.Forms.ToolStripButton();
            this.Btn_Refresh = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_Print = new System.Windows.Forms.ToolStripButton();
            this.Btn_Search = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_First = new System.Windows.Forms.ToolStripButton();
            this.Btn_Next = new System.Windows.Forms.ToolStripButton();
            this.Btn_Previous = new System.Windows.Forms.ToolStripButton();
            this.Btn_Last = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_Language = new System.Windows.Forms.ToolStripButton();
            this.Btn_ReSize = new System.Windows.Forms.ToolStripButton();
            this.Btn_Close = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_Sort = new System.Windows.Forms.ToolStripButton();

            this.SuspendLayout();
            // 
            // ToolStripButton12
            // 
            this.Btn_New.Image = global::FrameWork.Properties.Resources._new;
            this.Btn_New.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_New.Name = "ToolStripButton12";
            this.Btn_New.Click += New_Click;
            this.Btn_New.Size = new System.Drawing.Size(36, 197);
            this.Btn_New.Text = "جديد";


            this.Btn_New.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ToolStripButton1
            // 
            this.Btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Save.Image = global::FrameWork.Properties.Resources.save;
            this.Btn_Save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Save.ImageTransparentColor = System.Drawing.Color.DarkViolet;
            this.Btn_Save.Name = "ToolStripButton1";
            this.Btn_Save.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.Btn_Save.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Btn_Save.Size = new System.Drawing.Size(56, 197);
            this.Btn_Save.Text = "حفظ";
            this.Btn_Save.Click += Save_Click;
            this.Btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ToolStripButton2
            // 
            this.Btn_Edit.Image = global::FrameWork.Properties.Resources.edit;
            this.Btn_Edit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Edit.Name = "ToolStripButton2";
            this.Btn_Edit.Size = new System.Drawing.Size(36, 197);
            this.Btn_Edit.Click += Edit_Click;
            this.Btn_Edit.Text = "تعديل";
            this.Btn_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ToolStripButton3
            // 
            this.Btn_Delete.Image = global::FrameWork.Properties.Resources.delete;
            this.Btn_Delete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Delete.Name = "ToolStripButton3";
            this.Btn_Delete.Size = new System.Drawing.Size(36, 197);
            this.Btn_Delete.Text = "حذف";
            this.Btn_Delete.Click += Delete_Click;
            this.Btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ToolStripButton13
            // 
            this.Btn_Refresh.Image = global::FrameWork.Properties.Resources.refresh;
            this.Btn_Refresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Refresh.Name = "ToolStripButton13";
            this.Btn_Refresh.Size = new System.Drawing.Size(39, 197);
            this.Btn_Refresh.Click += Refresh_Click;
            this.Btn_Refresh.Text = "تحديث";
            this.Btn_Refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 200);
            // 
            // ToolStripButton4
            // 
            this.Btn_Print.Image = global::FrameWork.Properties.Resources.print;
            this.Btn_Print.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Print.Name = "ToolStripButton4";
            this.Btn_Print.Size = new System.Drawing.Size(39, 197);
            this.Btn_Print.Text = "طباعة";
            this.Btn_Print.Click += Print_Click;
            this.Btn_Print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ToolStripButton5
            // 
            this.Btn_Search.Image = global::FrameWork.Properties.Resources.search;
            this.Btn_Search.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Search.Name = "ToolStripButton5";
            this.Btn_Search.Size = new System.Drawing.Size(30, 97);
            this.Btn_Search.Text = "بحث";
            this.Btn_Search.Click += Search_Click;
            this.Btn_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 100);
            // 
            // ToolStripButton6
            // 
            this.Btn_First.Image = global::FrameWork.Properties.Resources.last;
            this.Btn_First.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_First.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_First.Name = "ToolStripButton6";
            this.Btn_First.Size = new System.Drawing.Size(33, 97);
            this.Btn_First.Text = "الاول";
            this.Btn_First.Click += First_Click;
            this.Btn_First.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ToolStripButton7
            // 
            this.Btn_Next.Image = global::FrameWork.Properties.Resources.prev;
            this.Btn_Next.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Next.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Next.Name = "ToolStripButton7";
            this.Btn_Next.Size = new System.Drawing.Size(38, 97);
            this.Btn_Next.Text = "التالي";
            this.Btn_Next.Click += Next_Click;
            this.Btn_Next.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ToolStripButton8
            // 
            this.Btn_Previous.Image = global::FrameWork.Properties.Resources.next;
            this.Btn_Previous.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Previous.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Previous.Name = "ToolStripButton8";
            this.Btn_Previous.Size = new System.Drawing.Size(44, 97);
            this.Btn_Previous.Text = " السابق";
            this.Btn_Previous.Click += Previous_Click;
            this.Btn_Previous.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ToolStripButton9
            // 
            this.Btn_Last.Image = global::FrameWork.Properties.Resources.first;
            this.Btn_Last.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Last.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Last.Name = "ToolStripButton9";
            this.Btn_Last.Size = new System.Drawing.Size(38, 97);
            this.Btn_Last.Click += Last_Click;
            this.Btn_Last.Text = "الاخير";
            this.Btn_Last.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 100);
            // 
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new System.Drawing.Size(6, 100);
            // 
            this.Btn_ReSize.Image = global::FrameWork.Properties.Resources.expend;
            this.Btn_ReSize.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_ReSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_ReSize.Name = "ToolStripButton17";
            this.Btn_ReSize.Size = new System.Drawing.Size(49, 97);
            this.Btn_ReSize.Text = "توسيع";
            this.Btn_ReSize.Click += Resize_Click;
            this.Btn_ReSize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;

            // ToolStripButton10

            this.Btn_Sort.Image = global::FrameWork.Properties.Resources.sorte;
            this.Btn_Sort.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Sort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Sort.Name = "ToolStripButton30";
            this.Btn_Sort.Size = new System.Drawing.Size(49, 97);
            this.Btn_Sort.Text = "ترتيب";
            this.Btn_Sort.Click += Sort_Click;
            this.Btn_Sort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            this.Btn_Language.Image = global::FrameWork.Properties.Resources.en;
            this.Btn_Language.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Language.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Language.Name = "ToolStripButton10";
            this.Btn_Language.Size = new System.Drawing.Size(49, 97);
            this.Btn_Language.Text = "English";
            this.Btn_Language.Click += Language_Click;
            this.Btn_Language.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ToolStripButton11
            // 
            this.Btn_Close.Image = global::FrameWork.Properties.Resources.exit;
            this.Btn_Close.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Btn_Close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Close.Name = "ToolStripButton11";
            this.Btn_Close.Size = new System.Drawing.Size(36, 97);
            this.Btn_Close.Text = "خروج";
            this.Btn_Close.Click += Close_Click;
            this.Btn_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // AcisToolBar
            // 
            this.BackColor = System.Drawing.Color.Silver;
            this.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.BackgroundImage = global ::FrameWork.Properties.Resources.menubackground;
            this.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_New,
            this.Btn_Save,
            this.Btn_Edit,
            this.Btn_Delete,
            this.ToolStripSeparator4,
            this.Btn_Refresh,
            this.Btn_Sort,
            this.ToolStripSeparator1,
            this.Btn_Print,
            this.Btn_Search,
            this.ToolStripSeparator2,
            this.Btn_First,
            this.Btn_Previous,
            this.Btn_Next,
            this.Btn_Last,
            this.ToolStripSeparator3,
            this.Btn_ReSize,
            this.Btn_Language,
            this.Btn_Close});
            this.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(300, 200);
            this.TabIndex = 12;
            this.Text = "AcisToolBar";
            this.Dock = DockStyle.Top;
            this.ResumeLayout(false);


        }

        #region EventsVoid
        void New_Click(object sender, EventArgs e)
        {
            if (OnNewClick != null)
            {
                OnNewClick(sender, e);
            }
        }
        void Save_Click(object sender, EventArgs e)
        {
            if (OnSaveClick != null)
            {
                OnSaveClick(sender, e);
            }
        }

        void Edit_Click(object sender, EventArgs e)
        {
            if (OnEditClick != null)
            {
                OnEditClick(sender, e);
            }
        }

        void Delete_Click(object sender, EventArgs e)
        {
            if (OnDeleteClick != null)
            {
                OnDeleteClick(sender, e);
            }
        }

        void Refresh_Click(object sender, EventArgs e)
        {
            if (OnRefreshClick != null)
            {
                OnRefreshClick(sender, e);
            }
        }

        void Print_Click(object sender, EventArgs e)
        {
            if (OnPrintClick != null)
            {
                OnPrintClick(sender, e);
            }
        }

        void Search_Click(object sender, EventArgs e)
        {
            if (OnSearchClick != null)
            {
                OnSearchClick(sender, e);
            }
        }

        void First_Click(object sender, EventArgs e)
        {
            if (OnFirstClick != null)
            {
                OnFirstClick(sender, e);
            }
        }

        void Next_Click(object sender, EventArgs e)
        {
            if (OnNextClick != null)
            {
                OnNextClick(sender, e);
            }
        }


        void Previous_Click(object sender, EventArgs e)
        {
            if (OnPreviousClick != null)
            {
                OnPreviousClick(sender, e);
            }
        }

        void Last_Click(object sender, EventArgs e)
        {
            if (OnLastClick != null)
            {
                OnLastClick(sender, e);
            }
        }

        void Language_Click(object sender, EventArgs e)
        {
            if (OnLanguageClick != null)
            {
                OnLanguageClick(sender, e);
            }
        }

        void Sort_Click(object sender, EventArgs e)
        {


            if (OnSortClick != null)
            {
                OnSortClick(sender, e);
            }
            if (Sort == SortType.Asc)
                Sort = SortType.Desc;
            else
                Sort = SortType.Asc;
        }

        void Resize_Click(object sender, EventArgs e)
        {
            #region SetResizeCaption
            switch (((ToolStripButton)sender).Text)
            {
                case "Expand":
                    Btn_ReSize.Text = "Collapse";

                    break;

                case "Collapse":
                    Btn_ReSize.Text = "Expand";

                    break;
                case "توسيع":
                    Btn_ReSize.Text = "تصغير";

                    break;
                case "تصغير":
                    Btn_ReSize.Text = "توسيع";

                    break;
                default:
                    break;
            }


            #endregion

            if (OnResizeClick != null)
            {
                OnResizeClick(sender, e);
            }
        }
        void Close_Click(object sender, EventArgs e)
        {
            if (OnCloseClick != null)
            {
                OnCloseClick(sender, e);
            }
        }


        #endregion



        public System.Windows.Forms.ToolStripButton Btn_New;
        public System.Windows.Forms.ToolStripButton Btn_Save;
        public System.Windows.Forms.ToolStripButton Btn_Edit;
        public System.Windows.Forms.ToolStripButton Btn_Delete;
        public System.Windows.Forms.ToolStripButton Btn_Refresh;
        public System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        public System.Windows.Forms.ToolStripButton Btn_Print;
        public System.Windows.Forms.ToolStripButton Btn_Search;
        public System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        public System.Windows.Forms.ToolStripButton Btn_First;
        public System.Windows.Forms.ToolStripButton Btn_Next;
        public System.Windows.Forms.ToolStripButton Btn_Previous;
        public System.Windows.Forms.ToolStripButton Btn_Last;
        public System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        public System.Windows.Forms.ToolStripButton Btn_ReSize;
        public System.Windows.Forms.ToolStripButton Btn_Language;
        public System.Windows.Forms.ToolStripButton Btn_Close;
        public System.Windows.Forms.ToolStripSeparator ToolStripSeparator4;
        public System.Windows.Forms.ToolStripButton Btn_Sort;



        #region EventToolStrip
        public event EventHandler OnNewClick;
        public event EventHandler OnSaveClick;
        public event EventHandler OnEditClick;
        public event EventHandler OnDeleteClick;
        public event EventHandler OnRefreshClick;
        public event EventHandler OnPrintClick;
        public event EventHandler OnSearchClick;
        public event EventHandler OnFirstClick;
        public event EventHandler OnNextClick;
        public event EventHandler OnPreviousClick;
        public event EventHandler OnLastClick;
        public event EventHandler OnLanguageClick;
        public event EventHandler OnCloseClick;
        public event EventHandler OnResizeClick;
        public event EventHandler OnSortClick;
        #endregion




        #endregion
    }
}
