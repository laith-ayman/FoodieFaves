﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF.Models.Dto.UserDto
{
    public class ResetPasswordDto
    {
        [EmailAddress]
        public string Email { get; set; }
        public string Token { get; set; }
        public string NewPassword { get; set; }
        [Compare("NewPassword")]
        public string ConfirmNewPassword { get; set; }
    }
}