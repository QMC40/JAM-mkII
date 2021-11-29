using System.Threading.Tasks;
using JAM_mkII.Areas.Admin.Models;
using JAM_mkII.Models;
using JAM_mkII.Models.DomainModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace JAM_mkII.Controllers
{
    public class ApplicationController : Controller
    {
        private readonly UserManager<User> userManager;

        public ApplicationController(UserManager<User> userMngr,
            JobManagerContext ctx)
        {
            userManager = userMngr;
            Context = ctx;
        }

        private JobManagerContext Context { get; }


        [HttpGet]
        public async Task<IActionResult> Apply(Job job)
        {
            var user = await userManager.GetUserAsync(User);
            ViewBag.name = user.FName + " " + user.LName;
            ViewBag.store = Context.Stores.Find(job.StoreId).StoreName;
            ViewBag.position = Context.Positions.Find(job.PositionId).PositionName;
            var id = userManager.GetUserId(User);
            var jobApp = new Application
            {
                UserId = id,
                JobId = job.JobId
            };
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

        public async Task<IActionResult> Review(int Id)
        {
            var app = await Context.Applications.FindAsync(Id);
            return View(app);
        }

        public async Task<IActionResult> Delete(int Id)
        {
            var app = await Context.Applications.FindAsync(Id);
            return View(app);
        }

        [HttpPost]
        public IActionResult Delete(Application app)
        {
            Context.Applications.Remove(app);
            Context.SaveChanges();
            return RedirectToAction("JobMgmt", "JobAdmin", new { area = "Admin" });
        }
    }
}