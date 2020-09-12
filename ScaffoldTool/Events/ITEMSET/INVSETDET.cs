using System;
using System.Collections.Generic;

namespace ScaffoldTool.Events.ITEMSET
{
    public partial class INVSETDET
    {
        public long SETCODE { get; set; }
        public string ICODE { get; set; }
        public decimal QTY { get; set; }
        public long CODE { get; set; }
        public string INTGCODE { get; set; }
        public string INTG_STG_ID { get; set; }

        public virtual INVITEM ICODENavigation { get; set; }
        public virtual INVSETMAIN SETCODENavigation { get; set; }
    }
}
