using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Text.RegularExpressions;
using FrameWork.EnumLst;

namespace FrameWork
{

    public class ValidateRegex : BusinessRule
    {
        protected string Pattern { get; set; }

        public ValidateRegex(string propertyNameEn, string pattern)
            : base( propertyNameEn)
        {
            Pattern = pattern;
        }

        public ValidateRegex(string propertyNameEn, ReregularExpression RE_Type )
            : base(propertyNameEn)
        {
            Pattern = BusinessRule.GetExpressionPattern(RE_Type) ;
        }

        public ValidateRegex( string propertyNameEn, string errorMessageAr, string errorMessageEn, string pattern)
            : this( propertyNameEn, pattern)
        {
            ErrorMessage_AR = errorMessageAr;
            ErrorMessage_En = errorMessageEn;
        }

        public override bool Validate(BusinessObject businessObject)
        {
            return Regex.Match(GetPropertyValue(businessObject).ToString(), Pattern).Success;
        }
    }
}
