﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Xml.Linq;
using System.Reflection;
using System.IO;

namespace FrameWork
{
    public static class Extensions
    {


        public static bool IsInt(this object item)
        {
            if (item == null)
                return false;

            int result;
            if (!int.TryParse(item.ToString(), out result))
                return false;

            return true;
        }

        /*
         * id =-1 
         * int=0
         * double=0.0
         * string =string.empty
         * datetime =1/1/0001 12:00:00 AM
         * bool false
         */
        public static Color HighlightText = Color.FromArgb(255, 51, 153, 255);
        public static int AsId(this object item, int defaultId = -1)
        {
            if (item == null)
                return defaultId;

            int result;
            if (!int.TryParse(item.ToString(), out result))
                return defaultId;

            return result;
        }
        public static decimal AsDecimal(this object item, decimal defaultId = default(decimal))
        {

            if (item == null)
                return defaultId;

            decimal number;

            if (!Decimal.TryParse(item.ToString(), out number))
                return defaultId;

            return number;
        }
        public static decimal AsDecimal(this object item, int Fractions, decimal defaultId = default(decimal))
        {

            if (item == null)
                return defaultId;

            decimal number;

            if (!Decimal.TryParse(item.ToString(), out number))
                return defaultId;

            return Math.Round(number, Fractions);
        }
        public static int AsInt(this object item, int defaultInt = default(int))
        {
            if (item == null)
                return defaultInt;

            int result;
            if (!int.TryParse(item.ToString(), out result))
                return defaultInt;

            return result;
        }
        public static Int64 AsInt64(this object item, int defaultInt = default(int))
        {
            if (item == null)
                return defaultInt;

            int result;
            if (!int.TryParse(item.ToString(), out result))
                return defaultInt;

            return result;
        }
        public static double AsDouble(this object item, double defaultDouble = default(double))
        {
            if (item == null)
                return defaultDouble;

            double result;
            if (!double.TryParse(item.ToString(), out result))
                return defaultDouble;

            return result;
        }
        public static string AsString(this object item, string defaultString = default(string))
        {
            if (item == null || item.Equals(System.DBNull.Value))
                return defaultString;

            return item.ToString().Trim();
        }
        public static DateTime AsDateTime(this object item, DateTime defaultDateTime = default(DateTime))
        {
            if (item == null || string.IsNullOrEmpty(item.ToString()))
                return defaultDateTime;

            DateTime result;
            if (!DateTime.TryParse(item.ToString(), out result))
                return defaultDateTime;

            return result;
        }
        public static TimeSpan AsTime(this object item, TimeSpan defaultDateTime = default(TimeSpan))
        {
            if (item == null || string.IsNullOrEmpty(item.ToString()))
                return defaultDateTime;
            TimeSpan result;
            try
            {
                result = new TimeSpan(Convert.ToDateTime(item).Hour, Convert.ToDateTime(item).Minute, Convert.ToDateTime(item).Second);
            }
            catch
            {
                return defaultDateTime;
            }
            return result;
        }
        public static DateTime AsTimePaicker(this object item, DateTime defaultDateTime = default(DateTime))
        {
            if (item == null || string.IsNullOrEmpty(item.ToString()))
                return defaultDateTime;


            DateTime result = new DateTime
                (
                    DateTime.Now.Year,
                     DateTime.Now.Month,
                      DateTime.Now.Day,
                     ((TimeSpan)(item)).Hours,
                    ((TimeSpan)(item)).Minutes,
                    ((TimeSpan)(item)).Seconds
                );

            if (!DateTime.TryParse(item.ToString(), out result))
                return defaultDateTime;

            return result;
        }
        public static bool AsBool(this object item, bool defaultBool = default(bool))
        {
            if (item == null)
                return defaultBool;

            return new List<string>() { "yes", "y", "true" }.Contains(item.ToString().ToLower());
        }
        public static byte[] AsByteArray(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return null;

            return Convert.FromBase64String(s);
        }
        public static byte[] AsByteFromImage(this Image Img)
        {
            MemoryStream ms = new MemoryStream();
            if (Img != null)
                Img.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();

        }
        public static Image AsImageFromByte(this byte[] value)
        {
            MemoryStream ms = new MemoryStream(value);
            Image returnImage;
            if (ms.Length > 0)
            {
                returnImage = Image.FromStream(ms);

            }
            else
            {
                returnImage = null;
            }
            return returnImage;

        }
        public static string AsBase64String(this object item)
        {
            if (item == null)
                return null;
            ;

            return Convert.ToBase64String((byte[])item);
        }
        public static string AsBase64String(this Binary item)
        {
            if (item == null)
                return null;

            return Convert.ToBase64String(item.ToArray());
        }
        public static Binary AsBinary(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return null;

            return new Binary(Convert.FromBase64String(s));
        }
        public static Guid AsGuid(this object item)
        {
            try { return new Guid(item.ToString()); }
            catch { return Guid.Empty; }
        }
        public static string OrderBy(this string sql, string sortExpression)
        {
            if (string.IsNullOrEmpty(sortExpression))
                return sql;

            return sql + " ORDER BY " + sortExpression;
        }
        public static string CommaSeparate<T, U>(this IEnumerable<T> source, Func<T, U> func)
        {
            return string.Join(",", source.Select(s => func(s).ToString()).ToArray());
        }
        public static string Condation(this string sql, string ConditionExpression)
        {
            if (string.IsNullOrEmpty(ConditionExpression))
                return sql;

            return sql + " Where " + ConditionExpression;
        }
        public static string AddParamName(this string sql, string PropName)
        {
            if (string.IsNullOrEmpty(PropName))
                return sql;

            return string.Format("{0} Where {1} = @{1} ", sql, PropName);
        }
        public static void ChangeLanguage(this ListControl Cmb, EnumLst.Languages Lang)
        {
            int CmbItemindex = Cmb.SelectedIndex;

            if (Lang == EnumLst.Languages.Arabic)
                Cmb.DisplayMember = "ArabicCaption";
            else
                Cmb.DisplayMember = "EnglishCaption";

            Cmb.SelectedIndex = CmbItemindex;
        }
        public static T First<T>(this DataGridView CurrentGrid) where T : new()
        {


            if (CurrentGrid.RowCount > 0)
            {
                CurrentGrid.Rows[0].Selected = true;
                CurrentGrid.CurrentCell = CurrentGrid.Rows[0].Cells[0];
                CurrentGrid.DefaultCellStyle.SelectionBackColor = HighlightText;
                CurrentGrid.DefaultCellStyle.SelectionForeColor = Color.White;
                CurrentGrid.Refresh();
                T C = new T();
                CopyPropertyValues(CurrentGrid.Rows[0].DataBoundItem, C);
                return C;
                // return (T)CurrentGrid.Rows[0].DataBoundItem;
            }
            else
            {
                return default(T);
            }
        }
        public static T Next<T>(this DataGridView CurrentGrid, T CurrentObject) where T : new()
        {


            if (CurrentGrid.RowCount > 0)
            {
                if (CurrentObject == null)
                {

                    return CurrentGrid.First<T>();
                }
                else
                {

                    if (CurrentGrid.RowCount - 1 > CurrentGrid.CurrentRow.Index)
                    {

                        CurrentGrid.Rows[CurrentGrid.CurrentRow.Index + 1].Selected = true;
                        CurrentGrid.CurrentCell = CurrentGrid.Rows[CurrentGrid.CurrentRow.Index + 1].Cells[0];
                        CurrentGrid.DefaultCellStyle.SelectionBackColor = HighlightText;
                        CurrentGrid.DefaultCellStyle.SelectionForeColor = Color.White;
                        T C = new T();
                        CopyPropertyValues(CurrentGrid.Rows[CurrentGrid.CurrentRow.Index].DataBoundItem, C);
                        return C;

                    }
                    else
                    {
                        CurrentGrid.Rows[CurrentGrid.CurrentRow.Index].Selected = true;
                        CurrentGrid.CurrentCell = CurrentGrid.Rows[CurrentGrid.CurrentRow.Index].Cells[0];
                        CurrentGrid.DefaultCellStyle.SelectionBackColor = HighlightText;
                        CurrentGrid.DefaultCellStyle.SelectionForeColor = Color.White;
                        T C = new T();
                        CopyPropertyValues(CurrentGrid.Rows[CurrentGrid.CurrentRow.Index].DataBoundItem, C);
                        return C;
                    }
                }

            }
            else
            {
                return default(T);
            }
        }
        public static T Previous<T>(this DataGridView CurrentGrid, T CurrentObject) where T : new()
        {


            if (CurrentGrid.RowCount > 0)
            {
                if (CurrentObject == null)
                {
                    return default(T);
                }
                else
                {
                    if (CurrentGrid.CurrentRow.Index > 0)
                    {
                        CurrentGrid.Rows[CurrentGrid.CurrentRow.Index - 1].Selected = true;
                        CurrentGrid.CurrentCell = CurrentGrid.Rows[CurrentGrid.CurrentRow.Index - 1].Cells[0];
                        CurrentGrid.DefaultCellStyle.SelectionBackColor = HighlightText;
                        CurrentGrid.DefaultCellStyle.SelectionForeColor = Color.White;
                        T C = new T();
                        CopyPropertyValues(CurrentGrid.Rows[CurrentGrid.CurrentRow.Index].DataBoundItem, C);
                        return C;
                    }
                    else
                    {
                        CurrentGrid.Rows[CurrentGrid.CurrentRow.Index].Selected = true;
                        CurrentGrid.CurrentCell = CurrentGrid.Rows[CurrentGrid.CurrentRow.Index].Cells[0];
                        CurrentGrid.DefaultCellStyle.SelectionBackColor = HighlightText;
                        CurrentGrid.DefaultCellStyle.SelectionForeColor = Color.White;
                        T C = new T();
                        CopyPropertyValues(CurrentGrid.Rows[CurrentGrid.CurrentRow.Index].DataBoundItem, C);
                        return C;
                    }
                }

            }
            else
            {
                return default(T);
            }
        }
        public static T Last<T>(this DataGridView CurrentGrid) where T : new()
        {


            if (CurrentGrid.RowCount > 0)
            {
                CurrentGrid.Rows[CurrentGrid.RowCount - 1].Selected = true;
                CurrentGrid.CurrentCell = CurrentGrid.Rows[CurrentGrid.RowCount - 1].Cells[0];
                T C = new T();
                CopyPropertyValues(CurrentGrid.Rows[CurrentGrid.RowCount - 1].DataBoundItem, C);
                return C;

            }
            else
            {
                return default(T);
            }
        }
        public static void GetColumnsWidth(this DataGridView CurrentGrid, ref Dictionary<string, int> WidthDictionary)
        {
            WidthDictionary = new Dictionary<string, int>();
            foreach (DataGridViewColumn item in CurrentGrid.Columns)
            {
                WidthDictionary.Add(item.Name, item.Width);

            }
        }
        public static void ResetGridSize(this DataGridView CurrentGrid, Dictionary<string, int> WidthDictionary)
        {

            foreach (KeyValuePair<string, int> item in WidthDictionary)
            {
                CurrentGrid.Columns[item.Key].Width = item.Value;
            }
        }
        public static bool Between<T>(this T Value, T MinValue, T MaxValue) where T : IComparable<T>
        {
            return Value.CompareTo(MinValue) >= 0 && Value.CompareTo(MaxValue) <= 0;
        }
        public static bool In<T>(this T source, params T[] list)
        {
            return list.ToList().Contains(source);
        }
        public static bool HasValue<T>(this T Value)
        {
            return !string.IsNullOrEmpty(Value.ToString());
        }
        public static DataTable ToDataTable<T>(this IEnumerable<T> varlist)
        {
            DataTable dtReturn = new DataTable();
            PropertyInfo[] oProps = null;

            if (varlist == null) return dtReturn;

            foreach (T rec in varlist)
            {
                // Use reflection to get property names, to create table, Only first time, others will follow 
                if (oProps == null)
                {
                    oProps = ((Type)rec.GetType()).GetProperties();
                    foreach (PropertyInfo pi in oProps)
                    {
                        Type colType = pi.PropertyType;

                        if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition() == typeof(Nullable<>)))
                        {
                            colType = colType.GetGenericArguments()[0];
                        }

                        dtReturn.Columns.Add(new DataColumn(pi.Name, colType));
                    }
                }

