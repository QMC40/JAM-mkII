using System;
using System.ComponentModel.DataAnnotations;

namespace JAM_mkII.Models.DomainModels
{
    public class Job
    {
        [Key] public int JobId { get; set; }

        public int PositionId { get; set; }
        public Position JobPosition { get; set; }

        public int StoreId { get; set; }
        public Store JobStore { get; set; }

        public DateTime OpenDate
        { get; set; }
        public DateTime CloseDate { get; set; }
    }
}