using Store.Management.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Store.Management.Controllers
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