using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models.Hospital
{
    //public class tbl_Hospital
    //{
    //    [Key]
    //    public long Id { get; set; }
    //    public string Name { get; set; }
    //    public string Address { get; set; }

    //    public  tbl_City tbl_City { get; set; }
    //    public tbl_HospitalType HospitalType { get; set; }
    //    public ICollection<tbl_Rooms> Rooms { get; set; }
    //    public ICollection<tbl_Contacts> Contacts { get; set; }
    //}
    public  class tbl_Hospital
    {
        public tbl_Hospital()
        {
            this.tbl_Contacts = new HashSet<tbl_Contacts>();
            this.tbl_Rooms = new HashSet<tbl_Rooms>();
        }

        [Key] public long Id { get; set; }
        public string Name { get; set; }
        public long HospitalTypeId { get; set; }
        public string Address { get; set; }
        public long tbl_CityId { get; set; }

        public virtual tbl_City tbl_City { get; set; }
        public virtual ICollection<tbl_Contacts> tbl_Contacts { get; set; }
        public virtual tbl_HospitalType tbl_HospitalType { get; set; }
        public virtual ICollection<tbl_Rooms> tbl_Rooms { get; set; }
    }

}
