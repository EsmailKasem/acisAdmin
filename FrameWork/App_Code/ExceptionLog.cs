
using System.IO;
using System;
using System.Collections.Generic;
using System.Reflection;
namespace FrameWork
{
    public static class ExceptionHelper
    {
        public static void SaveExceptionLog(string Message, string ErrorType, string LineNumber, string MethodName, string ClassName, string NameSpaceName)
        {
            string FilePath = "ExceptionLog.txt";
            if (!File.Exists(FilePath))
                File.Create(FilePath).Close();

            string ExceptionTime = string.Format(@"[{0}-{1}-{2} {3}:{4}:{5}]"
                , DateTime.Now.Day.ToString("00"), DateTime.Now.Month.ToString("00"), DateTime.Now.Year.ToString(),
                DateTime.Now.Hour.ToString("00"), DateTime.Now.Minute.ToString("00"), DateTime.Now.Second.ToString("00"));

            List<string> ExceptionLog = new List<string>();
            
            ExceptionLog.Add(string.Format("ExceptionTime   : {0}", ExceptionTime));
            ExceptionLog.Add(string.Format("Error Message   : {0}", Message) );
            ExceptionLog.Add(string.Format("Error Type      : {0}", ErrorType) );
            ExceptionLog.Add(string.Format("Line Number     : {0}", LineNumber) );
            ExceptionLog.Add(string.Format("Method Name     : {0}", MethodName) );
            ExceptionLog.Add(string.Format("Class Name      : {0}", ClassName) );
            ExceptionLog.Add(string.Format("Name Space Name : {0}", NameSpaceName));
            ExceptionLog.Add("---------------------------------------------------------------------------------------");


            File.AppendAllLines(FilePath, ExceptionLog);
        }

        public static void SaveExceptionLog(this System.Exception ex, MethodBase MethodBioData)
        {
            FrameWork.ExceptionHelper.SaveExceptionLog(ex.Message.ToString()
                    , ex.TargetSite.DeclaringType.ToString(),
                    ex.StackTrace.Substring(ex.StackTrace.Length - 7, 7)
                    ,MethodBioData.Name
                    , MethodBioData.DeclaringType.ToString().Substring(0, MethodBioData.DeclaringType.ToString().ToString().IndexOf('.'))
                    , MethodBioData.DeclaringType.ToString().Substring(MethodBioData.DeclaringType.ToString().ToString().IndexOf('.') + 1));
        }
}
}
