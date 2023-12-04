namespace Hospital.Models.Hospital
{
    public class tbl_RoomStatus
    {
        public long Id { get; set; }
        public Nullable<long> RoomId { get; set; }
        public Nullable<long> UserId { get; set; }
        public Nullable<long> StatusTypeId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }

        public tbl_Rooms tbl_Rooms { get; set; }
        public tbl_StatusType tbl_StatusType { get; set; }
        public tbl_User tbl_User { get; set; }
    }
}
