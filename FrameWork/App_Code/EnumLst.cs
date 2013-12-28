﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Reflection;
using FrameWork.CustomeAttribute;


namespace FrameWork.EnumLst
{
    public enum dgvNavigateOptMode { FirstPage, NextPage, PreviosPage, LastPage, ByNumber }

    public enum BinaryOprator
    {
        [Caption("Equal", " يساوي")]
        [SqlSyntax("=")]
        Equal = 0,

        [Caption("Not Equal", "لا يساوي")]
        [SqlSyntax("!=")]
        NotEqual = 1,

        [WorkWithTypes(Sqltypes.Number, Sqltypes.DateTime, Sqltypes.Time)]
        [SqlSyntax("<")]
        [Caption("Less Than", "اقل من")]
        LessThan = 2,

        [WorkWithTypes(Sqltypes.Number, Sqltypes.DateTime, Sqltypes.Time)]
        [SqlSyntax(">")]
        [Caption("Greater Than", "اكبر من")]
        GreaterThan = 3,

        [WorkWithTypes(Sqltypes.Number, Sqltypes.DateTime, Sqltypes.Time)]
        [SqlSyntax("!<")]
        [Caption("Not Less Than", "ليس اقل من")]
        NotLessThan = 4,

        [SqlSyntax("!>")]
        [WorkWithTypes(Sqltypes.Number, Sqltypes.DateTime, Sqltypes.Time)]
        [Caption("Not Greater Than", "ليس اكبر من")]
        NotGreaterThan = 5,

        [SqlSyntax("<=")]
        [WorkWithTypes(Sqltypes.Number, Sqltypes.DateTime, Sqltypes.Time)]
        [Caption("Less Than Or Equal To", "اقل من او يساوي")]
        LessThanOrEqualTo = 6,

        [SqlSyntax(">=")]
        [WorkWithTypes(Sqltypes.Number, Sqltypes.DateTime, Sqltypes.Time)]
        [Caption("Greater Than Or Equal To", "اكبر من او يساوي")]
        GreaterThanOrEqualTo = 7,

        [WorkWithTypes(Sqltypes.Text)]
        [SqlSyntax("like")]
        [Caption("Contains", "يحتوي علي")]
        Contains = 8,

        [WorkWithTypes(Sqltypes.Text, Sqltypes.DateTime, Sqltypes.Time)]
        [SqlSyntax("NoT like")]
        [Caption("Not Contains", "لا يحتوي علي")]
        NotContains = 9,

        [SqlSyntax("Between")]
        [Caption("between", " بين")]
        [WorkWithTypes(Sqltypes.Number, Sqltypes.DateTime, Sqltypes.Time)]
        between = 10,

        [WorkWithTypes(Sqltypes.DateTime)]
        [SqlSyntax("Month")]
        [Caption("Month", "شهر")]
        Month = 11,

        [WorkWithTypes(Sqltypes.DateTime)]
        [SqlSyntax("Day")]
        [Caption("Day", "يوم")]
        Day = 12,

        [WorkWithTypes(Sqltypes.DateTime)]
        [SqlSyntax("Year")]
        [Caption("Year", "سنة")]
        Year = 13,

        [WorkWithTypes(Sqltypes.DateTime)]
        [SqlSyntax("betweenTwoMonths")]
        [Caption("between Two Months", "بين شهرين")]
        betweenTwoMonths = 14,

        [WorkWithTypes(Sqltypes.DateTime)]
        [SqlSyntax("betweenTwoYears")]
        [Caption("between Two Years", "بين سنتين")]
        betweenTwoYears = 15

    }

    public enum LogicalOperator
    {
        [Caption("And", "او")]
        [SqlSyntax("And")]
        And = 0,
        [SqlSyntax("OR")]
        [Caption("OR", "و")]
        OR = 1
    }

    public enum Sqltypes
    {
        Number, Text, DateTime, Time, All
    }

    public enum Months
    {
        [Caption("January", "يناير")]
        January = 1,
        [Caption("February", "فبراير")]
        February = 2,
        [Caption("March", "مارس")]
        March = 3,
        [Caption("April", "ابريل")]
        April = 4,
        [Caption("May", "مايو")]
        May = 5,
        [Caption("June", "يونيو")]
        June = 6,
        [Caption("July", "يوليو")]
        July = 7,
        [Caption("August", "اغسطس")]
        August = 8,
        [Caption("September", "سبتمبر")]
        September = 9,
        [Caption("October", "اكتوبر")]
        October = 10,
        [Caption("November", "نوفمبر")]
        November = 11,
        [Caption("December", "ديسمبر")]
        December = 12
    }

    public enum Languages
    {
        [Caption("Arabic", "عربي")]
        Arabic = 1,
        [Caption("English", "إنجليزى")]
        English = 2
    }

    public enum MatchType { Equal, StartWith, StartOrEndWith }

    public enum MathSummaryFunctions
    {
        Avrage = 0,
        Sum = 1,
        Min = 2,
        Max = 3,
        Count = 4
    }

    public enum RelationFillMode { None, OneToManySummaryOnly, OneToManyNormalOnly, All }

    public enum AppDbType
    {
        AcisAdmin, Account, test
    }

