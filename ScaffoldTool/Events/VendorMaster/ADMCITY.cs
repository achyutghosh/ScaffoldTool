using System;
using System.Collections.Generic;

namespace ScaffoldTool.Events.VendorMaster
{
    public partial class ADMCITY
    {
        public ADMCITY()
        {
            FINGL = new HashSet<FINGL>();
            FINSLBCTNAMENavigation = new HashSet<FINSL>();
            FINSLSCTNAMENavigation = new HashSet<FINSL>();
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

        public virtual ICollection<FINGL> FINGL { get; set; }
        public virtual ICollection<FINSL> FINSLBCTNAMENavigation { get; set; }
        public virtual ICollection<FINSL> FINSLSCTNAMENavigation { get; set; }
    }
}
