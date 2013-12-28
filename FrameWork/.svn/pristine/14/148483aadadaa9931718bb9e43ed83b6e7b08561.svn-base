using FrameWork.EnumLst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace FrameWork
{
  
    public class ValidateRequired : BusinessRule
    {

        public ValidateRequired(string propertyNameEn)
            : base( propertyNameEn) 
        {       
            ErrorMessage_En = propertyNameEn + " is a required field." ;
        }

        public ValidateRequired( string propertyNameEn, string errorMessageAr, string errorMessageEn )
            : base(propertyNameEn  )
        {
            ErrorMessage_AR = errorMessageAr;
            ErrorMessage_En = errorMessageEn;
        }

        public override bool Validate(BusinessObject businessObject)
        {
            try
            {
                return GetPropertyValue(businessObject).ToString().Length > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