                DataRow dr = dtReturn.NewRow();

                foreach (PropertyInfo pi in oProps)
                {
                    dr[pi.Name] = pi.GetValue(rec, null) == null ? DBNull.Value : pi.GetValue
                    (rec, null);
                }

                dtReturn.Rows.Add(dr);
            }
            return dtReturn;
        }
        public static XDocument ToXml<T>(this IEnumerable<T> varlist, string rootName)
        {
            return ToXml(varlist.ToDataTable(), rootName);
        }
        public static XDocument ToXml(this DataTable dt, string rootName)
        {
            if (string.IsNullOrEmpty(dt.TableName))
                dt.TableName = rootName;

            var xdoc = new XDocument
            {
                Declaration = new XDeclaration("1.0", "utf-8", "")
            };

            xdoc.Add(new XElement(rootName));
            foreach (DataRow row in dt.Rows)
            {
                var element = new XElement(dt.TableName);
                foreach (DataColumn col in dt.Columns)
                {
                    element.Add(new XElement(col.ColumnName, row[col].ToString().Trim(' ')));
                }
                if (xdoc.Root != null) xdoc.Root.Add(element);
            }

            return xdoc;
        }
        public static string FirstDayOfMonth(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1).ToString("MM/dd/yyyy");
        }
        public static string LastDayOfMonth(this DateTime date)
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, 1).AddDays(-1).ToString("MM/dd/yyyy");
        }
        public static void CopyPropertyValues<T>(this T source, T destination)
        {
            List<PropertyInfo> destProperties = destination.GetType().GetProperties().ToList();
            destProperties.Remove(destProperties.Where(x => x.Name == "ValidationErrors").FirstOrDefault());

            foreach (PropertyInfo Prop in destProperties)
            {
                object Value = Prop.GetValue(source, null);
                Prop.SetValue(destination, Value, null);
            }


        }


    }
}
