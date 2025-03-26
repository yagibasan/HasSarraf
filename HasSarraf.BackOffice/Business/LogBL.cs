using log4net;
using System;
using System.Diagnostics;
using System.Reflection;

namespace HasSarraf.BackOffice.Business
{
    public class LogBL
    {
 
        private static LogBL instance;

        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
         private string seperator = Environment.NewLine; 

        public static LogBL GetInstance()
        {
            if (instance == null)
            {
                log.Info("Application started");
                instance = new LogBL(); 
                return instance;
            }

            return instance;
        } 
        public void Info(string tag, string message)
        {
            log.Info(string.Format("{0}\t{1}", tag.ToUpperInvariant(), message));
        }

        public void Error(string tag, string message, Exception ex, bool sendToRaven=true)
        { 
            log.Error(string.Format("{0}\t{1}", tag.ToUpperInvariant(), message), ex);
        }

        public void Error(string error, Exception ex, bool sendToRaven=true)
        {
            log.Error(error, ex);
        }

       
    }
}