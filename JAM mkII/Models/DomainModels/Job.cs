using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace JAM_mkII.Models.DomainModels
{
    public class Job
    {
        [Key] public int JobId { get; set; }
        [Range(1, 5)] public int PositionId { get; set; }
        public Position JobPosition { get; set; }
        [Range(1, 4)] public int StoreId { get; set; }
        public Store JobStore { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime CloseDate { get; set; }
    }
}