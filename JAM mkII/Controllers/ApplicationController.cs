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
            else
            {
                return Ok("something is fucked");
            }
            // var test = jobApp.JobId;
            // return Ok($"here we are job {test}");
        }

    }
}