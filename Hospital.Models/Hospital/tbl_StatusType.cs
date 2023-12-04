namespace Hospital.Models.Hospital
{
    public class tbl_StatusType
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string ShowName { get; set; }
        public ICollection<tbl_RoomStatus> tbl_RoomStatus { get; set; }

    }
}
