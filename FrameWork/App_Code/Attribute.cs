using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using FrameWork.EnumLst;
 

namespace FrameWork.CustomeAttribute
{ 
        public class CustAttr_ErrorMsg : Attribute
        {
            
            public string ErrorMsg_Arabic { get; set; }
            public string ErrorMsg_English { get; set; }

            public CustAttr_ErrorMsg(string ArabicMsg, string EnglishMsg)
            {
                this.ErrorMsg_Arabic = ArabicMsg;
                this.ErrorMsg_English = EnglishMsg;
            }

            public static string GetArabicMsg(Type ClassName, string ClmName)
            {
                string Msg = string.Empty;
                PropertyInfo prop = ClassName.GetProperty(ClmName);
                object[] attrs = prop.GetCustomAttributes(typeof(CustAttr_ErrorMsg), true);

                if (attrs.Count() == 0) return string.Empty;
                CustAttr_ErrorMsg authAttr = attrs[0] as CustAttr_ErrorMsg;

                if (authAttr != null)
                {
                    Msg = authAttr.ErrorMsg_Arabic;
                }

                return Msg;
            }
            public static string GetEnglishMsg(Type ClassName, string ClmName)
            {
                string Msg = string.Empty;
                PropertyInfo prop = ClassName.GetProperty(ClmName);
                object[] attrs = prop.GetCustomAttributes(typeof(CustAttr_ErrorMsg), true);
                if (attrs.Count() == 0) return string.Empty;
                CustAttr_ErrorMsg authAttr = attrs[0] as CustAttr_ErrorMsg;

                if (authAttr != null)
                {
                    Msg = authAttr.ErrorMsg_English;
                }

                return Msg;
            }
        }
        public class CustAttr_Description : Attribute
        {
            public string Description_Arabic { get; set; }
            public string Description_English { get; set; }

            public CustAttr_Description(string ArabicDescription, string EnglishDescription)
            {
                this.Description_Arabic = ArabicDescription;
                this.Description_English = EnglishDescription;
            }

            public static string GetArabicDescription(Type ClassName, string ClmName)
            {
                string Description = string.Empty;
                PropertyInfo prop = ClassName.GetProperty(ClmName);
                object[] attrs = prop.GetCustomAttributes(typeof(CustAttr_Description), true);

                if (attrs.Count() == 0) return string.Empty;
                CustAttr_Description authAttr = attrs[0] as CustAttr_Description;

                if (authAttr != null)
                {
                    Description = authAttr.Description_Arabic;
                }

                return Description;
            }
            public static string GetEnglishDescription(Type ClassName, string ClmName)
            {
                string Description = string.Empty;
                PropertyInfo prop = ClassName.GetProperty(ClmName);
                object[] attrs = prop.GetCustomAttributes(typeof(CustAttr_Description), true);

                if (attrs.Count() == 0) return string.Empty;
                CustAttr_Description authAttr = attrs[0] as CustAttr_Description;

                if (authAttr != null)
                {
                    Description = authAttr.Description_English;
                }

                return Description;
            }
        }
        public class CustAttr_MetaData : Attribute
        {
            public bool IsPrimaryKey { get; set; }
            public bool IsForeignKey { get; set; }
            public bool IsMandatory { get; set; }
            public int MaxLength { get; set; }
            public string NameInForeignTable { get; set; }
            public string ForeignTableName { get; set; }
            public string DBType { get; set; }

            public CustAttr_MetaData(bool _IsPrimaryKey, bool _IsForeignKey, bool _IsMandatory, int _MaxLength,
                                    string _NameInForeignTable, string _ForeignTableName,
                                    string _DBType)
            {
                IsPrimaryKey = _IsPrimaryKey;
                IsForeignKey = _IsForeignKey;
                IsMandatory = _IsMandatory;
                MaxLength = _MaxLength;
                NameInForeignTable = _NameInForeignTable;
                ForeignTableName = _ForeignTableName;
                DBType = _DBType;
            }


