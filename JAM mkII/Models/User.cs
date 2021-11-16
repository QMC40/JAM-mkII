using System;

namespace JAM_mkII.Models
{
    public class User
    {
        private int UserId { get; set; }
        private string Ssn { get; set; }
        private string FName { get; set; }
        private string LName { get; set; }
        private DateTime DoB { get; set; }
        private string Phone { get; set; }
        private string Address { get; set; }
        private int Position { get; set; }
    }
}