using System;
using System.Collections.Generic;

namespace ScaffoldTool.Events.VendorMaster
{
    public partial class ADMGSTSTATE
    {
        public ADMGSTSTATE()
        {
            FINSL = new HashSet<FINSL>();
        }

        public string CODE { get; set; }
        public string NAME { get; set; }
        public string ABB { get; set; }

        public virtual ICollection<FINSL> FINSL { get; set; }
    }
}
