using JAM_mkII.Models;
using JAM_mkII.Models.DomainModels;
using Microsoft.AspNetCore.Mvc;

namespace JAM_mkII.Controllers
{
    public class ApplicationController : Controller
    {
        public ApplicationController(JobManagerContext ctx)
        {
            Context = ctx;
        }

        private JobManagerContext Context { get; }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Apply(Job job)
        {
            var jobApp = new Application(job.JobId);
            return View(jobApp);
        }


        [HttpPost]
        public IActionResult Apply(Application jobApp)
        {
            if (ModelState.IsValid)
            {
                Context.Applications.Add(jobApp);
                Context.SaveChanges();
                return RedirectToAction("Index", "JobList");
            }

            return Ok("something is wrong");
        }
    }
}