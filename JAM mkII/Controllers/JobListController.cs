using System.Linq;
using JAM_mkII.Models;
using Microsoft.AspNetCore.Authorization;
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

        //disabled till identity db implemented
        //[Authorize]
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
        public IActionResult Apply(int id)
        {
            var job = Context.Jobs.Find(id);
            return  RedirectToAction("Apply", "Application",id);
        }

        //[HttpPost]
        //public IActionResult Apply(Job job)
        //{
        //    Context.Applications.Add();
        //}

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