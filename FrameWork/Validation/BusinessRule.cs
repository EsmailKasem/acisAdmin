﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrameWork.EnumLst;

namespace FrameWork
{

    public abstract class BusinessRule
    {
        public Languages Lang;
        public string PropertyName { get; set; }
        public string ErrorMessage_En { get; set; }
        public string ErrorMessage_AR { get; set; }



        //public override bool Equals(object LangMode)
        //{
        //    Lang = (Languages)LangMode;
        //    return true;
        //}


        public BusinessRule(string propertyNameEn, Languages LanguagesMode = Languages.Arabic)
        {
            PropertyName = propertyNameEn;
            ErrorMessage_En = propertyNameEn + " is not valid";
        }


        public BusinessRule(string propertyNameEn, string errorMessageAr, string errorMessageEn, Languages LanguagesMode = Languages.Arabic)
            : this(propertyNameEn, LanguagesMode)
        {
            ErrorMessage_AR = errorMessageAr;
            ErrorMessage_En = errorMessageEn;
        }

        public abstract bool Validate(BusinessObject businessObject);

        protected object GetPropertyValue(BusinessObject businessObject)
        {
            return businessObject.GetType().GetProperty(PropertyName).GetValue(businessObject, null);
        }


        public static string GetExpressionPattern(ReregularExpression RE_Type)
        {
            switch (RE_Type)
            {
                case ReregularExpression.EmailAdress:
                    return @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";

                case ReregularExpression.Creditcard:
                    return @"^((\d{4}[- ]?){3}\d{4})$";

                case ReregularExpression.IPAddress:
                    return @"^([0-2]?[0-5]?[0-5]\.){3}[0-2]?[0-5]?[0-5]$";

            }
            return "";
        }
    }
}

