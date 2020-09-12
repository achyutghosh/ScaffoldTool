using System;
using System.Collections.Generic;

namespace ScaffoldTool.Events.PURORDMain
{
    public partial class ADMGSTIN
    {
        public ADMGSTIN()
        {
            ADMSITE = new HashSet<ADMSITE>();
        }

        public long CODE { get; set; }
        public long ADMOU_CODE { get; set; }
        public string GSTIN_NO { get; set; }
        public DateTime GSTIN_DATE { get; set; }
        public string REMARKS { get; set; }
        public long IGST_INPUT_GLCODE { get; set; }
        public long? IGST_INPUT_SLCODE { get; set; }
        public long IGST_OUTPUT_GLCODE { get; set; }
        public long? IGST_OUTPUT_SLCODE { get; set; }
        public long CGST_INPUT_GLCODE { get; set; }
        public long? CGST_INPUT_SLCODE { get; set; }
        public long CGST_OUTPUT_GLCODE { get; set; }
        public long? CGST_OUTPUT_SLCODE { get; set; }
        public long SGST_INPUT_GLCODE { get; set; }
        public long? SGST_INPUT_SLCODE { get; set; }
        public long SGST_OUTPUT_GLCODE { get; set; }
        public long? SGST_OUTPUT_SLCODE { get; set; }
        public long CESS_INPUT_GLCODE { get; set; }
        public long? CESS_INPUT_SLCODE { get; set; }
        public long CESS_OUTPUT_GLCODE { get; set; }
        public long? CESS_OUTPUT_SLCODE { get; set; }
        public string EXTINCT { get; set; }
        public long CREATEDBY { get; set; }
        public DateTime CREATEDON { get; set; }
        public long? LASTMODIFIEDBY { get; set; }
        public DateTime? LASTMODIFIEDON { get; set; }
        public long DATAVERSION { get; set; }
        public string ADMGSTSTATE_CODE { get; set; }
        public long? PPOB { get; set; }

        public virtual ADMGSTSTATE ADMGSTSTATE_CODENavigation { get; set; }
        public virtual ADMOU ADMOU_CODENavigation { get; set; }
        public virtual FINSL CESS_INPUT_SLCODENavigation { get; set; }
        public virtual FINSL CESS_OUTPUT_SLCODENavigation { get; set; }
        public virtual FINSL CGST_INPUT_SLCODENavigation { get; set; }
        public virtual FINSL CGST_OUTPUT_SLCODENavigation { get; set; }
        public virtual HRDEMP CREATEDBYNavigation { get; set; }
        public virtual FINSL IGST_INPUT_SLCODENavigation { get; set; }
        public virtual FINSL IGST_OUTPUT_SLCODENavigation { get; set; }
        public virtual HRDEMP LASTMODIFIEDBYNavigation { get; set; }
        public virtual ADMSITE PPOBNavigation { get; set; }
        public virtual FINSL SGST_INPUT_SLCODENavigation { get; set; }
        public virtual FINSL SGST_OUTPUT_SLCODENavigation { get; set; }
        public virtual ICollection<ADMSITE> ADMSITE { get; set; }
    }
}
