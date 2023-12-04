using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public class tbl_PayRoll
    {
        [Key]
        public long Id { get; set; }
        public Nullable<decimal> Salary { get; set; }
        public Nullable<decimal> NetSalary { get; set; }
        public Nullable<decimal> HourlySalary { get; set; }
        public Nullable<decimal> BounusSalary { get; set; }
        public Nullable<decimal> Compenstion { get; set; }
        public string AccountNumber { get; set; }
        public Nullable<long> EmployeeId { get; set; }
        public Nullable<long> UserId { get; set; }

        public virtual tbl_User tbl_User { get; set; }
        public virtual tbl_User tbl_User1 { get; set; }
    }
}
