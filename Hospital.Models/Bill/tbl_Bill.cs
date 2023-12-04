using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models.Bill
{
    public class tbl_Bill
    {
        public long Id { get; set; }
        public string BillNumber { get; set; }

        public tbl_User Patient { get; set; }
        public tbl_Insurance Insurance { get; set; }

        public decimal DoctorChage { get; set; }
        public decimal MedicineChage { get; set; }
        public decimal RoomChage { get; set; }
        public decimal OperationeChage { get; set; }
        public decimal NumberOfDays { get; set; }
        public decimal NursingCharge { get; set; }
        public decimal LabCharge { get; set; }
        public decimal Advance { get; set; }
        public decimal TotalBill { get; set; }
        
        



    }
}
