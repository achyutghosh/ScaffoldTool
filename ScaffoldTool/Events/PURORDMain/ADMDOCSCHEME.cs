using System;
using System.Collections.Generic;

namespace ScaffoldTool.Events.PURORDMain
{
    public partial class ADMDOCSCHEME
    {
        public ADMDOCSCHEME()
        {
            PURORDMAIN = new HashSet<PURORDMAIN>();
        }

        public long DOCCODE { get; set; }
        public string DOCNAME { get; set; }
        public int? WIDTH { get; set; }
        public decimal? STARTING { get; set; }
        public string PREFILL { get; set; }
        public string PREFIX { get; set; }
        public string DEFAULT_SUFFIX { get; set; }
        public string SUFFIX { get; set; }
        public string GENERATION_INTERVAL { get; set; }
        public string DOCCODE_WISE { get; set; }
        public string DEFAULT_SUFFIX_MUSK { get; set; }
        public string SUFFIX_ATTACHMENT { get; set; }
        public string SEPERATOR1 { get; set; }
        public string SEPERATOR2 { get; set; }
        public string REMARKS { get; set; }
        public string MANUAL { get; set; }
        public DateTime DOC { get; set; }
        public DateTime DOM { get; set; }
        public string BASEDON { get; set; }
        public string EXT { get; set; }
        public string SAMPLE_DOCNO { get; set; }
        public long? CMPCODE { get; set; }
        public string ISEXCISE { get; set; }
        public string SYSTEM_GENERATED { get; set; }
        public string GENERATION_BASIS { get; set; }
        public string GSTAPPL { get; set; }

        public virtual ICollection<PURORDMAIN> PURORDMAIN { get; set; }
    }
}
