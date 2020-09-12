using System;
using System.Collections.Generic;

namespace ScaffoldTool.Events.VendorMaster
{
    public partial class FINSL
    {
        public FINSL()
        {
            InverseAGCODENavigation = new HashSet<FINSL>();
            InverseCONSIGNMENT_SALES_SLCODENavigation = new HashSet<FINSL>();
            InverseCONSIGNMENT_SLCODENavigation = new HashSet<FINSL>();
            InverseCONSIGNMENT_TRNSFR_SLCODENavigation = new HashSet<FINSL>();
            InversePURCHASE_RETURN_SLCODENavigation = new HashSet<FINSL>();
            InversePURCHASE_SLCODENavigation = new HashSet<FINSL>();
            InverseSALES_RETURN_SLCODENavigation = new HashSet<FINSL>();
            InverseSALES_SLCODENavigation = new HashSet<FINSL>();
            InverseTRANSITDIFF_SLCODENavigation = new HashSet<FINSL>();
            InverseTRANSIT_SLCODENavigation = new HashSet<FINSL>();
            InverseTRPCODENavigation = new HashSet<FINSL>();
            InverseVATEXP_SLCODENavigation = new HashSet<FINSL>();
            PURTERMMAINPURCHASE_RETURN_SLCODENavigation = new HashSet<PURTERMMAIN>();
            PURTERMMAINPURCHASE_SLCODENavigation = new HashSet<PURTERMMAIN>();
            SALTERMMAINSALES_RETURN_SLCODENavigation = new HashSet<SALTERMMAIN>();
            SALTERMMAINSALES_SLCODENavigation = new HashSet<SALTERMMAIN>();
        }

