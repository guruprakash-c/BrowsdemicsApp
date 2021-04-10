using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browsdemics.DAL
{
    public class MediaEntity
    {
        public Guid ID { get; set; }
        public string User { get; set; }
        public string Media { get; set; }
        public string API { get; set; }
        public string Key { get; set; }
        public string Keywords { get; set; }
        public string Language { get; set; }
        public string Country { get; set; }
        public string Category { get; set; }
        public string FindIn { get; set; }
        public Nullable<DateTime> FromDate { get; set; }
        public Nullable<DateTime> ToDate { get; set; }
        public string SortBy { get; set; }
        public string IsNull { get; set; }
        public int Max { get; set; }
        public string Type { get; set; }
        public bool Status { get; set; }
    }
}