            public static bool GetIsPrimaryKey(Type ClassName, string ClmName)
            {
                bool OutPut = false;
                PropertyInfo prop = ClassName.GetProperty(ClmName);
                object[] attrs = prop.GetCustomAttributes(typeof(CustAttr_MetaData), true);

                if (attrs.Count() == 0) return false;
                CustAttr_MetaData authAttr = attrs[0] as CustAttr_MetaData;

                if (authAttr != null)
                {
                    OutPut = authAttr.IsPrimaryKey;
                }

                return OutPut;
            }
            public static bool GetIsForeignKey(Type ClassName, string ClmName)
            {
                bool OutPut = false;
                PropertyInfo prop = ClassName.GetProperty(ClmName);
                object[] attrs = prop.GetCustomAttributes(typeof(CustAttr_MetaData), true);
                if (attrs.Count() == 0) return false;
                CustAttr_MetaData authAttr = attrs[0] as CustAttr_MetaData;

                if (authAttr != null)
                {
                    OutPut = authAttr.IsForeignKey;
                }

                return OutPut;
            }
            public static bool GetIsMandatory(Type ClassName, string ClmName)
            {
                bool OutPut = false;
                PropertyInfo prop = ClassName.GetProperty(ClmName);
                object[] attrs = prop.GetCustomAttributes(typeof(CustAttr_MetaData), true);
                if (attrs.Count() == 0) return false;
                CustAttr_MetaData authAttr = attrs[0] as CustAttr_MetaData;

                if (authAttr != null)
                {
                    OutPut = authAttr.IsMandatory;
                }

                return OutPut;
            }
            public static int GetMaxLength(Type ClassName, string ClmName)
            {
                int OutPut = 0;
                PropertyInfo prop = ClassName.GetProperty(ClmName);
                object[] attrs = prop.GetCustomAttributes(typeof(CustAttr_MetaData), true);
                if (attrs.Count() == 0) return 0;
                CustAttr_MetaData authAttr = attrs[0] as CustAttr_MetaData;

                if (authAttr != null)
                {
                    OutPut = authAttr.MaxLength;
                }

                return OutPut;
            }
            public static string GetNameInForeignTable(Type ClassName, string ClmName)
            {
                string OutPut = "";
                PropertyInfo prop = ClassName.GetProperty(ClmName);
                object[] attrs = prop.GetCustomAttributes(typeof(CustAttr_MetaData), true);
                if (attrs.Count() == 0) return string.Empty;
                CustAttr_MetaData authAttr = attrs[0] as CustAttr_MetaData;

                if (authAttr != null)
                {
                    OutPut = authAttr.NameInForeignTable;
                }

                return OutPut;
            }
            public static string GetForeignTableName(Type ClassName, string ClmName)
            {
                string OutPut = "";
                PropertyInfo prop = ClassName.GetProperty(ClmName);
                object[] attrs = prop.GetCustomAttributes(typeof(CustAttr_MetaData), true);
                if (attrs.Count() == 0) return string.Empty;

                CustAttr_MetaData authAttr = attrs[0] as CustAttr_MetaData;

                if (authAttr != null)
                {
                    OutPut = authAttr.ForeignTableName;
                }

                return OutPut;
            } 
            public static string GetDBType(Type ClassName, string ClmName)
            {
                string OutPut = "";
                PropertyInfo prop = ClassName.GetProperty(ClmName);
                object[] attrs = prop.GetCustomAttributes(typeof(CustAttr_MetaData), true);
                if (attrs.Count() == 0) return string.Empty;

                CustAttr_MetaData authAttr = attrs[0] as CustAttr_MetaData;

                if (authAttr != null)
                {
                    OutPut = authAttr.DBType;
                }

                return OutPut;
            }
        }
        public class CaptionAttribute : Attribute
        {
            public string ArabicText { get; set; }
            public string EnglishText { get; set; }

            public CaptionAttribute(string English, string Arabic)
            {
                ArabicText = Arabic;
                EnglishText = English;
            }

            public static string GetArabicCatpion(object enumValue)
            {
                FieldInfo fi = enumValue.GetType().GetField(enumValue.ToString());
                if (null != fi)
                {
                    object[] attrs = fi.GetCustomAttributes(typeof(CaptionAttribute), true);
                    if (attrs != null && attrs.Length > 0)
                        return ((CaptionAttribute)attrs[0]).ArabicText;
                }
                return "";
            }
            public static List<string> GetArabicCaptions(Type enumType)
            {
                List<string> Names = new List<string>();
                foreach (object ArCatpion in Enum.GetValues(enumType))
                    Names.Add(GetArabicCatpion(ArCatpion));
                return Names;
            }

