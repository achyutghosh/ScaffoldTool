using System;
using System.Collections.Generic;

namespace ScaffoldTool.Events.PURORDMain
{
    public partial class FINTRADEGRP
    {
        public FINTRADEGRP()
        {
            ADMSITE = new HashSet<ADMSITE>();
            FINSLFINTRADEGRP_CODENavigation = new HashSet<FINSL>();
            FINSLSALTRADEGRP_CODENavigation = new HashSet<FINSL>();
            PURORDMAIN = new HashSet<PURORDMAIN>();
        }

        public long CODE { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string EXT { get; set; }
        public long? CMPCODE { get; set; }

        public virtual ICollection<ADMSITE> ADMSITE { get; set; }
        public virtual ICollection<FINSL> FINSLFINTRADEGRP_CODENavigation { get; set; }
        public virtual ICollection<FINSL> FINSLSALTRADEGRP_CODENavigation { get; set; }
        public virtual ICollection<PURORDMAIN> PURORDMAIN { get; set; }
    }
}
