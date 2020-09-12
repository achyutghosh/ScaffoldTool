using System;
using System.Collections.Generic;

namespace ScaffoldTool.Events.PURORDCancle
{
    public partial class PURORDMAIN
    {
        public PURORDMAIN()
        {
            PURORDCNLDET = new HashSet<PURORDCNLDET>();
        }

        public long ORDCODE { get; set; }
        public int ORDNO { get; set; }
        public DateTime ORDDT { get; set; }
        public long PCODE { get; set; }
        public string DOCNO { get; set; }
        public long? AGCODE { get; set; }
        public decimal? AGRATE { get; set; }
        public long? TRPCODE { get; set; }
        public string STAT { get; set; }
        public long? AUTHORCODE { get; set; }
        public string REM { get; set; }
        public int YCODE { get; set; }
        public long ECODE { get; set; }
        public DateTime? TIME { get; set; }
        public string TEMPLATE_FLG { get; set; }
        public DateTime? DTFR { get; set; }
        public DateTime? DTTO { get; set; }
        public DateTime? LAST_ACCESS_TIME { get; set; }
        public long? LAST_ACCESS_ECODE { get; set; }
        public long? DESCCMPCODE { get; set; }
        public string PAYTERM { get; set; }
        public long? ORDCMPCODE { get; set; }
        public decimal? TAXCHGPER { get; set; }
        public decimal? DISCHGPER { get; set; }
        public string WHETHER_CONSIGNMENT { get; set; }
        public long? TXNCODE { get; set; }
        public long? CREATORCMPCODE { get; set; }
        public int? REFORDNO { get; set; }
        public long? DOCCODE { get; set; }
        public string SCHEME_DOCNO { get; set; }
        public string REFSCHEME_DOCNO { get; set; }
        public long? ADMOU_CODE { get; set; }
        public long? MRCHNDSRCODE { get; set; }
        public string PRINT_LABEL { get; set; }
        public long FINTRADEGRP_CODE { get; set; }
        public decimal? GRSAMT { get; set; }
        public decimal? CHGAMT { get; set; }
        public decimal? NETAMT { get; set; }
        public long ADMCURRENCY_CODE { get; set; }
        public double? EXRATE { get; set; }
        public long ADMSITE_CODE { get; set; }
        public long? FORMCODE { get; set; }
        public bool? ENABLE_LGT_TRACK { get; set; }
        public bool? SHIPSTATUS { get; set; }
        public long? PURTERMCODE { get; set; }
        public string SET_APPLICABLE { get; set; }
        public string INTGCODE { get; set; }
        public string INTG_STG_ID { get; set; }
        public string UDFSTRING01 { get; set; }
        public string UDFSTRING02 { get; set; }
        public string UDFSTRING03 { get; set; }
        public string UDFSTRING04 { get; set; }
        public string UDFSTRING05 { get; set; }
        public string UDFSTRING06 { get; set; }
        public string UDFSTRING07 { get; set; }
        public string UDFSTRING08 { get; set; }
        public string UDFSTRING09 { get; set; }
        public string UDFSTRING10 { get; set; }
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
        public DateTime? AUTHORIZATIONTIME { get; set; }
        public string SOURCE_ORD { get; set; }
        public long DATAVERSION { get; set; }
        public long? TEMP_DOCCODE { get; set; }

        public virtual ADMOU ADMOU_CODENavigation { get; set; }
        public virtual ADMSITE ADMSITE_CODENavigation { get; set; }
        public virtual HRDEMP AUTHORCODENavigation { get; set; }
        public virtual ADMDOCSCHEME DOCCODENavigation { get; set; }
        public virtual HRDEMP ECODENavigation { get; set; }
        public virtual HRDEMP LAST_ACCESS_ECODENavigation { get; set; }
        public virtual HRDEMP MRCHNDSRCODENavigation { get; set; }
        public virtual ICollection<PURORDCNLDET> PURORDCNLDET { get; set; }
    }
}
