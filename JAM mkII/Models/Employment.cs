using System;
using System.ComponentModel.DataAnnotations;

namespace JAM_mkII.Models
{
    public class Employment
    {
        [Key]
        public int EmploymentId { get; set; }
        public int JobId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StopDate { get; set; }
        public string Comment { get; set; }
    }
}