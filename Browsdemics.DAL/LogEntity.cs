using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browsdemics.DAL
{
    public class LogEntity
    {
        public int LogID { get; set; }
        public Nullable<DateTime> LoggedOn { get; set; }
        public string Severity { get; set; }
        public string Domain { get; set; }
        public string Category { get; set; }
        public string Log { get; set; }
        public string Message { get; set; }
        public string Trace { get; set; }
        public bool Status { get; set; }
    }
}
