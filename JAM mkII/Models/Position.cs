using System.ComponentModel.DataAnnotations;

namespace JAM_mkII.Models
{
    public class Position
    {
        [Key]
        public int PositionId { get; set; }
        public string PositionName { get; set; }
    }
}