            public static string GetEnglishCatpion(object enumValue)
            {
                FieldInfo fi = enumValue.GetType().GetField(enumValue.ToString());
                if (null != fi)
                {
                    object[] attrs = fi.GetCustomAttributes(typeof(CaptionAttribute), true);
                    if (attrs != null && attrs.Length > 0)
                        return ((CaptionAttribute)attrs[0]).EnglishText;
                }
                return "";
            }
            public static List<string> GetEnglishCaptions(Type enumType)
            {
                List<string> Names = new List<string>();
                foreach (object ArCatpion in Enum.GetValues(enumType))
                    Names.Add(GetEnglishCatpion(ArCatpion));
                return Names;
            }


        }
        public class SqlSyntaxAttribute : Attribute
        {
            public string SqlSyntaxText { get; set; }

            public SqlSyntaxAttribute(string SqlSyntaxText)
            {
                this.SqlSyntaxText = SqlSyntaxText;
            }

            public static string GetSqlSyntax(object enumValue)
            {
                FieldInfo fi = enumValue.GetType().GetField(enumValue.ToString());
                if (null != fi)
                {
                    object[] attrs = fi.GetCustomAttributes(typeof(SqlSyntaxAttribute), true);
                    if (attrs != null && attrs.Length > 0)
                        return ((SqlSyntaxAttribute)attrs[0]).SqlSyntaxText;
                }
                return "";
            }
        }
        public class SqlTypeAttribute : Attribute
        {
            public Sqltypes SqlTypeText { get; set; }

            public SqlTypeAttribute(Sqltypes SqlTypeText)
            {
                this.SqlTypeText = SqlTypeText;
            }

            public static Sqltypes GetSqlTyep(Type enumType, int index)
            {
                List<Sqltypes> Names = new List<Sqltypes>();

                foreach (object ArCatpion in Enum.GetValues(enumType))
                    Names.Add(GetSqlTyep(ArCatpion));
                try
                {
                    return Names[index];
                }
                catch
                {
                    return  Sqltypes.All;
                }
            }

            public static Sqltypes GetSqlTyep(object enumValue)
            {
                FieldInfo fi = enumValue.GetType().GetField(enumValue.ToString());
                if (null != fi)
                {
                    object[] attrs = fi.GetCustomAttributes(typeof(SqlTypeAttribute), true);
                    if (attrs != null && attrs.Length > 0)
                        return ((SqlTypeAttribute)attrs[0]).SqlTypeText;
                }
                return Sqltypes.Text;
            }
        }
        public class WorkWithTypes : Attribute
        {
            public Sqltypes[] WorkedTypes;

            public WorkWithTypes(params Sqltypes[] LstOfWorkedTypes)
            {
                WorkedTypes = LstOfWorkedTypes;
            }


            public static List<Sqltypes> FilterCondations(object enumValue)
            {
                FieldInfo fi = enumValue.GetType().GetField(enumValue.ToString());
                if (null != fi)
                {
                    object[] attrs = fi.GetCustomAttributes(typeof(WorkWithTypes), true);
                    if (attrs != null && attrs.Length > 0)
                        return ((WorkWithTypes)attrs[0]).WorkedTypes.ToList();
                }
                return new List<Sqltypes>() { Sqltypes.All };
            }

            public static List<string> GetArabicCaptions(Type enumType, Sqltypes ClmType)
            {
                // create list to hold the out put
                List<string> Names = new List<string>();

                // For all item in this enum
                foreach (object ArCatpion in Enum.GetValues(enumType))
                {
                    // if the type of clm in the types of the condation operator || condation work with allTypes 
                    if (FilterCondations(ArCatpion).Contains(ClmType) || FilterCondations(ArCatpion).Contains(Sqltypes.All))
                        Names.Add(CaptionAttribute.GetArabicCatpion(ArCatpion)); // Append the condation to the output of func with Ar Caption
                }
                return Names;
            }
            public static List<string> GetEnglishCaptions(Type enumType, Sqltypes ClmType)
            {
                // create list to hold the out put
                List<string> Names = new List<string>();

                // For all item in this enum
                foreach (object ArCatpion in Enum.GetValues(enumType))
                {
                    // if the type of clm in the types of the condation operator || condation work with allTypes 
                    if (FilterCondations(ArCatpion).Contains(ClmType) || FilterCondations(ArCatpion).Contains(Sqltypes.All))
                        Names.Add(CaptionAttribute.GetEnglishCatpion(ArCatpion)); // Append the condation to the output of func with Ar Caption
                }
                return Names;
            }
        }
  

