using JAM_mkII.Models;
using Microsoft.AspNetCore.Mvc;

namespace JAM_mkII.Controllers
{
    public class ApplicationController : Controller
    {
    private JobManagerContext Context { get; set; }

        public ApplicationController(JobManagerContext ctx) => Context = ctx;
  
        // GET
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Apply(int id)
        {
            var job = Context.Jobs.Find(id);
            return View(job);
        }
    }
}