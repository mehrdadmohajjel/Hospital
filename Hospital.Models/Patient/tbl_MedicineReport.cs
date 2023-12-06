using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models.Patient
{
    public class tbl_MedicineReport
    {
        public long Id { get; set; }
        public tbl_Supplier Supplier { get; set; }
        public tbl_Medicine Medicine { get; set; }
        public string Company { get; set; }
        public int Quantity { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public tbl_Country Country { get; set; }
    }
}
