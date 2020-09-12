using System;
using System.Collections.Generic;

namespace ScaffoldTool.Events.VendorMaster
{
    public partial class PURTERMMAIN
    {
        public PURTERMMAIN()
        {
            FINSL = new HashSet<FINSL>();
        }

        public long CODE { get; set; }
        public string NAME { get; set; }
        public string EXT { get; set; }
        public long FINTRADEGRP_CODE { get; set; }
        public string HEADER_LEVEL_ISCHANGEABLE { get; set; }
        public string LINE_LEVEL_ISCHANGEABLE { get; set; }
        public long? PURCHASE_GLCODE { get; set; }
        public long? PURCHASE_SLCODE { get; set; }
        public long? PURCHASE_RETURN_GLCODE { get; set; }
        public long? PURCHASE_RETURN_SLCODE { get; set; }

        public virtual FINTRADEGRP FINTRADEGRP_CODENavigation { get; set; }
        public virtual FINGL PURCHASE_GLCODENavigation { get; set; }
        public virtual FINGL PURCHASE_RETURN_GLCODENavigation { get; set; }
        public virtual FINSL PURCHASE_RETURN_SLCODENavigation { get; set; }
        public virtual FINSL PURCHASE_SLCODENavigation { get; set; }
        public virtual ICollection<FINSL> FINSL { get; set; }
    }
}
