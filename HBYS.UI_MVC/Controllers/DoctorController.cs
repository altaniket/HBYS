using HBYS.BLL.Services.Contract;
using Microsoft.AspNetCore.Mvc;

namespace HBYS.UI_MVC.Controllers
{
    public class DoctorController : Controller
    {
        private readonly IDoctorService doctorService;
        public DoctorController(IDoctorService ds)
        {
            doctorService=ds;
        }

        public IActionResult Index()
        {
            doctorService.GetAll();
            return View();
        }
    }
}
