using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Models;
using Hospital.Models.Hospital;

namespace Hospital.ViewModels
{
    public class HospitalInfoViewModel
    {
        [DisplayName("شناسه")]
        public long Id { get; set; }
        [DisplayName("نام")]
        public string Name { get; set; }
        //[DisplayName("نوع بیمارستان")]
        //public string HospitalType { get; set; }
        //public long HospitalTypeId { get; set; }
        //[DisplayName("شهر")]
        //public string City { get; set; }
        //public long CityId { get; set; }
        [DisplayName("آدرس")]
        public string Address { get; set; }
        public tbl_City tbl_City { get; set; }
        public tbl_HospitalType HospitalType { get; set; }

        public HospitalInfoViewModel()
        {
            
        }

        public HospitalInfoViewModel(tbl_Hospital model)
        {
            Id = model.Id;
            Address = model.Address;
            tbl_City = model.tbl_City;
            HospitalType = model.HospitalType;
            Name = model.Name;

        }
        public tbl_Hospital ConvertHospitalViewModel(HospitalInfoViewModel model)
        {
            return new tbl_Hospital
            {
                Id = model.Id,
                Address = model.Address,
                tbl_City = model.tbl_City,
                HospitalType = model.HospitalType,
                Name = model.Name,
            };
        }
    }
}
