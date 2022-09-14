using Microsoft.AspNetCore.Mvc;
using MyAspDemos.Areas.Demo.ViewModels;

namespace MyAspDemos.Areas.Demo.Controllers
{
    [Area("Demo")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Ok("Hello world");
        }

        public IActionResult Index2()
        {
            return View();
        }

        public IActionResult DisplayCustomer()
        {
            CustomerViewModel obj = new CustomerViewModel();
            return View(obj);
        }

        public IActionResult DisplayEmployee()
        {
            EmployeeViewModel obj=new EmployeeViewModel();
                return View();
        }
    }
}
