using System;
using System.Collections.Generic;

namespace ScaffoldTool.Events.VendorMaster
{
    public partial class SALPRICELISTMAIN
    {
        public SALPRICELISTMAIN()
        {
            FINSL = new HashSet<FINSL>();
        }

        public long PRICELISTCODE { get; set; }
        public string PRICELISTNAME { get; set; }
        public long? ECODE { get; set; }
        public DateTime? TIME { get; set; }
        public string REM { get; set; }
        public long? CMPCODE { get; set; }
        public long? LAST_ACCESS_ECODE { get; set; }
        public DateTime? LAST_ACCESS_TIME { get; set; }
        public string PRICE_TYPE { get; set; }
        public string DISCOUNT_MODE { get; set; }
        public string INCLUDE_VAT_IN_DISCOUNT { get; set; }
        public string DISCOUNT_BASIS { get; set; }
        public double? DISCOUNT_FACTOR { get; set; }
        public decimal? NET_PRICE_MULTIPLES_OF { get; set; }
        public string NET_PRICE_ROUND_LIMIT { get; set; }
        public string CMPTAX_CODE_BASIS { get; set; }

        public virtual ICollection<FINSL> FINSL { get; set; }
    }
}
