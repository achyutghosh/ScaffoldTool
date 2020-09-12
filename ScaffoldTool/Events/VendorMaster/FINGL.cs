using System;
using System.Collections.Generic;

namespace ScaffoldTool.Events.VendorMaster
{
    public partial class FINGL
    {
        public FINGL()
        {
            FINSLCONSIGNMENT_GLCODENavigation = new HashSet<FINSL>();
            FINSLCONSIGNMENT_SALES_GLCODENavigation = new HashSet<FINSL>();
            FINSLCONSIGNMENT_TRNSFR_GLCODENavigation = new HashSet<FINSL>();
            FINSLGLCODENavigation = new HashSet<FINSL>();
            FINSLPURCHASE_GLCODENavigation = new HashSet<FINSL>();
            FINSLPURCHASE_RETURN_GLCODENavigation = new HashSet<FINSL>();
            FINSLSALES_GLCODENavigation = new HashSet<FINSL>();
            FINSLSALES_RETURN_GLCODENavigation = new HashSet<FINSL>();
            FINSLTRANSITDIFF_GLCODENavigation = new HashSet<FINSL>();
            FINSLTRANSIT_GLCODENavigation = new HashSet<FINSL>();
            FINSLVATEXP_GLCODENavigation = new HashSet<FINSL>();
            PURTERMMAINPURCHASE_GLCODENavigation = new HashSet<PURTERMMAIN>();
            PURTERMMAINPURCHASE_RETURN_GLCODENavigation = new HashSet<PURTERMMAIN>();
            SALTERMMAINSALES_GLCODENavigation = new HashSet<SALTERMMAIN>();
            SALTERMMAINSALES_RETURN_GLCODENavigation = new HashSet<SALTERMMAIN>();
        }

        public long GLCODE { get; set; }
        public string GLNAME { get; set; }
        public string ABBRE { get; set; }
        public string TYPE { get; set; }
        public long GRPCODE { get; set; }
        public string ADDR { get; set; }
        public string CTNAME { get; set; }
        public string PIN { get; set; }
        public string PH1 { get; set; }
        public string PH2 { get; set; }
        public string PH3 { get; set; }
        public string PH4 { get; set; }
        public string FX1 { get; set; }
        public string FX2 { get; set; }
        public string EMAIL { get; set; }
        public string WEBSITE { get; set; }
        public string CP { get; set; }
        public string LSTNO { get; set; }
        public string CSTNO { get; set; }
        public string PAN { get; set; }
        public decimal? INTRATE { get; set; }
        public string SRCTYPE { get; set; }
        public string COSTAPP { get; set; }
        public decimal? BRSAMT { get; set; }
        public string EXT { get; set; }
        public long? TDSSRCCODE { get; set; }
        public string CHQLABEL { get; set; }
        public long? CMPCODE { get; set; }
        public string SLAPP { get; set; }
        public long? ADMSITE_CODE_OWNER { get; set; }
        public int GLSEQ { get; set; }

        public virtual ADMCITY CTNAMENavigation { get; set; }
        public virtual ICollection<FINSL> FINSLCONSIGNMENT_GLCODENavigation { get; set; }
        public virtual ICollection<FINSL> FINSLCONSIGNMENT_SALES_GLCODENavigation { get; set; }
        public virtual ICollection<FINSL> FINSLCONSIGNMENT_TRNSFR_GLCODENavigation { get; set; }
        public virtual ICollection<FINSL> FINSLGLCODENavigation { get; set; }
        public virtual ICollection<FINSL> FINSLPURCHASE_GLCODENavigation { get; set; }
        public virtual ICollection<FINSL> FINSLPURCHASE_RETURN_GLCODENavigation { get; set; }
        public virtual ICollection<FINSL> FINSLSALES_GLCODENavigation { get; set; }
        public virtual ICollection<FINSL> FINSLSALES_RETURN_GLCODENavigation { get; set; }
        public virtual ICollection<FINSL> FINSLTRANSITDIFF_GLCODENavigation { get; set; }
        public virtual ICollection<FINSL> FINSLTRANSIT_GLCODENavigation { get; set; }
        public virtual ICollection<FINSL> FINSLVATEXP_GLCODENavigation { get; set; }
        public virtual ICollection<PURTERMMAIN> PURTERMMAINPURCHASE_GLCODENavigation { get; set; }
        public virtual ICollection<PURTERMMAIN> PURTERMMAINPURCHASE_RETURN_GLCODENavigation { get; set; }
        public virtual ICollection<SALTERMMAIN> SALTERMMAINSALES_GLCODENavigation { get; set; }
        public virtual ICollection<SALTERMMAIN> SALTERMMAINSALES_RETURN_GLCODENavigation { get; set; }
    }
}
