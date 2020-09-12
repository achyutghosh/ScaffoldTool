using System;
using System.Collections.Generic;

namespace ScaffoldTool.Events.VendorMaster
{
    public partial class ADMCMPTAX
    {
        public ADMCMPTAX()
        {
            FINSL = new HashSet<FINSL>();
        }

        public long CODE { get; set; }
        public string NAME { get; set; }
        public string EXT { get; set; }
        public long ECODE { get; set; }
        public DateTime TIME { get; set; }
        public long LAST_ACCESS_ECODE { get; set; }
        public DateTime LAST_ACCESS_TIME { get; set; }
        public int? TAXREVERSALDAYS { get; set; }
        public int? TAXREVERSALDAYS_PROC { get; set; }

        public virtual ICollection<FINSL> FINSL { get; set; }
    }
}
