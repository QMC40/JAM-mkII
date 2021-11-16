using System;
using System.ComponentModel.DataAnnotations;

namespace JAM_mkII.Models
{
    public class Job
    {
        private int JobId { get; set; }
        private string Position { get; set; }
        private DateTime OpenDate { get; set; }
        private DateTime CloseDate { get; set; }
    }
}