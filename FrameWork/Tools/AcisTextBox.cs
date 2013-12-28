using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Drawing;
using FrameWork.EnumLst;

namespace FrameWork
{
    [ToolboxItem(true)]
    [ToolboxBitmap(typeof(TextBox))]
    public partial class AcisTextBox : TextBox
    {
        private language_type language;
        public language_type Language
        {
            get
            {
                return language;
            }
            set
            {
                language = value;
                if (language == language_type.arabic)
                    this.Enter += txt_arabic;
                else if (language == language_type.english)
                    this.Enter += txt_english;
            }
        }

        private Text_Type type_text;
        public Text_Type Type_text
        {
            get { return type_text; }
            set
            {
                type_text = value;
            }
        }

        public int MaxNumber { get; set; }
        public int MinNumber { get; set; }

        private bool _moveByEnter = false;
        public bool MoveByEnter
        {
            get { return _moveByEnter; }
            set { _moveByEnter = value; }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            //if (e.KeyCode== Keys.F7)
            //{
            //    InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("en-us"));
            //}
            //if (e.KeyCode == Keys.C && e.Modifiers == Keys.Control)
            //{
            //    (this as TextBox).Copy();
            //    return;
            //}

            //if (e.KeyCode == Keys.V && e.Modifiers == Keys.Control)
            //{
            //    (this as TextBox).Paste();
            //    return;
            //}

            //if (e.KeyCode == Keys.A && e.Modifiers == Keys.Control)
            //{
            //    (this as TextBox).SelectAll();
            //    return;
            //}

            base.OnKeyDown(e);
        }
       
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Back) return;
            switch (Type_text)
            {
                case Text_Type.TextNumberSpecial:
                    e.Handled = false;
                    break;
                case Text_Type.TextNumber:
                    if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "^[_@/(.-/)/[*+=&%#?></$`~!^|]*$") && !(e.KeyChar == '-'))
                    {
                        e.Handled = false;
                    }
                    else e.Handled = true;
                    break;
                case Text_Type.Number:
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                            e.Handled = true;
                    break;
                case Text_Type.NumberSpecial:

                    if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "^[0-9_@/(.-/)/[*+=&%#?>|<`~!^]*$") && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == '-'))
                    {
                        e.Handled = true;
                    }
                    break;
                case Text_Type.Decimal:
                    if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
                    {
                    }
                    else if (e.KeyChar == '.' && !Text.Contains('.'))
                    {
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                case Text_Type.StringNoSpace:
                    if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
                        e.Handled = true;
                    break;
                case Text_Type.Email:
                    Language = language_type.english;
                        break;
                case Text_Type.URL:
                        Language = language_type.english;
                    break;
                default:
                    break;
            }
           
            base.OnKeyPress(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            if (type_text == Text_Type.Number)
            {
                try
                {
                    if (Int64.Parse(Text) < MinNumber)
                    {
                        Text = MinNumber.ToString();
                        return;
                    }
                    if (Int64.Parse(Text) > MaxNumber)
                    {
                        Text = MaxNumber.ToString();
                        return;
                    }
                }
                catch
                {
                    if (string.IsNullOrWhiteSpace(Text)) return;
                    Text = MaxNumber.ToString();
                }
            }
            else if (type_text == Text_Type.Email)
            {
                 if (!string.IsNullOrWhiteSpace(Text))
                {
                    if (!System.Text.RegularExpressions.Regex.IsMatch(Text, @"^((\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)\s*[,]{0,1}\s*)+$"))
                    {
                        this.Focus();
                    }
                }
            }
            else if (type_text == Text_Type.URL)
            {
                if (!string.IsNullOrWhiteSpace(Text))
                {
                    if (!System.Text.RegularExpressions.Regex.IsMatch(Text, @"^[a-zA-Z0-9\-\.]+\.(com|org|net|mil|edu|COM|ORG|NET|MIL|EDU)$"))
                    {
                        this.Focus();
                    }
                }
            } 
            base.OnLeave(e);
        }
        public void txt_english(object sender, EventArgs e)
        {
           // this.RightToLeft = System.Windows.Forms.RightToLeft.No; 
            for (int i = 0; i < InputLanguage.InstalledInputLanguages.Count; i++)
            {
                if (InputLanguage.InstalledInputLanguages[i].LayoutName.Contains("English") || InputLanguage.InstalledInputLanguages[i].LayoutName.Contains("US"))
                {
                    InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages[i];
                     break;
                }
            }
          
        }
        public void txt_arabic(object sender, EventArgs e)
        {
            for (int i = 0; i < InputLanguage.InstalledInputLanguages.Count; i++)
            {
                if (InputLanguage.InstalledInputLanguages[i].LayoutName.Contains("Arabic") || InputLanguage.InstalledInputLanguages[i].LayoutName.Contains("Ar"))
                {
                    InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages[i];
                    // this.RightToLeft = System.Windows.Forms.RightToLeft.No;
                    break;
                }
               // InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("ar-eg"));
            }
            
        }

       
        public AcisTextBox()
            : base()
        {
           // InPutType = Text_Type.String;
            //MinNumber = 150;
            //MaxNumber = 214783648;

           // int count = InputLanguage.InstalledInputLanguages.Count;

        }
        public static void OnKeyPressTxt(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
            }
            else if (e.KeyChar == '.' && !((TextBox)sender).Text.Contains('.'))
            {
            }
            else
            {
                e.Handled = true;
            }
        }
    
        //protected override void OnCreateControl()
        //{
        //    base.OnCreateControl();
        //}

        //protected override void OnEnter(EventArgs e)
        //{
        //    switch (InPutType)
        //    {
        //        case Text_Type.EnglishNumberWithSpace:
        //        case Text_Type.EnglishOnlyWithSpace:
        //        case Text_Type.EnglishOnlyWithNoSpace:
        //        case Text_Type.EnglishNumberWithNoSpace:
        //            InputLanguage.CurrentInputLanguage = english;
        //            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
        //            break;

        //        case Text_Type.ArabicNumberWithNoSpace:
        //        case Text_Type.ArabicNumberWithSpace:
        //        case Text_Type.ArabicOnlyWithNoSpace:
        //        case Text_Type.ArabicOnlyWithSpace:
                    
        //            InputLanguage.CurrentInputLanguage = arabic;
        //            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        //            break;
        //    }
        //    base.OnEnter(e);
        //}
      
        //private bool IsArabicCharacter(Char character)
        //{
        //    if (character >= 0x600 && character <= 0x6ff)
        //        return true;
        //    if (character >= 0x750 && character <= 0x77f)
        //        return true;
        //    if (character >= 0xfb50 && character <= 0xfc3f)
        //        return true;
        //    if (character >= 0xfe70 && character <= 0xfefc)
        //        return true;

        //    return false;
        //}
    }

}