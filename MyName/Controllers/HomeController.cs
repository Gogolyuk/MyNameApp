using Microsoft.AspNetCore.Mvc;
using MyName.Models;

namespace MyName.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string name)
        {
            if (name != null)
            {
                Person.Name = name;
                return View("HelloName", name);
            }
            return View();
        }
    }
}