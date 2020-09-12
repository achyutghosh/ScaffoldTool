using System;
using System.Collections.Generic;

namespace ScaffoldTool.Events.PURORDMain
{
    public partial class PURORDDET
    {
        public PURORDDET()
        {
            PURORDCHG_ITEM = new HashSet<PURORDCHG_ITEM>();
        }

        public long ORDCODE { get; set; }
        public string ICODE { get; set; }
        public decimal? ORDQTY { get; set; }
        public decimal? CNLQTY { get; set; }
        public decimal? RATE { get; set; }
        public decimal? RCQTY { get; set; }
        public decimal? OQTY { get; set; }
        public string REM { get; set; }
        public long CODE { get; set; }
        public decimal? DISCOUNT { get; set; }
        public decimal? TAXAMT { get; set; }
        public decimal? TAXCHGPER { get; set; }
        public decimal? DISCHGPER { get; set; }
        public decimal? NETAMT { get; set; }
        public long? EXCISEMAIN_CODE { get; set; }
        public string EX_BASIS { get; set; }
        public decimal? EX_EFFRATE { get; set; }
        public decimal? EX_ABTFACTOR { get; set; }
        public decimal? EX_DUTYFACTOR { get; set; }
        public decimal? EX_CESSFACTOR { get; set; }
        public int? EX_ROUNDOFF { get; set; }
        public decimal? EX_APPAMT { get; set; }
        public decimal? EX_DUTYAMT { get; set; }
        public decimal? EX_CESSAMT { get; set; }
        public decimal? RSP { get; set; }
        public long? INVSETMAIN_CODE { get; set; }
        public string INTGCODE { get; set; }
        public string INTG_STG_ID { get; set; }
        public double? EX_APPLICABLE_FROM { get; set; }
        public double? TOLERANCE { get; set; }
        public long DATAVERSION { get; set; }

        public virtual INVITEM ICODENavigation { get; set; }
        public virtual PURORDMAIN ORDCODENavigation { get; set; }
        public virtual ICollection<PURORDCHG_ITEM> PURORDCHG_ITEM { get; set; }
    }
}
