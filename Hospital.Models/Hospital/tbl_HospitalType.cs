using System.ComponentModel.DataAnnotations;

namespace Hospital.Models.Hospital
{
    //public class tbl_HospitalType
    //{
    //    public long Id { get; set; }
    //    public string Name { get; set; }
    //    public string ShowName { get; set; }
    //    public ICollection<tbl_Hospital> Hospital { get; set; }

    //}
    public  class tbl_HospitalType
    {
        public tbl_HospitalType()
        {
            this.tbl_Hospital = new HashSet<tbl_Hospital>();
        }

        [Key] public long Id { get; set; }
        public string Name { get; set; }
        public string ShowName { get; set; }

        public virtual ICollection<tbl_Hospital> tbl_Hospital { get; set; }
    }

}
