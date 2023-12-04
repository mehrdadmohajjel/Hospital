using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Models.Bill;

namespace Hospital.Models.Lab
{
    public class tbl_TestPrice
    {
        public long Id { get; set; }
        public string TestCode { get; set; }
        public decimal TestPrice { get; set; }
        public tbl_Lab Lab { get; set; }
        public tbl_Bill Bill { get; set; }
    }
}
