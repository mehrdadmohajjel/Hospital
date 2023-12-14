using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models.Lab
{
    //public class tbl_Lab
    //{
    //    public long Id { get; set; }
    //    public string LabNumber { get; set; }
    //    public tbl_User Patient { get; set; }
    //    public string TestType { get; set; }
    //    public string TestCde { get; set; }
    //    public decimal Weight{ get; set; }
    //    public decimal Height { get; set; }
    //    public decimal BloodPressure { get; set; }
    //    public decimal Temprature { get; set; }
    //    public string TestResult { get; set; }
    //}
    public partial class tbl_Lab
    {
        public tbl_Lab()
        {
            this.tbl_TestPrice = new HashSet<tbl_TestPrice>();
        }

        public long Id { get; set; }
        public string LabNumber { get; set; }
        public string PatientId { get; set; }
        public string TestType { get; set; }
        public string TestCde { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public decimal BloodPressure { get; set; }
        public decimal Temprature { get; set; }
        public string TestResult { get; set; }

        public virtual ICollection<tbl_TestPrice> tbl_TestPrice { get; set; }
    }

}
