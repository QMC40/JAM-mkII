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
            var jobs = Context.Jobs.OrderBy(j => j.JobId).ToList();
            return View(jobs);
        }

        public IActionResult JobAdmin()
        {
            var jobs = Context.Jobs.OrderBy(j => j.JobId).ToList();
            return View(jobs);
        }

        public IActionResult Add()
        {
            ViewBag.Action = "Add Job";
            return View("Edit", new Job());
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

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit Job";
            var job = Context.Jobs.Find(id);
            return View(job);
        }


        [HttpPost]
        public IActionResult Edit(Job job)
        {
            if (ModelState.IsValid)
            {
                if (job.JobId == 0)
                {
                    Context.Jobs.Add(job);
                }
                else
                {
                    Context.Jobs.Update(job);
                }

                Context.SaveChanges();
                return RedirectToAction("JobAdmin");
            }
            else
            {
                ViewBag.Action = (job.JobId == 0) ? "Add" : "Edit";
                return View(job);
            }

        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var job = Context.Jobs.Find(id);
            return View(job);
        }

        [HttpPost]
        public IActionResult Delete(Job job)
        {
            Context.Jobs.Remove(job);
            Context.SaveChanges();
            return RedirectToAction("JobAdmin");
        }




    }
}