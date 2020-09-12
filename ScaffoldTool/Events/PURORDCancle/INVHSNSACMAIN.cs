using System;
using System.Collections.Generic;

namespace ScaffoldTool.Events.PURORDCancle
{
    public partial class INVHSNSACMAIN
    {
        public INVHSNSACMAIN()
        {
            INVITEM = new HashSet<INVITEM>();
        }

        public long CODE { get; set; }
        public string HSN_SAC_CODE { get; set; }
        public string DESCRIPTION { get; set; }
        public string EXTINCT { get; set; }
        public long CREATEDBY { get; set; }
        public DateTime CREATEDON { get; set; }
        public long? LASTMODIFIEDBY { get; set; }
        public DateTime? LASTMODIFIEDON { get; set; }
        public long DATAVERSION { get; set; }
        public string APPL { get; set; }
        public string ISSYSTEM { get; set; }

        public virtual HRDEMP CREATEDBYNavigation { get; set; }
        public virtual HRDEMP LASTMODIFIEDBYNavigation { get; set; }
        public virtual ICollection<INVITEM> INVITEM { get; set; }
    }
}
