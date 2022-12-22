using Microsoft.AspNetCore.Mvc;

namespace AspNetProject.Contorollers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.Name = "Urfan";
            //ViewData["Surname"] = "Pahlavanov";
            //TempData["Age"] = 21;
            //return RedirectToAction("Test");
            return View();  
        }

      
        public IActionResult Test()
        {
            return View();
        }
    }
}
