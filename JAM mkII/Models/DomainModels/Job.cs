using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JAM_mkII.Models.DomainModels
{
    public class Job
    {
        [Key] public int JobId { get; set; }

        [ForeignKey(nameof(PositionName))]
        public int PositionId { get; set; }
        public Position PositionName { get; set; }

        [ForeignKey(nameof(StoreName))]
        public int StoreId { get; set; }
        public Store StoreName { get; set; }

        public DateTime OpenDate
        { get; set; }
        public DateTime CloseDate { get; set; }
    }
}