using System;
using System.Collections.Generic;

namespace ScaffoldTool.Events.PURORDCancle
{
    public partial class INVITEM
    {
        public INVITEM()
        {
            PURORDCNLDET = new HashSet<PURORDCNLDET>();
        }

        public string ICODE { get; set; }
        public long GRPCODE { get; set; }
        public string CNAME1 { get; set; }
        public long? CCODE1 { get; set; }
        public string CNAME2 { get; set; }
        public long? CCODE2 { get; set; }
        public string CNAME3 { get; set; }
        public long? CCODE3 { get; set; }
        public string CNAME4 { get; set; }
        public long? CCODE4 { get; set; }
        public string CNAME5 { get; set; }
        public long? CCODE5 { get; set; }
        public string CNAME6 { get; set; }
        public long? CCODE6 { get; set; }
        public decimal? RATE { get; set; }
        public decimal? MRP { get; set; }
        public string BARRQ { get; set; }
        public decimal BARUNIT { get; set; }
        public string REM { get; set; }
        public string EXT { get; set; }
        public long? TAXCODE { get; set; }
        public long? PARTYCODE { get; set; }
        public string PARTYNAME { get; set; }
        public DateTime GENERATED { get; set; }
        public DateTime LAST_CHANGED { get; set; }
        public long CMPCODE { get; set; }
        public string UNITNAME { get; set; }
        public decimal? CHARGE { get; set; }
        public long? GRCCODE { get; set; }
        public long? STKPLANCODE { get; set; }
        public string BARCODE { get; set; }
        public decimal? LISTED_MRP { get; set; }
        public DateTime? EXPIRY_DATE { get; set; }
        public string PARTYALIAS { get; set; }
        public DateTime? STOCKINDATE { get; set; }
        public string CONSIDERINORDER { get; set; }
        public string SHRTNAME { get; set; }
        public string CONSIDERASFREE { get; set; }
        public string NONINVENTORY { get; set; }
        public decimal? COSTRATE { get; set; }
        public decimal? WSP { get; set; }
        public long INVARTICLE_CODE { get; set; }
        public string ALLOW_PRICE_MODIFICATION { get; set; }
        public decimal? ALT_MRP { get; set; }
        public decimal? ALT_LISTED_MRP { get; set; }
        public string ISSERVICE { get; set; }
        public int? SERVICE_DAYS { get; set; }
        public string POS_MULTIPRICE_ACTION { get; set; }
        public string NEGATIVE_STOCK_ALERT { get; set; }
        public string ISMETAL { get; set; }
        public string ITEM_NAME { get; set; }
        public string PRICE_TERMS { get; set; }
        public string PRICE_BASIS { get; set; }
        public long? INVMETAL_CODE { get; set; }
        public decimal? NET_WEIGHT { get; set; }
        public decimal? GRS_WEIGHT { get; set; }
        public string JOB_COST_BASIS { get; set; }
        public decimal? JOB_COST_AMT { get; set; }
        public double? PART_QTY { get; set; }
        public string CERTIFICATE_NO { get; set; }
        public long? D_COUNT { get; set; }
        public string D_SIZE { get; set; }
        public decimal? D_WEIGHT { get; set; }
        public decimal? D_VALUE { get; set; }
        public string D_DESC { get; set; }
        public long? C_COUNT { get; set; }
        public decimal? C_WEIGHT { get; set; }
        public decimal? C_VALUE { get; set; }
        public string C_DESC { get; set; }
        public long? O_COUNT { get; set; }
        public decimal? O_WEIGHT { get; set; }
        public decimal? O_VALUE { get; set; }
        public string O_DESC { get; set; }
        public decimal? OTHER_CHG { get; set; }
        public string MATERIAL_TYPE { get; set; }
        public long? ROUTECODE { get; set; }
        public long? COSTSHEET_CODE { get; set; }
        public string DESC1 { get; set; }
        public string DESC2 { get; set; }
        public string DESC3 { get; set; }
        public string DESC4 { get; set; }
        public string DESC5 { get; set; }
        public string DESC6 { get; set; }
        public decimal? NUM1 { get; set; }
        public decimal? NUM2 { get; set; }
        public decimal? NUM3 { get; set; }
        public bool? BLOCK_SALE { get; set; }
        public DateTime? BLOCK_SALE_BEFORE { get; set; }
        public DateTime? BLOCK_SALE_AFTER { get; set; }
        public string BLOCK_SALE_REASON { get; set; }
        public bool? ISPRICE_EXCLUDES_TAX { get; set; }
        public string AUTOQTYPOPUP { get; set; }
        public string POS_RETURN_BEHAVIOR { get; set; }
        public string SEARCH_STRING { get; set; }
        public double? PRICE_CHANGE_LIMIT { get; set; }
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
        public long? COGS_CODE { get; set; }
        public long INVHSNSACMAIN_CODE { get; set; }
        public string GST_ITC_APPL { get; set; }
        public long? GLCODE { get; set; }
        public long? SLCODE { get; set; }
        public string NEWCOLUMN { get; set; }
        public double? NEWCOLUMN1 { get; set; }

        public virtual INVHSNSACMAIN INVHSNSACMAIN_CODENavigation { get; set; }
        public virtual ICollection<PURORDCNLDET> PURORDCNLDET { get; set; }
    }
}
