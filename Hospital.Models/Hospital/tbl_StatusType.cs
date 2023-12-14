using System.ComponentModel.DataAnnotations;

namespace Hospital.Models.Hospital
{
    //public class tbl_StatusType
    //{
    //    public long Id { get; set; }
    //    public string Title { get; set; }
    //    public string ShowName { get; set; }
    //    public ICollection<tbl_RoomStatus> tbl_RoomStatus { get; set; }

    //}
    public  class tbl_StatusType
    {
        public tbl_StatusType()
        {
            this.tbl_RoomStatus = new HashSet<tbl_RoomStatus>();
        }

        [Key] public long Id { get; set; }
        public string Title { get; set; }
        public string ShowName { get; set; }

        public virtual ICollection<tbl_RoomStatus> tbl_RoomStatus { get; set; }
    }

}
