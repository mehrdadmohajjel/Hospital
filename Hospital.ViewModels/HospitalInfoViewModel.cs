using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Models.Hospital;

namespace Hospital.ViewModels
{
    public class HospitalInfoViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string HospitalType { get; set; }
        public long HospitalTypeId { get; set; }
        public string City { get; set; }
        public long CityId { get; set; }
        public string Address { get; set; }

        public HospitalInfoViewModel()
        {
            
        }

        public HospitalInfoViewModel(tbl_Hospital model)
        {
            Id = model.Id;
            Address = model.Address;
            City = model.tbl_City.Name.ToString();
            HospitalType = model.HospitalType.ShowName;
            Name = model.Name;

        }
        public tbl_Hospital ConvertHospitalViewModel(HospitalInfoViewModel model)
        {
            return new tbl_Hospital
            {
                Id = model.Id,
                Address = model.Address,
                CityId = model.CityId,
                HospitalTypeId = model.HospitalTypeId,
                Name = model.Name,
            };
        }
    }
}