    public enum Applications
    {
        Admin = 1, Reports = 2, GL = 3, HR = 4, InvCost = 5, Archives = 6, Auto_Manger = 7, Clinics = 8
    }

    public enum PlaceType
    {
        Country = 1, Area = 2, City = 3
    }

    public enum LogActionTypes
    {
        Login = 1,
        Add = 2,
        Update = 3,
        Delete = 4,
        Print = 5,
        Post = 6,
        Reopen = 7,
        Confirmed = 8,
        Check_Print = 9
    }

    public enum UserError
    {
        Application_Code_Not_Exist = 1,
        Application_Is_Inactive = 2,
        Application_Version_NotMatch = 3,
        User_Name_Not_Exist = 4,
        PassWord_Not_Exist = 5,
        User_Group_Is_Inactive = 6,
        User_Profile_Is_Inactive = 7,
        No_Screen_In_Privileges = 8,
        Allow_Access = 9,
        Conn_Err = 0
    }

    public enum PrintStyle { DBOnly, CrOnly, All }

    public enum SortType
    {
        Asc, Desc
    }

    public enum Mode
    {
        New, Read, search, SaveOnly, SaveAndSearch, SearchWithExtend, Print

    }

    public enum DataMode
    {
        BioData, TransactionData
    }

    public enum TextType { Number, LetterOnly, Decimal, String, StringNoSpace, EnglishOnlyWithSpace, EnglishOnlyWithNoSpace, EnglishNumberWithNoSpace, EnglishNumberWithSpace, ArabicOnlyWithSpace, ArabicOnlyWithNoSpace, ArabicNumberWithSpace, ArabicNumberWithNoSpace }

    public enum TypeMaps
    {
        Item = 101,
        Form = 201,
        report = 202,
        Label = 301,
        TabControl = 302,
        DataGridView = 303,
        GroupBox = 304,
        LinkLabel = 305,
        Button = 306,
        RadioButton = 307,
        CheckBox = 308,
        CollumnGrid = 309,
        TabPage = 310,
        Panel = 311,
        TableLayoutPanel = 312,

        PageHeaderSection = 313,
        DetailSection = 314,
        PageFooterSection = 315,
        textboxReport = 316,
        htmltextboxReport = 317,
        CheckBoxReport = 318,
        TableReport = 319,
        CrossTabReport = 320,
        PanelReport = 321
    }


    public enum OptinType
    {
        showMDI = 101, showMsg = 2, RepOpt = 202, AutoID = 201, Numbers = 1
    }

    public enum OrgnaizeType
    {
        Company = 1, Branch = 2, Stock = 3
    }


    public enum ListType
    {
        Suppliers_Categories = 1, Suppliers_Classes = 2, Customers_Categories = 3,
        Customers_Classes = 4, Assests_Types = 5, Destory_Methods = 6,
        Assests_Status = 7, Assests_Locations = 8, Accounts_Types = 9, Suppliers_Groups = 10,
        Cash_ways = 11, Postpone_ways = 12, Social_Case = 18, Customers_Groups = 20, Human_Relation = 21, Identity_Types = 22, Doctores_Specializations = 24, Blood_Type = 25
    }



    public enum Links
    {
        Final_Accounts = 1, Accounts_Opertions = 2, GL_Accounts = 3, GL_Types = 4, GL_CC = 5, GL_Follow = 6, GL_Nature = 7, GL_Type = 8, GL_Invoices = 9, GL_CC_Type = 13, GL_Final_Report = 14
    }


    public enum LinksData
    {
        Accounts_Opertions_Suppliers = 1, Accounts_Opertions_Customers = 2, Accounts_Opertions_Projects = 3,
        GL_Accounts_Accounts = 4, GL_Accounts_Suppliers = 5, GL_Accounts_Employees = 6,
        Final_Accounts_Budget_Elements = 7, Final_Accounts_Incoming_List = 8, Final_Accounts_Money_FlowUP = 9,
        GlDaily = 16, catch_cash = 17, catch_acheck = 18, Cash_voucher = 19, Acheck_voucher = 20, GL_Start = 25, GL_Adjustment = 26,
        GL_In_exchange = 35, GL_Out_exchange = 36, GL_Notification_Minus = 37, GL_Notification_Pluse = 38, Expense = 47, InCome = 48, GLFinals_Accounts = 53,
        GLFinals_Balance = 54,
        GLFinals_title = 55,
        GLFinals_Inail_balance = 56,
        GLFinals_Calculation = 57
    }

    public enum BankLinksType { BankDomian = 1 }
    
    public enum AgentType { Supplier = 1, Customer = 2 }

    public enum HumanKind
    {

        Male = 1,
        Femal = 2
    }
    
    public enum AccountType
    {
        [Caption("Charts Of Account", "دليل الحسابات")]
        GlTree = 1,
        [Caption("Cost Centers", "مراكز التكلفة")]
        GlCC = 2,
        [Caption("Closing Account", "الحسابات الختامية")]
        GlFA = 3
    }

    public enum Text_Type
    {
        TextNumberSpecial,
        TextNumber,
        Number,
        NumberSpecial,
        Decimal,
        StringNoSpace,
        Email,
        URL
    }
  
    public enum language_type
    {
        arabic ,
        english ,
    }

}

