using System;
using System.Collections.Generic;

namespace ScaffoldTool.Events.PURORDMain
{
    public partial class ADMCURRENCY
    {
        public ADMCURRENCY()
        {
            FINSL = new HashSet<FINSL>();
            PURORDMAIN = new HashSet<PURORDMAIN>();
        }

        public long CODE { get; set; }
        public string NAME { get; set; }
        public string SHORTCODE { get; set; }
        public bool ISEXTINCT { get; set; }
        public bool ISBASE { get; set; }
        public string SYMBOL { get; set; }
        public string DECIMAL_SYMBOL { get; set; }
        public bool? DECIMAL_PLACE { get; set; }
        public bool SHOW_IN_MILLIONS { get; set; }
        public DateTime CREATEDON { get; set; }
        public long CREATEDBY { get; set; }
        public DateTime? LASTMODIFIEDON { get; set; }
        public long? LASTMODIFIEDBY { get; set; }
        public long DATAVERSION { get; set; }

        public virtual HRDEMP CREATEDBYNavigation { get; set; }
        public virtual HRDEMP LASTMODIFIEDBYNavigation { get; set; }
        public virtual ICollection<FINSL> FINSL { get; set; }
        public virtual ICollection<PURORDMAIN> PURORDMAIN { get; set; }
    }
}
