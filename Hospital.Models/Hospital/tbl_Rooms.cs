using System.ComponentModel.DataAnnotations;

namespace Hospital.Models.Hospital
{
    public class tbl_Rooms
    {
        [Key]
        public int Id { get; set; }
        public string RoomNumber { get; set; }
        public Nullable<int> Floor { get; set; }
        public Nullable<int> RoomeType { get; set; }
        public Nullable<long> HospitalId { get; set; }
        public tbl_Hospital Hospital { get; set; }
        public virtual ICollection<tbl_RoomStatus> tbl_RoomStatus { get; set; }

    }
}
