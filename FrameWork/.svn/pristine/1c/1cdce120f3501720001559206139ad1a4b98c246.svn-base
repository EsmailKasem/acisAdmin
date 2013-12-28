using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Management;
using System.Windows.Forms;
using FrameWork.CustomeAttribute;

namespace FrameWork
{
    [ToolboxItem(true)]
    [ToolboxBitmap(typeof(StatusBar))]
    public partial class AcisStatusBar : StatusStrip
    {

        protected override void InitLayout()
        {
            base.InitLayout();
            Lbl_Language_Dt.Text = InputLanguage.CurrentInputLanguage.Culture.TwoLetterISOLanguageName.ToUpper();
            try
            {
                Form frm = (Form)this.Parent;
                frm.InputLanguageChanged += new InputLanguageChangedEventHandler(frm_InputLanguageChanged);
            }
            catch (System.Exception ex)
            {
                if (System.Diagnostics.Debugger.IsAttached)
                {
                    throw new System.Exception();
                }

                ExceptionHelper.SaveExceptionLog(ex, System.Reflection.MethodBase.GetCurrentMethod());

            }
            this.Dock = DockStyle.Bottom;

        }

        public AcisStatusBar()
        {
            InitializeComponent();
            
        }



        void frm_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {
            Lbl_Language_Dt.Text = e.InputLanguage.Culture.TwoLetterISOLanguageName.ToUpper();
        }

        #region Prop

        private int _recordCount;

        public int RecordCount
        {
            get { return _recordCount; }
            set
            {
                _recordCount = value;
                Lbl_RecordCount_Dt.Text = _recordCount.ToString();

            }
        }

        private string _username = "Esmail";

        public string UserName
        {
            get { return _username; }
            set
            {
                _username = value;
                Lbl_UserName_Dt.Text = _username;
            }
        }


        private StatusMode _mode = StatusMode.Insert;

        public StatusMode ModeBar
        {
            get { return _mode; }
            set
            {
                _mode = value;
                if (RightToLeft == System.Windows.Forms.RightToLeft.No)
                    Lbl_Mode_Dt.Text = CaptionAttribute.GetEnglishCatpion(_mode);
                else
                    Lbl_Mode_Dt.Text = CaptionAttribute.GetArabicCatpion(_mode);

            }
        }

        private string _language;

        public string Language
        {
            get { return _language; }
            set
            {
                _language = value;
                Lbl_Language_Dt.Text = _language;

            }
        }





        #endregion


        #region EnumList

        public enum StatusMode
        {
            [Caption("Stand By", "إستعداد")]
            StandBy = 0,
            [Caption("Insert", "إدخال")]
            Insert = 1

        }


        #endregion



        private void statusStrip1_RightToLeftChanged(object sender, EventArgs e)
        {
            if (RightToLeft == System.Windows.Forms.RightToLeft.No)
            {
                Lbl_RecordCount.Text = "Record Count";
                //Lbl_UserName.Text = "User Name";
                Lbl_Mode.Text = "Mode";
                Lbl_Mode_Dt.Text = CaptionAttribute.GetEnglishCatpion(ModeBar); //Enum.GetName(typeof(StatusMode), _mode);
                //  Lbl_Lang.Text = "Language";
                //  Lbl_Language_Dt.Text = "EN";
            }
            else if (RightToLeft == System.Windows.Forms.RightToLeft.Yes)
            {
                ModeBar = StatusMode.StandBy;
                Lbl_RecordCount.Text = "عدد السجلات";
                // Lbl_UserName.Text = "إسم المستخدم";
                Lbl_Mode.Text = "الحالة";

                Lbl_Mode_Dt.Text = CaptionAttribute.GetArabicCatpion(ModeBar);

                //  Lbl_Lang.Text = "اللغه";
                // Lbl_Language_Dt.Text = "AR";
            }
        }

    }
}
