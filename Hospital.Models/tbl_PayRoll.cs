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
        public decimal? Salary { get; set; }
        public decimal? NetSalary { get; set; }
        public decimal? HourlySalary { get; set; }
        public decimal? BounusSalary { get; set; }
        public decimal? Compenstion { get; set; }
        public string AccountNumber { get; set; }
        public String EmployeeId { get; set; }
        public String UserId { get; set; }

        public virtual tbl_User Employee { get; set; }
        public virtual tbl_User User { get; set; }
    }
}
