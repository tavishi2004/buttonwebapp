using System;
using System.Collections.Generic;

namespace detailwebapp.Models
{
    public partial class Info
    {
        internal int stud_Id;

        public int StudId { get; set; }
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
