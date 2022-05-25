using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace detailwebapp.RequestModel
{
    public class infoRequest
    {
    
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Subject { get; set; }
        public int Age { get; set; }
        public long? Number { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
