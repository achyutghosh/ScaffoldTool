using System;
using System.Collections.Generic;

namespace ScaffoldTool.Events.PURORDCancle
{
    public partial class ADMSITE
    {
        public ADMSITE()
        {
            ADMOU = new HashSet<ADMOU>();
            PURORDCNLMAIN = new HashSet<PURORDCNLMAIN>();
            PURORDMAIN = new HashSet<PURORDMAIN>();
        }

        public long CODE { get; set; }
        public string NAME { get; set; }
        public long? SLCODE { get; set; }
        public long CMPCODE { get; set; }
        public string SHRTNAME { get; set; }
        public string ADDRESS { get; set; }
        public string CTNAME { get; set; }
        public string PIN { get; set; }
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
        public DateTime? LSTDATE { get; set; }
        public string CSTNO { get; set; }
        public DateTime? CSTDATE { get; set; }
        public long? TERMCODE { get; set; }
        public string ISSECONDARY { get; set; }
        public long? TRPCODE { get; set; }
        public string LGT_APPL { get; set; }
        public string PERMIT_APPL { get; set; }
        public int? TRANSIT_DAYS { get; set; }
        public decimal? STORE_TARGET_SALES { get; set; }
        public int? STORE_SIZE { get; set; }
        public DateTime? STORE_STARTDT { get; set; }
        public DateTime? STORE_CLOSEDT { get; set; }
        public long? STORE_LOCCODE { get; set; }
        public string ISPOS { get; set; }
        public long? PSITE_GROUP_CODE { get; set; }
        public long? PSITE_TRANSIT_LOCCODE { get; set; }
        public string PSITE_INITIAL { get; set; }
        public long? PSITE_ADMCMPTAX_CODE { get; set; }
        public string EXT { get; set; }
        public long? PSITE_LOCALPOLICY_CODE { get; set; }
        public long? PSITE_ALLOCATION_CODE { get; set; }
        public string PSITE_ISPUBLISHED { get; set; }
        public string PSITE_KEY { get; set; }
        public long? PSITE_PROMO_ALLOCATION_CODE { get; set; }
        public string PSITE_STOPSYNC { get; set; }
        public long DATAVERSION { get; set; }
        public long? PSITE_INTRANSIT_LOCCODE { get; set; }
        public string CP { get; set; }
        public string VERSION { get; set; }
        public string ISPROMOSEND_BLOCKED { get; set; }
        public string PRICETYPE { get; set; }
        public double? PRICEFACTOR { get; set; }
        public DateTime? OPERATIONSTARTDATE { get; set; }
        public string PSITE_TIMEZONE { get; set; }
        public string SITETYPE { get; set; }
        public long? ADMOU_CODE { get; set; }
        public long? PRICELIST_CODE { get; set; }
        public string OUT_LGT_APPL { get; set; }
        public string OUT_PERMIT_APPL { get; set; }
        public string GATEIN_APPL { get; set; }
        public long? INLOCCODE { get; set; }
        public long? OUTLOCCODE { get; set; }
        public string PSITE_STOCKPOINT_CODE { get; set; }
        public long? PSITE_SI_ALLOCATION_CODE { get; set; }
        public long? SALTRADEGRP_CODE { get; set; }
        public long? SALFORMCODE { get; set; }
        public bool ISCENTRALLYMANAGED { get; set; }
        public bool ISSALESPERSONMANAGED { get; set; }
        public DateTime? LASTSYNCENDTIME { get; set; }
        public DateTime? LASTFULLBACKUPENDTIME { get; set; }
        public DateTime? LASTDIFFBACKUPENDTIME { get; set; }
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
        public string UDFSTRING11 { get; set; }
        public string UDFSTRING12 { get; set; }
        public string UDFSTRING13 { get; set; }
        public string UDFSTRING14 { get; set; }
        public string UDFSTRING15 { get; set; }
        public string REPORTNAME { get; set; }
        public string RESERVE_INV { get; set; }
        public long? DEFAULT_PICKLIST_RULE { get; set; }
        public DateTime? CP_GSTIN_DATE { get; set; }
        public long? ADMGSTIN_CODE { get; set; }
        public string CP_GSTIN_NO { get; set; }
        public string CP_GSTIN_STATE_CODE { get; set; }
        public string SITEDOCIN { get; set; }
        public string ISBILLINGSHIPPINGSAME { get; set; }
        public string SHIP_LEGAL_NAME { get; set; }
        public string SHIP_CINNO { get; set; }
        public string SHIP_ADDRESS { get; set; }
        public string SHIP_CTNAME { get; set; }
        public string SHIP_PIN { get; set; }
        public string SHIP_OPH1 { get; set; }
        public string SHIP_OPH2 { get; set; }
        public string SHIP_OPH3 { get; set; }
        public string SHIP_RPH1 { get; set; }
        public string SHIP_MOBILE { get; set; }
        public string SHIP_FAX { get; set; }
        public string SHIP_EMAIL1 { get; set; }
        public string SHIP_EMAIL2 { get; set; }
        public string SHIP_WEBSITE { get; set; }
        public string SHIP_CONTACT_PERSON { get; set; }
        public long? SHIP_CP_CATEGORY_CODE { get; set; }
        public string SHIP_CP_GSTIN_NO { get; set; }
        public string SHIP_CP_GSTIN_STATE_CODE { get; set; }
        public DateTime? SHIP_CP_GSTIN_DATE { get; set; }
        public long? ADMISD_CODE { get; set; }
        public bool ISGLOBALPOSRETURNALLOWED { get; set; }
        public string INSTALLATION_TYPE { get; set; }

        public virtual ADMGSTIN ADMGSTIN_CODENavigation { get; set; }
        public virtual ADMOU ADMOU_CODENavigation { get; set; }
        public virtual ADMGSTSTATE CP_GSTIN_STATE_CODENavigation { get; set; }
        public virtual ADMCITY CTNAMENavigation { get; set; }
        public virtual ADMGSTSTATE SHIP_CP_GSTIN_STATE_CODENavigation { get; set; }
        public virtual ADMGSTIN ADMGSTIN { get; set; }
        public virtual ICollection<ADMOU> ADMOU { get; set; }
        public virtual ICollection<PURORDCNLMAIN> PURORDCNLMAIN { get; set; }
        public virtual ICollection<PURORDMAIN> PURORDMAIN { get; set; }
    }
}
