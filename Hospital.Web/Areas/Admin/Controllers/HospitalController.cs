using Hospital.Services;
using Hospital.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HospitalController : Controller
    {
        private IHospitalService _hospitalService;

        public HospitalController(IHospitalService hospitalService)
        {
            _hospitalService = hospitalService;
        }

        public IActionResult Index(int pageNumber = 1, int pageSize = 10)
        {
            return View(_hospitalService.GetAll(pageNumber, pageSize));
        }

        [HttpGet]
        public IActionResult Edit(long Id)
        {
            var viewModel = _hospitalService.GetHospitalById(Id);
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Edit(HospitalInfoViewModel vm)
        {
            _hospitalService.UpdateHospitalInfo(vm);
            return RedirectToAction("Index");
        }
        //public IActionResult Details(long Id)
        //{
        //    return View("Index");
        //}

        public IActionResult Delete(long Id)
        {
            _hospitalService.DeleteHospitalInfo(Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(HospitalInfoViewModel vm)
        {
            _hospitalService.InsertHospitalInfo(vm);
            return RedirectToAction("Index");
        }

        public IActionResult Detail(long Id)
        {
            var viewModel = _hospitalService.GetHospitalById(Id);
            return View(viewModel);
        }
    }
}
