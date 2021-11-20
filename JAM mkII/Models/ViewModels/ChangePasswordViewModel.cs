﻿using System.ComponentModel.DataAnnotations;

namespace JAM_mkII.Models.ViewModels
{
    public class ChangePasswordViewModel
    {
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter password.")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "Please enter new password.")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
    }
}