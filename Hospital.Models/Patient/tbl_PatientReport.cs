using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models.Patient
{
    public class tbl_PatientReport
    {
        public long Id { get; set; }
        public string Diagnose { get; set; }
        public tbl_User Doctor { get; set; }
        public tbl_User Patient { get; set; }
        public ICollection<tbl_PrescribedMedicine> PrescribedMedicine { get; set; }
    }
}
