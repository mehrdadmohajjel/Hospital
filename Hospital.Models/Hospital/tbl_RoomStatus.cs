namespace Hospital.Models.Hospital
{
    public class tbl_RoomStatus
    {
        public long Id { get; set; }
        public long? RoomId { get; set; }
        public String UserId { get; set; }
        public long? StatusTypeId { get; set; }
        public bool? IsActive { get; set; }
        public System.DateTime? CreationDate { get; set; }

        public tbl_Rooms tbl_Rooms { get; set; }
        public tbl_StatusType tbl_StatusType { get; set; }
        public tbl_User tbl_User { get; set; }
    }
}