    public static class CustAttrExtention
    {
        /// <summary>
        /// Get the Error Message in Arabic language
        /// <returns>returns it as String</returns>
        /// </summary>
        public static string CA_GetArabicMsg(this PropertyInfo FeildInfo)
        {
            string Msg = string.Empty;
            Type ClassName = FeildInfo.DeclaringType;
            string ClmName = FeildInfo.Name;

            object[] attrs = FeildInfo.GetCustomAttributes(typeof(FrameWork.CustomeAttribute.CustAttr_ErrorMsg), true);

            if (attrs.Count() == 0) return string.Empty;
            FrameWork.CustomeAttribute.CustAttr_ErrorMsg authAttr = attrs[0] as FrameWork.CustomeAttribute.CustAttr_ErrorMsg;

            if (authAttr != null)
            {
                Msg = authAttr.ErrorMsg_Arabic;
            }

            return Msg;
        }
        /// <summary>
        /// Get the Error Message in English language
        /// <returns>returns it as String</returns>
        /// </summary>                     
        public static string CA_GetEnglishMsg(this PropertyInfo FeildInfo)
        {
            string Msg = string.Empty;
            Type ClassName = FeildInfo.DeclaringType;
            string ClmName = FeildInfo.Name;

            object[] attrs = FeildInfo.GetCustomAttributes(typeof(FrameWork.CustomeAttribute.CustAttr_ErrorMsg), true);
            if (attrs.Count() == 0) return string.Empty;
            FrameWork.CustomeAttribute.CustAttr_ErrorMsg authAttr = attrs[0] as FrameWork.CustomeAttribute.CustAttr_ErrorMsg;

            if (authAttr != null)
            {
                Msg = authAttr.ErrorMsg_English;
            }

            return Msg;
        }

        /// <summary>
        /// Get the Description in Arabic language
        /// <returns>returns it as String</returns>
        /// </summary>   
        public static string CA_GetArabicDescription(this PropertyInfo FeildInfo)
        {
            string OutPut = string.Empty;
            Type ClassName = FeildInfo.DeclaringType;
            string ClmName = FeildInfo.Name;


            object[] attrs = FeildInfo.GetCustomAttributes(typeof(FrameWork.CustomeAttribute.CustAttr_Description), true);

            if (attrs.Count() == 0) return string.Empty;
            FrameWork.CustomeAttribute.CustAttr_Description authAttr = attrs[0] as FrameWork.CustomeAttribute.CustAttr_Description;

            if (authAttr != null)
            {
                OutPut = authAttr.Description_Arabic;
            }

            return OutPut;
        }
        /// <summary>
        /// Get the Description in English language
        /// <returns>returns it as String</returns>
        /// </summary>   
        public static string CA_GetEnglishDescription(this PropertyInfo FeildInfo)
        {
            string OutPut = string.Empty;
            Type ClassName = FeildInfo.DeclaringType;
            string ClmName = FeildInfo.Name;

            object[] attrs = FeildInfo.GetCustomAttributes(typeof(FrameWork.CustomeAttribute.CustAttr_Description), true);

            if (attrs.Count() == 0) return string.Empty;
            FrameWork.CustomeAttribute.CustAttr_Description authAttr = attrs[0] as FrameWork.CustomeAttribute.CustAttr_Description;

            if (authAttr != null)
            {
                OutPut = authAttr.Description_English;
            }

            return OutPut;
        }


