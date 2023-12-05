using Hospital.Models.Hospital;
using Hospital.Models.Patient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public class tbl_Department
    {
        [Key]
        public long Id { get; set; }
        public long? ParentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [ForeignKey("ParentId")]
        [InverseProperty("Children")]
        public tbl_Department Parent { get; set; }

        [InverseProperty("Parent")]
        public ICollection<tbl_Department> Children { get; set; }

        public ICollection<tbl_Appointment> Appointments { get; set; }
        public ICollection<tbl_Contacts> Contacts { get; set; }
    }
}
