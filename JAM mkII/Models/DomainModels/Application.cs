using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [ForeignKey(nameof(Position))]
        public int JobId { get; set; }
        public Job Position { get; set; }

        //[ForeignKey(nameof(Store))]
        // public int JobId { get; set; }
        // public Job Store { get; set; }

        public DateTime ApplyDate { get; set; } = DateTime.Now;
        public int ResultId { get; set; } = 1;

        //pass / fail criteria for hirable
        public bool Disqualified { get; set; } = false;
        public bool PassedTest { get; set; } = false;
    }
}