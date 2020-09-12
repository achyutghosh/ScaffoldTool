using System;
using System.Collections.Generic;

namespace ScaffoldTool.Events.PURORDCancle
{
    public partial class INVSETMAIN
    {
        public INVSETMAIN()
        {
            PURORDCNLDET = new HashSet<PURORDCNLDET>();
        }

        public long SETCODE { get; set; }
        public DateTime SETDT { get; set; }
        public long? LOCCODE { get; set; }
        public long ECODE { get; set; }
        public long CREATOR_CMPCODE { get; set; }
        public string CANCEL_FLAG { get; set; }
        public string REM { get; set; }
        public string INTGCODE { get; set; }
        public string INTG_STG_ID { get; set; }
        public string UDFSTRIN01 { get; set; }
        public string UDFSTRIN02 { get; set; }
        public string UDFSTRIN03 { get; set; }
        public string UDFSTRIN04 { get; set; }
        public string UDFSTRIN05 { get; set; }
        public string UDFSTRIN06 { get; set; }
        public string UDFSTRIN07 { get; set; }
        public string UDFSTRIN08 { get; set; }
        public string UDFSTRIN09 { get; set; }
        public string UDFSTRIN010 { get; set; }
        public decimal? UDFNUM01 { get; set; }
        public decimal? UDFNUM02 { get; set; }
        public decimal? UDFNUM03 { get; set; }
        public decimal? UDFNUM04 { get; set; }
        public decimal? UDFNUM05 { get; set; }
        public DateTime? UDFDATE01 { get; set; }
        public DateTime? UDFDATE02 { get; set; }
        public DateTime? UDFDATE03 { get; set; }
        public DateTime? UDFDATE04 { get; set; }
        public DateTime? UDFDATE05 { get; set; }

        public virtual HRDEMP ECODENavigation { get; set; }
        public virtual ICollection<PURORDCNLDET> PURORDCNLDET { get; set; }
    }
}
