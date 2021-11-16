using System;

namespace JAM_mkII.Models
{
    public class Employment
    {
        private int JobId { get; set; }
        private DateTime StartDate { get; set; }
        private DateTime StopDate { get; set; }
        private string Comment { get; set; }
    }
}