using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Models.Hospital;

namespace Hospital.ViewModels
{
    public class RoomViewModel
    {
        public long Id { get; set; }
        public string RoomNumber { get; set; }
        public int Floor { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public long HospitalInfoId { get; set; }

        public RoomViewModel()
        {
            
        }
        public RoomViewModel(tbl_Rooms model)
        {
            Id = model.Id;
            Floor = (int)model.Floor;
            Type = model.RoomeType.ToString();
        }


    }
}
