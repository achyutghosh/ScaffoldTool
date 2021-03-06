﻿using System;
using System.Collections.Generic;

namespace ScaffoldTool.Events.PURORDMain
{
    public partial class HRDEMP
    {
        public HRDEMP()
        {
            ADMCURRENCYCREATEDBYNavigation = new HashSet<ADMCURRENCY>();
            ADMCURRENCYLASTMODIFIEDBYNavigation = new HashSet<ADMCURRENCY>();
            ADMGSTINCREATEDBYNavigation = new HashSet<ADMGSTIN>();
            ADMGSTINLASTMODIFIEDBYNavigation = new HashSet<ADMGSTIN>();
            PURORDMAINAUTHORCODENavigation = new HashSet<PURORDMAIN>();
            PURORDMAINECODENavigation = new HashSet<PURORDMAIN>();
            PURORDMAINLAST_ACCESS_ECODENavigation = new HashSet<PURORDMAIN>();
            PURORDMAINMRCHNDSRCODENavigation = new HashSet<PURORDMAIN>();
        }

        public long ECODE { get; set; }
        public string FNAME { get; set; }
        public string ENO { get; set; }
        public string ABBRE { get; set; }
        public long? DEPTCODE { get; set; }
        public long? RLCODE { get; set; }
        public string PASS { get; set; }
        public int? LOCDAYS { get; set; }
        public string REM { get; set; }
        public string EXT { get; set; }
        public decimal? FLEX_FIELD_KEY { get; set; }
        public long? PROFCODE { get; set; }
        public string SALESMAN { get; set; }
        public string USERTYPE { get; set; }
        public string ALLOW_LAST_FY_DAY_MODE { get; set; }
        public string REPORTROLE { get; set; }
        public bool? IS_APIUSER { get; set; }
        public string APIKEY { get; set; }

        public virtual ICollection<ADMCURRENCY> ADMCURRENCYCREATEDBYNavigation { get; set; }
        public virtual ICollection<ADMCURRENCY> ADMCURRENCYLASTMODIFIEDBYNavigation { get; set; }
        public virtual ICollection<ADMGSTIN> ADMGSTINCREATEDBYNavigation { get; set; }
        public virtual ICollection<ADMGSTIN> ADMGSTINLASTMODIFIEDBYNavigation { get; set; }
        public virtual ICollection<PURORDMAIN> PURORDMAINAUTHORCODENavigation { get; set; }
        public virtual ICollection<PURORDMAIN> PURORDMAINECODENavigation { get; set; }
        public virtual ICollection<PURORDMAIN> PURORDMAINLAST_ACCESS_ECODENavigation { get; set; }
        public virtual ICollection<PURORDMAIN> PURORDMAINMRCHNDSRCODENavigation { get; set; }
    }
}
