using System.Linq;
using JAM_mkII.Areas.Admin.Models;
using JAM_mkII.Areas.Admin.Models.ViewModels;
using JAM_mkII.Models;
using JAM_mkII.Models.DomainModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JAM_mkII.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class JobAdminController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<User> userManager;
        private JobManagerContext Context { get; }

        public JobAdminController(JobManagerContext ctx, UserManager<User> userMngr,
            RoleManager<IdentityRole> roleMngr)
        {
            userManager = userMngr;
            roleManager = roleMngr;
            Context = ctx;
        }

        public IActionResult JobMgmt()
        {
            var jobs =
                Context.Jobs
                    .Include(p => p.JobPosition)
                    .Include(s => s.JobStore)
                    .OrderBy(j => j.JobId)
                    .ToList();
            var apps =
                Context.Applications
                    .OrderBy(a => a.ApplicationId)
                    .ToList();

            JobViewModel model = new()
            {
                Jobs = jobs,
                Applications = apps,
            };
            return View(model);
        }

        public IActionResult Add()
        {
            ViewBag.Action = "Add Job";
            ViewBag.Positions = Context.Positions.Where(p => p.PositionName != "Applicant" && p.PositionName != "Owner").OrderBy(p => p.PositionId)
                .ToList();
            ViewBag.Stores = Context.Stores.OrderBy(s => s.StoreId).ToList();

            return View("Edit", new Job());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit Job";
            ViewBag.Positions = Context.Positions.Where(p => p.PositionName != "Applicant" && p.PositionName != "Owner").OrderBy(p => p.PositionId)
                .ToList();
            ViewBag.Stores = Context.Stores.OrderBy(s => s.StoreId).ToList();
            var job = Context.Jobs.Find(id);
            return View(job);
        }

        [HttpPost]
        public IActionResult Edit(Job job)
        {
            if (ModelState.IsValid)
            {
                if (job.JobId == 0)
                    Context.Jobs.Add(job);
                else
                    Context.Jobs.Update(job);

                Context.SaveChanges();
                return RedirectToAction("JobMgmt");
            }
            else
            {
                ViewBag.Action = job.JobId == 0 ? "Add" : "Edit";
                ViewBag.Positions = Context.Positions.Where(p => p.PositionName != "Applicant")
                    .OrderBy(p => p.PositionId)
                    .ToList();
                ViewBag.Stores = Context.Stores.OrderBy(s => s.StoreId).ToList();
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
            return RedirectToAction("JobMgmt");
        }
    }
}