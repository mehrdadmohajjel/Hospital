namespace Hospital.Models.Hospital
{
    public class tbl_HospitalType
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ShowName { get; set; }
        public ICollection<tbl_Hospital> Hospital { get; set; }

    }
}
