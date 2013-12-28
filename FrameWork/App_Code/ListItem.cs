using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using FrameWork.EnumLst;
using FrameWork.CustomeAttribute;


namespace FrameWork
{
    public class ListItem
    {
        public string ArabicCaption { get; set; }
        public string EnglishCaption { get; set; }
        public string Value { get; set; }
         

        public ListItem(string Value, string ArabicCaption ,string EnglishCaption ) 
        {
           this.ArabicCaption = ArabicCaption;
           this.EnglishCaption = EnglishCaption;
           this.Value = Value;
        }

        public ListItem(){}



    }
}