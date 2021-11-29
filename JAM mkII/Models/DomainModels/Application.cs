using System;
using System.ComponentModel.DataAnnotations;

namespace JAM_mkII.Models.DomainModels
{
    public class Application
    {
        public Application()
        {
        }

        [Key]
        public int ApplicationId { get; set; }
        public string UserId { get; set; }
        public string ApplicantName { get; set; }
        public int JobId { get; set; }
        public string Position { get; set; }
        public string StoreLoc { get; set; }
        public DateTime ApplyDate { get; set; } = DateTime.Now;
        public int ResultId { get; set; } = 1;

        //pass / fail criteria for suitable candidate
        public bool Disqualified { get; set; } = false;
        public bool PassedTest { get; set; } = false;
    }
}