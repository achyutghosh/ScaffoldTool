using System;
using System.Collections.Generic;

namespace ScaffoldTool.Events.VendorMaster
{
    public partial class SALTERMMAIN
    {
        public SALTERMMAIN()
        {
            FINSL = new HashSet<FINSL>();
        }

        public long SALTERMCODE { get; set; }
        public string SALTERMNAME { get; set; }
        public long? TERMGRPCODE { get; set; }
        public string EXT { get; set; }
        public long FINTRADEGRP_CODE { get; set; }
        public string HEADER_LEVEL_ISCHANGEABLE { get; set; }
        public string LINE_LEVEL_ISCHANGEABLE { get; set; }
        public long? SALES_GLCODE { get; set; }
        public long? SALES_SLCODE { get; set; }
        public long? SALES_RETURN_GLCODE { get; set; }
        public long? SALES_RETURN_SLCODE { get; set; }

        public virtual FINTRADEGRP FINTRADEGRP_CODENavigation { get; set; }
        public virtual FINGL SALES_GLCODENavigation { get; set; }
        public virtual FINGL SALES_RETURN_GLCODENavigation { get; set; }
        public virtual FINSL SALES_RETURN_SLCODENavigation { get; set; }
        public virtual FINSL SALES_SLCODENavigation { get; set; }
        public virtual ICollection<FINSL> FINSL { get; set; }
    }
}
