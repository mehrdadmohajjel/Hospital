using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public class tbl_States
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Foreign key property
        public int CountryId { get; set; }

        // Navigation properties
        public tbl_Country Country { get; set; }
        public ICollection<tbl_City> Cities { get; set; }

    }
}
