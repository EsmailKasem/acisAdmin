using FrameWork.EnumLst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{

    public class ValidateId : BusinessRule
    {
        public ValidateId(string propertyNameEn)
            : base(propertyNameEn)
        {
            ErrorMessage_En = propertyNameEn;
             
        }



        public ValidateId( string propertyNameEn, string errorMessageAr, string errorMessageEn)
            : base( propertyNameEn)
        {
            ErrorMessage_AR = errorMessageAr;
            ErrorMessage_En = errorMessageEn;
        }

        public override bool Validate(BusinessObject businessObject)
        {
            try
            {
                int id = int.Parse(GetPropertyValue(businessObject).ToString());
                return id > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
