using FrameWork.EnumLst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{
    
    public class ValidateEmail : ValidateRegex
    {
        public ValidateEmail( string propertyNameEn) :
            base(propertyNameEn, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")
        { 
        }

        public ValidateEmail( string propertyNameEn, string errorMessageAr, string errorMessageEn) :
            this( propertyNameEn )
        {
            ErrorMessage_AR = errorMessageAr;
            ErrorMessage_En = errorMessageEn;
        }
    }
}
