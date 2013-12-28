﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWork
{
    public static class AppSetting
    {

        public static EnumLst.AppDbType DbType;
        public static string ConnDbAdmin = "";
        public static string ConnDbAccount = "";
        public static string ConnDbBackOffice = "";
        public static string DBNameBasically = ""; 

        public static string BussinessDBName = "";
        public static string GetDbConnString()
        {
            switch (DbType)
            {
                case EnumLst.AppDbType.Account:
                    return string.Format(@"{0}", ConnDbAccount);

                case EnumLst.AppDbType.AcisAdmin:
                    return string.Format(@"{0}", ConnDbAdmin);
            }

            return @"Data Source=KADEL;Initial Catalog=test;Integrated Security=True";
        }




      



    }
}
