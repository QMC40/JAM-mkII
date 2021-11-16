using System;
using System.ComponentModel.DataAnnotations;

namespace JAM_mkII.Models
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }
        public string Position { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime CloseDate { get; set; }
    }
}