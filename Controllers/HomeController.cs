    using System.Diagnostics;
using ImportarPlanilhaExcel.Models;
using Microsoft.AspNetCore.Mvc;

namespace ImportarPlanilhaExcel.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
