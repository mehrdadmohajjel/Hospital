using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Models.Hospital;
using Hospital.Utilities;
using Hospital.ViewModels;

namespace Hospital.Services
{
    public interface IHospitalService
    {
        PagedResult<HospitalInfoViewModel> GetAll(int pageNumber, int pageSize);
        tbl_Hospital GetHospitalById(long HospitalId);
        void InsertHospitalInfo(HospitalInfoViewModel hospitalInfo);
        void UpdateHospitalInfo(HospitalInfoViewModel hospitalInfo);
        void DeleteHospitalInfo(long HospitalId);
    }
}
