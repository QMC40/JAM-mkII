using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace JAM_mkII.Areas.Admin.Models.ViewModels
{
    public class UserViewModel
    {
        public IEnumerable<User> Users { get; set; }
        public IEnumerable<IdentityRole> Roles { get; set; }
    }
}