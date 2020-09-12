using System;
using System.Collections.Generic;

namespace ScaffoldTool.Events.ITEMSET
{
    public partial class HRDEMP
    {
        public HRDEMP()
        {
            INVSETMAIN = new HashSet<INVSETMAIN>();
        }

        public long ECODE { get; set; }
        public string FNAME { get; set; }
        public string ENO { get; set; }
        public string ABBRE { get; set; }
        public long? DEPTCODE { get; set; }
        public long? RLCODE { get; set; }
        public string PASS { get; set; }
        public int? LOCDAYS { get; set; }
        public string REM { get; set; }
        public string EXT { get; set; }
        public decimal? FLEX_FIELD_KEY { get; set; }
        public long? PROFCODE { get; set; }
        public string SALESMAN { get; set; }
        public string USERTYPE { get; set; }
        public string ALLOW_LAST_FY_DAY_MODE { get; set; }
        public string REPORTROLE { get; set; }
        public bool? IS_APIUSER { get; set; }
        public string APIKEY { get; set; }

        public virtual ICollection<INVSETMAIN> INVSETMAIN { get; set; }
    }
}
