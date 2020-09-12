using System;
using System.Collections.Generic;

namespace ScaffoldTool.Events.PURORDCancle
{
    public partial class PURORDCNLDET
    {
        public long CNLCODE { get; set; }
        public long ORDCODE { get; set; }
        public string ICODE { get; set; }
        public decimal? CNLQTY { get; set; }
        public decimal? RATE { get; set; }
        public long CODE { get; set; }
        public long? INVSETMAIN_CODE { get; set; }

        public virtual PURORDCNLMAIN CNLCODENavigation { get; set; }
        public virtual INVITEM ICODENavigation { get; set; }
        public virtual INVSETMAIN INVSETMAIN_CODENavigation { get; set; }
        public virtual PURORDMAIN ORDCODENavigation { get; set; }
    }
}
