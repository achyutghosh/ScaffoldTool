using System;
using System.Collections.Generic;

namespace ScaffoldTool.Events.VendorMaster
{
    public partial class ADMCLS
    {
        public ADMCLS()
        {
            FINSL = new HashSet<FINSL>();
        }

        public long CLSCODE { get; set; }
        public string CLSNAME { get; set; }
        public string EXT { get; set; }
        public string CLSTYPE { get; set; }
        public long? CMPCODE { get; set; }

        public virtual ICollection<FINSL> FINSL { get; set; }
    }
}
