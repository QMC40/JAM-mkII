using System;
using System.ComponentModel.DataAnnotations;

namespace JAM_mkII.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Ssn { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime DoB { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int Position { get; set; }
    }
}