        public static bool CA_GetIsPrimaryKey(this PropertyInfo FeildInfo)
        {
            bool OutPut = false;
            Type ClassName = FeildInfo.DeclaringType;
            string ClmName = FeildInfo.Name;



            object[] attrs = FeildInfo.GetCustomAttributes(typeof(FrameWork.CustomeAttribute.CustAttr_MetaData), true);

            if (attrs.Count() == 0) return false;
            FrameWork.CustomeAttribute.CustAttr_MetaData authAttr = attrs[0] as FrameWork.CustomeAttribute.CustAttr_MetaData;

            if (authAttr != null)
            {
                OutPut = authAttr.IsPrimaryKey;
            }

            return OutPut;
        }
        public static bool CA_GetIsForeignKey(this PropertyInfo FeildInfo)
        {
            bool OutPut = false;
            Type ClassName = FeildInfo.DeclaringType;
            string ClmName = FeildInfo.Name;

            object[] attrs = FeildInfo.GetCustomAttributes(typeof(FrameWork.CustomeAttribute.CustAttr_MetaData), true);
            if (attrs.Count() == 0) return false;
            FrameWork.CustomeAttribute.CustAttr_MetaData authAttr = attrs[0] as FrameWork.CustomeAttribute.CustAttr_MetaData;

            if (authAttr != null)
            {
                OutPut = authAttr.IsForeignKey;
            }

            return OutPut;
        }
        public static bool CA_GetIsMandatory(this PropertyInfo FeildInfo)
        {
            bool OutPut = false;
            Type ClassName = FeildInfo.DeclaringType;
            string ClmName = FeildInfo.Name;

            object[] attrs = FeildInfo.GetCustomAttributes(typeof(FrameWork.CustomeAttribute.CustAttr_MetaData), true);
            if (attrs.Count() == 0) return false;
            FrameWork.CustomeAttribute.CustAttr_MetaData authAttr = attrs[0] as FrameWork.CustomeAttribute.CustAttr_MetaData;

            if (authAttr != null)
            {
                OutPut = authAttr.IsMandatory;
            }

            return OutPut;
        }
        public static int CA_GetMaxLength(this PropertyInfo FeildInfo)
        {
            int OutPut = 0;
            Type ClassName = FeildInfo.DeclaringType;
            string ClmName = FeildInfo.Name;


            object[] attrs = FeildInfo.GetCustomAttributes(typeof(FrameWork.CustomeAttribute.CustAttr_MetaData), true);
            if (attrs.Count() == 0) return 0;
            FrameWork.CustomeAttribute.CustAttr_MetaData authAttr = attrs[0] as FrameWork.CustomeAttribute.CustAttr_MetaData;

            if (authAttr != null)
            {
                OutPut = authAttr.MaxLength;
            }

            return OutPut;
        }
        public static string CA_GetNameInForeignTable(this PropertyInfo FeildInfo)
        {
            string OutPut = string.Empty;
            Type ClassName = FeildInfo.DeclaringType;
            string ClmName = FeildInfo.Name;


            object[] attrs = FeildInfo.GetCustomAttributes(typeof(FrameWork.CustomeAttribute.CustAttr_MetaData), true);
            if (attrs.Count() == 0) return string.Empty;
            FrameWork.CustomeAttribute.CustAttr_MetaData authAttr = attrs[0] as FrameWork.CustomeAttribute.CustAttr_MetaData;

            if (authAttr != null)
            {
                OutPut = authAttr.NameInForeignTable;
            }

            return OutPut;
        }
        public static string CA_GetForeignTableName(this PropertyInfo FeildInfo)
        {
            string OutPut = string.Empty;
            Type ClassName = FeildInfo.DeclaringType;
            string ClmName = FeildInfo.Name;


            object[] attrs = FeildInfo.GetCustomAttributes(typeof(FrameWork.CustomeAttribute.CustAttr_MetaData), true);
            if (attrs.Count() == 0) return string.Empty;

            FrameWork.CustomeAttribute.CustAttr_MetaData authAttr = attrs[0] as FrameWork.CustomeAttribute.CustAttr_MetaData;

            if (authAttr != null)
            {
                OutPut = authAttr.ForeignTableName;
            }

            return OutPut;
        }
     
        public static string CA_GetDBType(this PropertyInfo FeildInfo)
        {
            string OutPut = string.Empty;
            Type ClassName = FeildInfo.DeclaringType;
            string ClmName = FeildInfo.Name;

            object[] attrs = FeildInfo.GetCustomAttributes(typeof(FrameWork.CustomeAttribute.CustAttr_MetaData), true);
            if (attrs.Count() == 0) return string.Empty;

            FrameWork.CustomeAttribute.CustAttr_MetaData authAttr = attrs[0] as FrameWork.CustomeAttribute.CustAttr_MetaData;

            if (authAttr != null)
            {
                OutPut = authAttr.DBType;
            }

            return OutPut;
        }

    }
}
