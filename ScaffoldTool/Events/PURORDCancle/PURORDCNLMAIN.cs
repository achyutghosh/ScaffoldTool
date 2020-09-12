using System;
using System.Collections.Generic;

namespace ScaffoldTool.Events.PURORDCancle
{
    public partial class PURORDCNLMAIN
    {
        public PURORDCNLMAIN()
        {
            PURORDCNLDET = new HashSet<PURORDCNLDET>();
        }

        public long CNLCODE { get; set; }
        public int CNLNO { get; set; }
        public DateTime CNLDT { get; set; }
        public string DOCNO { get; set; }
        public string REM { get; set; }
        public int YCODE { get; set; }
        public long ECODE { get; set; }
        public DateTime? TIME { get; set; }
        public DateTime? LAST_ACCESS_TIME { get; set; }
        public long? LAST_ACCESS_ECODE { get; set; }
        public long? ADMOU_CODE { get; set; }
        public long? DOCCODE { get; set; }
        public string SCHEME_DOCNO { get; set; }
        public long ADMSITE_CODE { get; set; }
        public string ENTRY_SOURCE { get; set; }
        public string SET_APPLICABLE { get; set; }

        public virtual ADMOU ADMOU_CODENavigation { get; set; }
        public virtual ADMSITE ADMSITE_CODENavigation { get; set; }
        public virtual ADMDOCSCHEME DOCCODENavigation { get; set; }
        public virtual HRDEMP ECODENavigation { get; set; }
        public virtual HRDEMP LAST_ACCESS_ECODENavigation { get; set; }
        public virtual ICollection<PURORDCNLDET> PURORDCNLDET { get; set; }
    }
}
