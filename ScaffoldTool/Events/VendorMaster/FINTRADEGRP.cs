using System;
using System.Collections.Generic;

namespace ScaffoldTool.Events.VendorMaster
{
    public partial class FINTRADEGRP
    {
        public FINTRADEGRP()
        {
            FINSLFINTRADEGRP_CODENavigation = new HashSet<FINSL>();
            FINSLSALTRADEGRP_CODENavigation = new HashSet<FINSL>();
            PURTERMMAIN = new HashSet<PURTERMMAIN>();
            SALTERMMAIN = new HashSet<SALTERMMAIN>();
        }

        public long CODE { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string EXT { get; set; }
        public long? CMPCODE { get; set; }

        public virtual ICollection<FINSL> FINSLFINTRADEGRP_CODENavigation { get; set; }
        public virtual ICollection<FINSL> FINSLSALTRADEGRP_CODENavigation { get; set; }
        public virtual ICollection<PURTERMMAIN> PURTERMMAIN { get; set; }
        public virtual ICollection<SALTERMMAIN> SALTERMMAIN { get; set; }
    }
}
