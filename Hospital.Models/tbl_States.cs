using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models
{
    //public class tbl_States
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }

    //    // Foreign key property

    //    // Navigation properties
    //    public tbl_Country Country { get; set; }
    //    public ICollection<tbl_City> Cities { get; set; }

    //}

    public class tbl_States
    {
        public tbl_States()
        {
            this.tbl_City = new HashSet<tbl_City>();
        }

        [Key]
        public int StateId { get; set; } // Changed the primary key column name to StateId
        public string Name { get; set; }
        public long CountryId { get; set; }

        public virtual ICollection<tbl_City> tbl_City { get; set; }
        public virtual tbl_Country tbl_Country { get; set; }
    }
}
