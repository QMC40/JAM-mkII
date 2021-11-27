using System.Collections.Generic;
using JAM_mkII.Models.DomainModels;

namespace JAM_mkII.Areas.Admin.Models.ViewModels
{
    public class JobViewModel
    {
        public IEnumerable<Job> Jobs { get; set; }
        public IEnumerable<Application> Applications { get; set; }
    }
}