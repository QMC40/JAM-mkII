using System.Linq;
using JAM_mkII.Models;
using Microsoft.AspNetCore.Mvc;

namespace JAM_mkII.Controllers
{
    public class JobListController : Controller
    {
        private JobManagerContext Context { get; set; }

        public JobListController(JobManagerContext ctx) => Context = ctx;


        // GET
        public IActionResult Index()
        {
            var jobs = Context.Jobs.OrderBy(j => j.StoreId).ToList();
            return View(jobs);
        }

        [HttpGet]
        public IActionResult CreateJob()
        {
            ViewBag.Positions = Context.Positions.OrderBy(p => p.PositionId).ToList();
            ViewBag.Stores = Context.Stores.OrderBy(s => s.StoreId).ToList();
            return View(new Job());
        }

        [HttpPost]
        public IActionResult CreateJob(Job subj)
        {
            if (ModelState.IsValid)
            {
                Context.Jobs.Add(subj);
                Context.SaveChanges();
                var jobs = Context.Jobs.OrderBy(j => j.StoreId).ToList();
                return View("Index", jobs);
            }
            else
            {
                ViewBag.Action = "There's a problem with your information, please check and resubmit";
                return View("CreateJob", subj);
            }
        }
    }
}