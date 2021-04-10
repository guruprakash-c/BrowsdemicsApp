using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browsdemics.Common
{
    public class LogHandler
    {
        Logger loggerx = LogManager.GetCurrentClassLogger();
        public void AddLogs(Exception exception,string formMessage="")
        {
            if (!string.IsNullOrEmpty(formMessage))
            {
                loggerx.Error(exception, formMessage);
            }
            else
            {
                loggerx.Error(exception);
            }
        }
    }
}
