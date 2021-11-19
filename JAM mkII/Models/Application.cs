using System;
using System.ComponentModel.DataAnnotations;

namespace JAM_mkII.Models
{
    public class Application
    {
        [Key] public int ApplicationId { get; set; }
        public int UserId { get; set; }
        public int JobId { get; set; }
        public DateTime ApplyDate { get; set; }
        public int ResultId { get; set; } = 1;

        //pass / fail criteria for hirable
        public bool Disqualified { get; set; } = false;
        public bool PassedTest { get; set; } = false;

        public Application(int jobId)
        {
            ApplyDate = DateTime.Now;
            JobId = jobId;
        }

        public Application()
        {

        }
    }
}