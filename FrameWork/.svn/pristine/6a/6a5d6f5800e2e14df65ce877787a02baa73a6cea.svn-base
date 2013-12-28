using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrameWork.EnumLst;
using FrameWork.CustomeAttribute;

namespace FrameWork
{
    public class AdvancedSearchItem
    {
        public BinaryOprator Operator { get; set; }
        public LogicalOperator LogicalOperator { get; set; }
        public string FieldName { get; set; }
        public object Value { get; set; }
        public object MinValue { get; set; }
        public object MaxValue { get; set; }

        public AdvancedSearchItem(BinaryOprator _Operator, string _FieldName, object _Value, LogicalOperator _LogicalOperator = EnumLst.LogicalOperator.And)
        {
            this.Operator = _Operator;
            this.FieldName = _FieldName;
            this.Value = _Value;
            this.LogicalOperator = _LogicalOperator;
        }
        public AdvancedSearchItem(BinaryOprator _Operator, string _FieldName, object _MinValue, object _MaxValue, LogicalOperator _LogicalOperator = EnumLst.LogicalOperator.And)
        {
            this.Operator = _Operator;
            this.FieldName = _FieldName;
            this.MinValue = _MinValue;
            this.MaxValue = _MaxValue;
            this.LogicalOperator = _LogicalOperator;

        }
        public AdvancedSearchItem() { }

        public string SqlCondationBuilder(ref Dictionary<string, object> ParamsContentHolder)
        {
            string QueryText = "";

            switch (SqlSyntaxAttribute.GetSqlSyntax(Operator))
            {
                #region operator < Like > Pattern : < ClmName Like @Val >
                case "like":
                case "NoT like":
                    ParamsContentHolder.Add(string.Format("@{0}", FieldName.Replace(".","")), string.Format("%{0}%", Value));
                    QueryText = string.Format("{0} {1}  @{3}  ", FieldName, SqlSyntaxAttribute.GetSqlSyntax(Operator), FieldName.Replace(".", ""));
                    break;
                #endregion

                #region  operator < Between > Pattern : < ClmName Between @MinVal and @MaxVal >
                case "Between":
                    ParamsContentHolder.Add(string.Format("@Min{0}", FieldName.Replace(".","")), MinValue);
                    ParamsContentHolder.Add(string.Format("@Max{0}", FieldName.Replace(".", "")), MaxValue);
                    QueryText = string.Format("{0} Between @Min{1} and @Max{1}  ", FieldName, FieldName.Replace(".", ""));
                    break;
                #endregion

                #region  operator < AnyOtherOperator > Pattern : < ClmName AnyOtherOperator @Val >
                default:
                    ParamsContentHolder.Add(string.Format("@{0}", FieldName.Replace(".","")), Value);
                    QueryText = string.Format("{0} {1} @{2}  ", FieldName, SqlSyntaxAttribute.GetSqlSyntax(Operator), FieldName.Replace(".", ""));
                    break;
                #endregion
            }

            return QueryText;
        }

        public static string SqlCondationBuilder(List<AdvancedSearchItem> LstOf_AdvancedSearchItem, ref Dictionary<string, object> ParamsContentHolder)
        {
            List<string> List_QueryText = new List<string>();
            foreach (AdvancedSearchItem Item in LstOf_AdvancedSearchItem)
                List_QueryText.Add(" " + Item.SqlCondationBuilder(ref ParamsContentHolder));



            return string.Join(" And ", List_QueryText);
        }

    }
}
