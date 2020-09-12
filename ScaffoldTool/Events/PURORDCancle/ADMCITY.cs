using System;
using System.Collections.Generic;

namespace ScaffoldTool.Events.PURORDCancle
{
    public partial class ADMCITY
    {
        public ADMCITY()
        {
            ADMSITE = new HashSet<ADMSITE>();
        }

        public string CTNAME { get; set; }
        public string STNAME { get; set; }
        public string CNNAME { get; set; }
        public string ZONE { get; set; }
        public string CLASS { get; set; }
        public string STD { get; set; }
        public string ISD { get; set; }
        public string EXT { get; set; }
        public long? CMPCODE { get; set; }
        public string DIST { get; set; }
        public long CODE { get; set; }

        public virtual ICollection<ADMSITE> ADMSITE { get; set; }
    }
}
