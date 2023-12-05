using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Models.Hospital;
using Hospital.Repository.Interface;
using Hospital.Utilities;
using Hospital.ViewModels;

namespace Hospital.Services
{
    public class HospitalService : IHospitalService
    {
        private IUnitOfWork _unitOfWork;

        public HospitalService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public PagedResult<HospitalInfoViewModel> GetAll(int pageNumber, int pageSize)
        {
            var HospitalinfoViewModel = new HospitalInfoViewModel();
            int totalCount = 0;
            List<HospitalInfoViewModel> vmList = new List<HospitalInfoViewModel>();
            try
            {
                int ExcludeRecords = (pageSize * pageNumber) - pageSize;
                var modelList = _unitOfWork.GenericRepository<tbl_Hospital>().GetAll().Skip(ExcludeRecords)
                    .Take(pageSize).ToList();
                totalCount = _unitOfWork.GenericRepository<tbl_Hospital>().GetAll().ToList().Count;
                vmList = ConvertModelToViewModelList(modelList);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            var result = new PagedResult<HospitalInfoViewModel>
            {
                Data = vmList,
                TotalItems = totalCount,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
            return result;
        }

        public HospitalInfoViewModel GetHospitalById(long HospitalId)
        {
            var model = _unitOfWork.GenericRepository<tbl_Hospital>().GetById(HospitalId);
            var vm = new HospitalInfoViewModel(model);
            return vm;
        }

        public void InsertHospitalInfo(HospitalInfoViewModel hospitalInfo)
        {
            var model = new HospitalInfoViewModel().ConvertHospitalViewModel(hospitalInfo);
            _unitOfWork.GenericRepository<tbl_Hospital>().Add(model);
            _unitOfWork.Save();
        }

        public void UpdateHospitalInfo(HospitalInfoViewModel hospitalInfo)
        {
            var model = new HospitalInfoViewModel().ConvertHospitalViewModel(hospitalInfo);
            var selectedModel = _unitOfWork.GenericRepository<tbl_Hospital>().GetById(model.Id);
            selectedModel.CityId =hospitalInfo.CityId;
            selectedModel.Address = hospitalInfo.Address;
            selectedModel.HospitalTypeId = hospitalInfo.HospitalTypeId;
            selectedModel.Name = hospitalInfo.Name;
            _unitOfWork.GenericRepository<tbl_Hospital>().Update(selectedModel);
            _unitOfWork.Save();
        }

        public void DeleteHospitalInfo(long HospitalId)
        {
            var model = _unitOfWork.GenericRepository<tbl_Hospital>().GetById(HospitalId);
            _unitOfWork.GenericRepository<tbl_Hospital>().Delete(model);
            _unitOfWork.Save();
        }

        private List<HospitalInfoViewModel> ConvertModelToViewModelList(List<tbl_Hospital> modelList)
        {
            return modelList.Select(x => new HospitalInfoViewModel(x)).ToList();
        }
    }
}
