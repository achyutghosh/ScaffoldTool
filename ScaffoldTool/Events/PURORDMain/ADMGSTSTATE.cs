using System;
using System.Collections.Generic;

namespace ScaffoldTool.Events.PURORDMain
{
    public partial class ADMGSTSTATE
    {
        public ADMGSTSTATE()
        {
            ADMGSTIN = new HashSet<ADMGSTIN>();
            ADMSITECP_GSTIN_STATE_CODENavigation = new HashSet<ADMSITE>();
            ADMSITESHIP_CP_GSTIN_STATE_CODENavigation = new HashSet<ADMSITE>();
            FINSL = new HashSet<FINSL>();
        }

        public string CODE { get; set; }
        public string NAME { get; set; }
        public string ABB { get; set; }

        public virtual ICollection<ADMGSTIN> ADMGSTIN { get; set; }
        public virtual ICollection<ADMSITE> ADMSITECP_GSTIN_STATE_CODENavigation { get; set; }
        public virtual ICollection<ADMSITE> ADMSITESHIP_CP_GSTIN_STATE_CODENavigation { get; set; }
        public virtual ICollection<FINSL> FINSL { get; set; }
    }
}
