using System;
using System.Collections.Generic;

namespace ScaffoldTool.Events.PURORDMain
{
    public partial class ADMOU
    {
        public ADMOU()
        {
            ADMGSTIN = new HashSet<ADMGSTIN>();
            ADMSITE = new HashSet<ADMSITE>();
            PURORDMAIN = new HashSet<PURORDMAIN>();
        }

        public long CODE { get; set; }
        public string NAME { get; set; }
        public string SHRTNAME { get; set; }
        public long? ADMCMPTAX_CODE { get; set; }
        public string ADDRESS { get; set; }
        public string CTNAME { get; set; }
        public string OPH1 { get; set; }
        public string OPH2 { get; set; }
        public string OPH3 { get; set; }
        public string RPH1 { get; set; }
        public string MOBILE { get; set; }
        public string FAX { get; set; }
        public string EMAIL1 { get; set; }
        public string EMAIL2 { get; set; }
        public string WEBSITE { get; set; }
        public string CONTACT_PERSON { get; set; }
        public string LSTNO { get; set; }
        public string CSTNO { get; set; }
        public string EXT { get; set; }
        public string PIN { get; set; }
        public string STNAME { get; set; }
        public string CNNAME { get; set; }
        public long? INLOCCODE { get; set; }
        public long? OUTLOCCODE { get; set; }
        public long? PKGLOCCODE { get; set; }
        public long? TRANSFERIN_GLCODE { get; set; }
        public long? TRANSFERIN_SLCODE { get; set; }
        public long? TRANSFEROUT_GLCODE { get; set; }
        public long? TRANSFEROUT_SLCODE { get; set; }
        public long? TRANSIT_GLCODE { get; set; }
        public long? TRANSIT_SLCODE { get; set; }
        public long? TRANSITDIFF_GLCODE { get; set; }
        public long? TRANSITDIFF_SLCODE { get; set; }
        public long? GVCONTROL_GLCODE { get; set; }
        public long? GVDISCOUNT_GLCODE { get; set; }
        public long? ROUNDOFF_GLCODE { get; set; }
        public long? CREDITNOTE_GLCODE { get; set; }
        public long? REDEMPTION_GLCODE { get; set; }
        public long? DEBITNOTE_GLCODE { get; set; }
        public long? CONSIGNMENTSALE_GLCODE { get; set; }
        public long? CONSIGNMENTSALE_SLCODE { get; set; }
        public long? DEFAULT_HO_SITE { get; set; }
        public DateTime? SERVICETAXDATE { get; set; }
        public string SERVICETAXNO { get; set; }
        public string CINNO { get; set; }
        public string EXC { get; set; }
        public string EXP { get; set; }
        public string TLNO { get; set; }
        public string TANWARD { get; set; }
        public string TANNO { get; set; }
        public string PAN { get; set; }
        public DateTime CREATED_ON { get; set; }
        public long CREATED_BY { get; set; }
        public DateTime? LASTMODIFIED_ON { get; set; }
        public long? LASTMODIFIED_BY { get; set; }
        public DateTime? EXT_ON { get; set; }
        public long? EXT_BY { get; set; }
        public string LOGO_NAME { get; set; }

        public virtual FINSL CONSIGNMENTSALE_SLCODENavigation { get; set; }
        public virtual ADMSITE DEFAULT_HO_SITENavigation { get; set; }
        public virtual FINSL TRANSFERIN_SLCODENavigation { get; set; }
        public virtual FINSL TRANSFEROUT_SLCODENavigation { get; set; }
        public virtual FINSL TRANSITDIFF_SLCODENavigation { get; set; }
        public virtual FINSL TRANSIT_SLCODENavigation { get; set; }
        public virtual ICollection<ADMGSTIN> ADMGSTIN { get; set; }
        public virtual ICollection<ADMSITE> ADMSITE { get; set; }
        public virtual ICollection<PURORDMAIN> PURORDMAIN { get; set; }
    }
}
