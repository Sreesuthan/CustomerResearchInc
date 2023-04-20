﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerResearchInc.Shared
{
    public class SignIn
    {
        [Required]
        [EmailAddress(ErrorMessage = "Enter valid email address.")]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        public bool RememberMe { get; set; }

    }
}
