using Microsoft.AspNetCore.Mvc;

namespace JAM_mkII.Controllers
{
    public class JobListController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}