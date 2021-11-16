using Microsoft.AspNetCore.Mvc;

namespace JAM_mkII.Controllers
{
    public class ApplicationController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}