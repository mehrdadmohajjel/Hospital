using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models.Patient
{
    public class tbl_Medicine
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }
        public ICollection<tbl_MedicineReport> MedicineReport { get; set; }
        public ICollection<tbl_PrescribedMedicine> PrescribedMedicine { get; set; }

    }
}
