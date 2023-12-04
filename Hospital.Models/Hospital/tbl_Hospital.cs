using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models.Hospital
{
    public class tbl_Hospital
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> HospitalType { get; set; }
        public Nullable<long> CityId { get; set; }
        public string Address { get; set; }

        public  tbl_City tbl_City { get; set; }

        public ICollection<tbl_Rooms> Rooms { get; set; }
        public ICollection<tbl_Contacts> Contacts { get; set; }
    }
}
