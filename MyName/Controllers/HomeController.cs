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
                PersonViewModel personName = new PersonViewModel() { Name = name };
                return View("HelloName", personName);
            }
            return View();
        }
    }
}