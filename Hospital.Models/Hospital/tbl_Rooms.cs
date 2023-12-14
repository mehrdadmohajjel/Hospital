using System.ComponentModel.DataAnnotations;

namespace Hospital.Models.Hospital
{
    //public class tbl_Rooms
    //{
    //    [Key]
    //    public long Id { get; set; }
    //    public string RoomNumber { get; set; }
    //    public int? Floor { get; set; }
    //    public int? RoomeType { get; set; }
    //    public tbl_Hospital Hospital { get; set; }
    //    public virtual ICollection<tbl_RoomStatus> tbl_RoomStatus { get; set; }

    //}
    public  class tbl_Rooms
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Rooms()
        {
            this.tbl_RoomStatus = new HashSet<tbl_RoomStatus>();
        }

        [Key] public int Id { get; set; }
        public string RoomNumber { get; set; }
        public Nullable<int> Floor { get; set; }
        public Nullable<int> RoomeType { get; set; }
        public long HospitalId { get; set; }

        public virtual tbl_Hospital tbl_Hospital { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_RoomStatus> tbl_RoomStatus { get; set; }
    }
}
