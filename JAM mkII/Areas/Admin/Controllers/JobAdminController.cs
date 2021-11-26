﻿using System.Linq;
using System.Threading.Tasks;
using JAM_mkII.Models;
using JAM_mkII.Models.DomainModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace JAM_mkII.Areas.Admin.Controllers
{
    // [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class JobAdminController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<User> userManager;

        public JobAdminController(JobManagerContext ctx, UserManager<User> userMngr,
            RoleManager<IdentityRole> roleMngr)
        {
            userManager = userMngr;
            roleManager = roleMngr;
            Context = ctx;
        }

        private JobManagerContext Context { get; }

        //disabled till identity db implemented
        //[Authorize]
        public async Task<IActionResult> JobMgmt()
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
                    Context.Jobs.Add(job);
                else
                    Context.Jobs.Update(job);

                Context.SaveChanges();
                return RedirectToAction("JobMgmt");
            }

            ViewBag.Action = job.JobId == 0 ? "Add" : "Edit";
            return View(job);
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