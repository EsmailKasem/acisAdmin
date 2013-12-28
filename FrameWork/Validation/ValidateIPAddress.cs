using FrameWork.EnumLst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{

    public class ValidateIPAddress : ValidateRegex
    {

        public ValidateIPAddress( string propertyNameEn ) :
            base(propertyNameEn , @"^([0-2]?[0-5]?[0-5]\.){3}[0-2]?[0-5]?[0-5]$" )
        {
            ErrorMessage_En =  propertyNameEn + " is not a valid IP Address";
                     
        }

        public ValidateIPAddress( string propertyNameEn, string errorMessageAr, string errorMessageEn) :
            this(propertyNameEn)
        {
            ErrorMessage_AR = errorMessageAr;
            ErrorMessage_En = errorMessageEn;
        }
    }
}