        public long SLCODE { get; set; }
        public string SLNAME { get; set; }
        public string ABBRE { get; set; }
        public string BADDR { get; set; }
        public string BDIST { get; set; }
        public string BCTNAME { get; set; }
        public string BPIN { get; set; }
        public string BPH1 { get; set; }
        public string BPH2 { get; set; }
        public string BPH3 { get; set; }
        public string BPH4 { get; set; }
        public string BFX1 { get; set; }
        public string BFX2 { get; set; }
        public string BEMAIL { get; set; }
        public string BWEBSITE { get; set; }
        public string BCP { get; set; }
        public string LSTNO { get; set; }
        public string CSTNO { get; set; }
        public long CLSCODE { get; set; }
        public long? GLCODE { get; set; }
        public long? TRPCODE { get; set; }
        public long? AGCODE { get; set; }
        public decimal? AGRATE { get; set; }
        public decimal? INTRATE { get; set; }
        public int? CRDAYS { get; set; }
        public string PAN { get; set; }
        public string REM { get; set; }
        public string EXT { get; set; }
        public string TAXAPP { get; set; }
        public long? TAXCODE { get; set; }
        public decimal? DEFAULT_MARKUP { get; set; }
        public decimal? ROUND_OFF_MARKUP { get; set; }
        public string LIMIT { get; set; }
        public long? TDSSRCCODE { get; set; }
        public string CHQLABEL { get; set; }
        public decimal? TAXCHGPER { get; set; }
        public decimal? DISCHGPER { get; set; }
        public string WHETHER_CONSIGNMENT { get; set; }
        public long? PRICELISTCODE { get; set; }
        public string PRICETYPE { get; set; }
        public long? OUTLOCCODE { get; set; }
        public long? INLOCCODE { get; set; }
        public long? SALTERMCODE { get; set; }
        public long? CRCODE { get; set; }
        public double? CRAMT { get; set; }
        public string LGT_APPL { get; set; }
        public decimal? DEFAULT_MARKUP_WSP { get; set; }
        public decimal? ROUND_OFF_MARKUP_WSP { get; set; }
        public string LIMIT_WSP { get; set; }
        public string SADDR { get; set; }
        public string SDIST { get; set; }
        public string SCTNAME { get; set; }
        public string SPIN { get; set; }
        public string SPH1 { get; set; }
        public string SPH2 { get; set; }
        public string SPH3 { get; set; }
        public string SPH4 { get; set; }
        public string SFX1 { get; set; }
        public string SFX2 { get; set; }
        public string SEMAIL { get; set; }
        public string SWEBSITE { get; set; }
        public string SCP { get; set; }
        public string DUE_DATE_BASIS { get; set; }
        public string CASH_DISCOUNT_APPLICABLE { get; set; }
        public double? CASH_DISCOUNT_PERCENTAGE { get; set; }
        public int? CASH_DISCOUNT_PERIOD { get; set; }
        public string SLOWNER { get; set; }
        public string BRAND { get; set; }
        public string PRODUCT { get; set; }
        public string COMPANYTYPE { get; set; }
        public string INDUSTRYTYPE { get; set; }
        public DateTime? CSTDATE { get; set; }
        public DateTime? LSTDATE { get; set; }
        public string EXCISENO { get; set; }
        public DateTime? EXCISE_DATE { get; set; }
        public string SERVICETAXNO { get; set; }
        public DateTime? SERVICETAXDATE { get; set; }
        public string TDSCATEGORY { get; set; }
        public string SERVICETAXCATEGOR { get; set; }
        public string SSINO { get; set; }
        public string MICRONO { get; set; }
        public string BANKNAME { get; set; }
        public string BANKACCOUNTNO { get; set; }
        public string BANKMICRCODE { get; set; }
        public string BANKIFCCODE { get; set; }
        public string BANKRTGSCODE { get; set; }
        public string BEMAIL2 { get; set; }
        public string SEMAIL2 { get; set; }
        public string SLID { get; set; }
        public long CMPCODE { get; set; }
        public string PERMIT_APPL { get; set; }
        public long? PURCHASE_GLCODE { get; set; }
        public long? PURCHASE_SLCODE { get; set; }
        public long? PURCHASE_RETURN_GLCODE { get; set; }
        public long? PURCHASE_RETURN_SLCODE { get; set; }
        public decimal? MARKUP_SELLING_PRICE { get; set; }
        public decimal? MARKUP_SELLING_ROUND_OFF { get; set; }
        public string MARKUP_SELLING_LIMIT { get; set; }
        public string SALETYPE { get; set; }
        public string TRACK_SECONDARY_INVENTORY { get; set; }
        public long? CONSIGNMENT_GLCODE { get; set; }
        public long? SALES_GLCODE { get; set; }
        public long? SALES_SLCODE { get; set; }
        public long? SALES_RETURN_GLCODE { get; set; }
        public long? SALES_RETURN_SLCODE { get; set; }
        public long? CONSIGNMENT_SALES_GLCODE { get; set; }
        public long? CONSIGNMENT_SALES_SLCODE { get; set; }
        public long? CONSIGNMENT_TRNSFR_GLCODE { get; set; }
        public long? CONSIGNMENT_TRNSFR_SLCODE { get; set; }
        public string OUT_LGT_APPL { get; set; }
        public string OUT_PERMIT_APPL { get; set; }
        public string GATEIN_APPL { get; set; }
        public long? FINTRADEGRP_CODE { get; set; }
        public long? PURTERMMAIN_CODE { get; set; }
        public long? ADMCURRENCY_CODE { get; set; }
        public string SALE_POST_METHOD { get; set; }
        public long? VATEXP_GLCODE { get; set; }
        public long? VATEXP_SLCODE { get; set; }
        public long? CONSIGNMENT_SLCODE { get; set; }
        public long? TRANSIT_GLCODE { get; set; }
        public long? TRANSIT_SLCODE { get; set; }
        public long? TRANSITDIFF_GLCODE { get; set; }
        public long? TRANSITDIFF_SLCODE { get; set; }
        public string TDS_APP { get; set; }
        public string ALLOW_JOBBER_STOCKPOINT { get; set; }
        public int? PRD_MAX_DAYS { get; set; }
        public string PRD_OVERDUE_ACTION { get; set; }
        public long? ADMCMPTAX_CODE { get; set; }
        public long? PURFORMCODE { get; set; }
        public long? SALTRADEGRP_CODE { get; set; }
        public long? SALFORMCODE { get; set; }
        public string PUR_PRICE_CHART_APPL { get; set; }
        public int? PUR_DELIVERY_BUFFER_DAYS { get; set; }
        public string SHIPMENT_TRACKING_APPL { get; set; }
        public string BALE_WISE_LRQTY { get; set; }
        public int PUR_DUEDAYS { get; set; }
        public string CINNO { get; set; }
        public string CVRULE { get; set; }
        public double? CRTOLERANCE { get; set; }
        public int? CROVERDUEDAYS { get; set; }
        public double? CROVERDUEAMT { get; set; }
        public long CP_CATEGORY_CODE { get; set; }
        public string CP_GSTIN_NO { get; set; }
        public DateTime? CP_GSTIN_DATE { get; set; }
        public string CP_GSTIN_STATE_CODE { get; set; }
        public decimal? PO_ORDER_LIMIT { get; set; }
        public string ECOMCHNLCODE { get; set; }

