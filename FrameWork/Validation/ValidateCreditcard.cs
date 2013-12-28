using System;
using FrameWork.EnumLst;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{
    public class ValidateCreditcard : ValidateRegex
    {

        public ValidateCreditcard( string propertyNameEn) :
            base( propertyNameEn, @"^((\d{4}[- ]?){3}\d{4})$")
        {
         
            ErrorMessage_En =  propertyNameEn + " is not a valid credit card number";
            
        }

        public ValidateCreditcard( string propertyNameEn, string errorMessageAr, string errorMessageEn )   :
            this( propertyNameEn )
        {
            ErrorMessage_AR = errorMessageAr;
            ErrorMessage_En = errorMessageEn;
        }
    }
}
