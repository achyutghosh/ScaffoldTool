using System;
using System.Collections.Generic;

namespace ScaffoldTool.Events.VendorMaster
{
    public partial class FINFORM
    {
        public FINFORM()
        {
            FINSLPURFORMCODENavigation = new HashSet<FINSL>();
            FINSLSALFORMCODENavigation = new HashSet<FINSL>();
        }

        public long FORMCODE { get; set; }
        public string FORMNAME { get; set; }
        public string FORMDEPT { get; set; }
        public string EXT { get; set; }
        public long? CMPCODE { get; set; }

        public virtual ICollection<FINSL> FINSLPURFORMCODENavigation { get; set; }
        public virtual ICollection<FINSL> FINSLSALFORMCODENavigation { get; set; }
    }
}
