using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Models.Hospital;
using Hospital.Models.Patient;
using Microsoft.AspNetCore.Identity;

namespace Hospital.Models
{
    public class tbl_User: IdentityUser
    {
        public string Name { get; set; }
        public Gender GenderType { get; set; }
        public long NationalityId { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        
        public ICollection<tbl_Appointment> Appointments { get; set; }
        public ICollection<tbl_RoomStatus> RoomStatus { get; set; }
        //public ICollection<tbl_PayRoll> PayRolls { get; set; }
        public virtual ICollection<tbl_PayRoll> UserPayRolls { get; set; }
        public virtual ICollection<tbl_PayRoll> EmployeePayRolls { get; set; }

    }
    public enum Gender
    {
        male,
        female,
        other
    }
}
