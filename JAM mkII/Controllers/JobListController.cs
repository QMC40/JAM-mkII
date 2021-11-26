using System.Linq;
using JAM_mkII.Models;
using Microsoft.AspNetCore.Mvc;

namespace JAM_mkII.Controllers
{
    public class JobListController : Controller
    {
        public JobListController(JobManagerContext ctx)
        {
            Context = ctx;
        }

        private JobManagerContext Context { get; }


        // GET
        public IActionResult Index()
        {
            var jobs = Context.Jobs.OrderBy(j => j.JobId).ToList();
            return View(jobs);
        }

        [HttpGet]
        public IActionResult Apply(int id)
        {
            var job = Context.Jobs.Find(id);
            return RedirectToAction("Apply", "Application", job);
        }

    }
}