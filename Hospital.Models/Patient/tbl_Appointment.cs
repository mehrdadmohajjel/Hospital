﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models.Patient
{
    public class tbl_Appointment
    {
        [Key]
        public long Id { get; set; }
        public long? DepartmentId { get; set; }
        public String DoctorId { get; set; }
        public string Number { get; set; }
        public System.DateTime? CreateionDate { get; set; }
        public string Description { get; set; }
        public String PatientId { get; set; }

        public virtual tbl_Department tbl_Department { get; set; }
        public virtual tbl_User tbl_User { get; set; }


    }
}
