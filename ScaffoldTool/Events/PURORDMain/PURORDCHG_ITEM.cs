using System;
using System.Collections.Generic;

namespace ScaffoldTool.Events.PURORDMain
{
    public partial class PURORDCHG_ITEM
    {
        public long? ORDCODE { get; set; }
        public long? PURORDDET_CODE { get; set; }
        public int? SEQ { get; set; }
        public long? CHGCODE { get; set; }
        public decimal? RATE { get; set; }
        public string BASIS { get; set; }
        public string SIGN { get; set; }
        public decimal? CHGAMT { get; set; }
        public decimal? APPAMT { get; set; }
        public string FORMULAE { get; set; }
        public string OPERATION_LEVEL { get; set; }
        public string ISTAX { get; set; }
        public string SOURCE { get; set; }
        public long CODE { get; set; }
        public string GST_COMPONENT { get; set; }
        public string ISREVERSE { get; set; }

        public virtual PURORDMAIN ORDCODENavigation { get; set; }
        public virtual PURORDDET PURORDDET_CODENavigation { get; set; }
    }
}
