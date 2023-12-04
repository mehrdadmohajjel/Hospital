using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models.Patient
{
    public class tbl_PrescribedMedicine
    {
        public long Id { get; set; }
        public tbl_Medicine Medicine { get; set; }
        public tbl_PatientReport PatientReport { get; set; }
    }
}
