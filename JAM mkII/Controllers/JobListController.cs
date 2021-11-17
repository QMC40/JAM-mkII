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
    }
}