using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models.Hospital
{
    public class tbl_Contacts
    {
        [Key]
        public long Id { get; set; }
        public Nullable<long> HospitalId { get; set; }
        public Nullable<long> DepartmentId { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ContactName { get; set; }

        public tbl_Hospital Hospital { get; set; }
        public tbl_Department tbl_Department { get; set; }


    }
}
