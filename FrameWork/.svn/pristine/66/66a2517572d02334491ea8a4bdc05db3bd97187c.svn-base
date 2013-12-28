using System;
using System.Collections.Generic;
using System.Linq;
using FrameWork.EnumLst;
using System.Text;

namespace FrameWork
{

    public class ValidateLength : BusinessRule
    {
        private int _min;
        private int _max;
        private bool _MustEqualLength;

        public ValidateLength(string propertyName, int min, int max )
            : base( propertyName )
        {
            _min = min;
            _max = max;
        }

        public ValidateLength(string propertyName, int max, bool MustEqualLength = false)
            : base(propertyName)
        {
            _min = 0;
            _max = max;
            _MustEqualLength = MustEqualLength;
        }

        public ValidateLength( string propertyName, string errorMessageAr, string errorMessageEn, int min, int max )
            : this( propertyName, min, max )
        {
            _min = min;
            _max = max;
            ErrorMessage_AR = errorMessageAr;
            ErrorMessage_En = errorMessageEn;
        }

        public ValidateLength(string propertyName, string errorMessageAr, string errorMessageEn, int max)
            : this(propertyName, 0, max)
        {
            _max = max;
            ErrorMessage_AR = errorMessageAr;
            ErrorMessage_En = errorMessageEn;
        }

        public ValidateLength(string propertyName, int min ,int max , bool MustEqualLength = false )
            : this(propertyName, 0, max )
        {
            _min = min;
            _max = max; 
            _MustEqualLength = MustEqualLength;
        }


        public override bool Validate(BusinessObject businessObject)
        {
            int length = GetPropertyValue(businessObject).ToString().Length;

            if (_MustEqualLength)
                return length == _max;
            else
                return length >= _min && length <= _max;
        }
    }
}
