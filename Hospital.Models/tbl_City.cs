using Hospital.Models.Hospital;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public class tbl_City
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public tbl_States State { get; set; }
        public virtual ICollection<tbl_Hospital> tbl_Hospital { get; set; }
        public virtual ICollection<tbl_Supplier> tbl_Supplier { get; set; }


    }
}