        public virtual ADMCMPTAX ADMCMPTAX_CODENavigation { get; set; }
        public virtual ADMCURRENCY ADMCURRENCY_CODENavigation { get; set; }
        public virtual FINSL AGCODENavigation { get; set; }
        public virtual ADMCITY BCTNAMENavigation { get; set; }
        public virtual ADMCLS CLSCODENavigation { get; set; }
        public virtual FINGL CONSIGNMENT_GLCODENavigation { get; set; }
        public virtual FINGL CONSIGNMENT_SALES_GLCODENavigation { get; set; }
        public virtual FINSL CONSIGNMENT_SALES_SLCODENavigation { get; set; }
        public virtual FINSL CONSIGNMENT_SLCODENavigation { get; set; }
        public virtual FINGL CONSIGNMENT_TRNSFR_GLCODENavigation { get; set; }
        public virtual FINSL CONSIGNMENT_TRNSFR_SLCODENavigation { get; set; }
        public virtual ADMGSTSTATE CP_GSTIN_STATE_CODENavigation { get; set; }
        public virtual FINTRADEGRP FINTRADEGRP_CODENavigation { get; set; }
        public virtual FINGL GLCODENavigation { get; set; }
        public virtual SALPRICELISTMAIN PRICELISTCODENavigation { get; set; }
        public virtual FINGL PURCHASE_GLCODENavigation { get; set; }
        public virtual FINGL PURCHASE_RETURN_GLCODENavigation { get; set; }
        public virtual FINSL PURCHASE_RETURN_SLCODENavigation { get; set; }
        public virtual FINSL PURCHASE_SLCODENavigation { get; set; }
        public virtual FINFORM PURFORMCODENavigation { get; set; }
        public virtual PURTERMMAIN PURTERMMAIN_CODENavigation { get; set; }
        public virtual FINGL SALES_GLCODENavigation { get; set; }
        public virtual FINGL SALES_RETURN_GLCODENavigation { get; set; }
        public virtual FINSL SALES_RETURN_SLCODENavigation { get; set; }
        public virtual FINSL SALES_SLCODENavigation { get; set; }
        public virtual FINFORM SALFORMCODENavigation { get; set; }
        public virtual SALTERMMAIN SALTERMCODENavigation { get; set; }
        public virtual FINTRADEGRP SALTRADEGRP_CODENavigation { get; set; }
        public virtual ADMCITY SCTNAMENavigation { get; set; }
        public virtual FINGL TRANSITDIFF_GLCODENavigation { get; set; }
        public virtual FINSL TRANSITDIFF_SLCODENavigation { get; set; }
        public virtual FINGL TRANSIT_GLCODENavigation { get; set; }
        public virtual FINSL TRANSIT_SLCODENavigation { get; set; }
        public virtual FINSL TRPCODENavigation { get; set; }
        public virtual FINGL VATEXP_GLCODENavigation { get; set; }
        public virtual FINSL VATEXP_SLCODENavigation { get; set; }
        public virtual ICollection<FINSL> InverseAGCODENavigation { get; set; }
        public virtual ICollection<FINSL> InverseCONSIGNMENT_SALES_SLCODENavigation { get; set; }
        public virtual ICollection<FINSL> InverseCONSIGNMENT_SLCODENavigation { get; set; }
        public virtual ICollection<FINSL> InverseCONSIGNMENT_TRNSFR_SLCODENavigation { get; set; }
        public virtual ICollection<FINSL> InversePURCHASE_RETURN_SLCODENavigation { get; set; }
        public virtual ICollection<FINSL> InversePURCHASE_SLCODENavigation { get; set; }
        public virtual ICollection<FINSL> InverseSALES_RETURN_SLCODENavigation { get; set; }
        public virtual ICollection<FINSL> InverseSALES_SLCODENavigation { get; set; }
        public virtual ICollection<FINSL> InverseTRANSITDIFF_SLCODENavigation { get; set; }
        public virtual ICollection<FINSL> InverseTRANSIT_SLCODENavigation { get; set; }
        public virtual ICollection<FINSL> InverseTRPCODENavigation { get; set; }
        public virtual ICollection<FINSL> InverseVATEXP_SLCODENavigation { get; set; }
        public virtual ICollection<PURTERMMAIN> PURTERMMAINPURCHASE_RETURN_SLCODENavigation { get; set; }
        public virtual ICollection<PURTERMMAIN> PURTERMMAINPURCHASE_SLCODENavigation { get; set; }
        public virtual ICollection<SALTERMMAIN> SALTERMMAINSALES_RETURN_SLCODENavigation { get; set; }
        public virtual ICollection<SALTERMMAIN> SALTERMMAINSALES_SLCODENavigation { get; set; }
    }
}
