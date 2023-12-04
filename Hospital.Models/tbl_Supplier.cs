using System.ComponentModel.DataAnnotations;

namespace Hospital.Models
{
    public class tbl_Supplier
    {
        [Key] public long Id { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public Nullable<long> CityId { get; set; }

        public tbl_City tbl_City { get; set; }

    }
}
