using System.ComponentModel.DataAnnotations;

namespace Hospital.Models.Hospital
{
    //public class tbl_RoomStatus
    //{
    //    public long Id { get; set; }

    //    public tbl_Rooms tbl_Rooms { get; set; }
    //    public tbl_StatusType tbl_StatusType { get; set; }
    //    public tbl_User tbl_User { get; set; }
    //    public bool? IsActive { get; set; }
    //    public System.DateTime? CreationDate { get; set; }

    //}
    public  class tbl_RoomStatus
    {
        [Key] public long Id { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public int tbl_RoomsId { get; set; }
        public long tbl_StatusTypeId { get; set; }
        public string tbl_UserId { get; set; }

        public virtual tbl_Rooms tbl_Rooms { get; set; }
        public virtual tbl_StatusType tbl_StatusType { get; set; }
    }

}
