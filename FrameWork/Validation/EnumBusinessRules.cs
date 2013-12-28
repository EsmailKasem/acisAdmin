using FrameWork.EnumLst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{

    public enum ValidationOperator
    {
        Equal, 
        NotEqual, 
        GreaterThan, 
        GreaterThanEqual, 
        LessThan, 
        LessThanEqual
    }

    public enum ValidationDataType
    {
        String,
        Integer,
        Double,
        Decimal,
        Date
    }

    public enum ReregularExpression 
    {
        EmailAdress, Creditcard, IPAddress
    }

}
