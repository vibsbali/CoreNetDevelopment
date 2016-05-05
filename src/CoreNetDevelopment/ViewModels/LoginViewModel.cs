﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreNetDevelopment.ViewModels
{
    public class LoginViewModel
    {
        [Required][MaxLength(256)]
        public string Username { get; set; }

        [Required][DataType(DataType.Password)]
        public string Password { get; set; }

        public string ReturnUrl { get; set; } 
    }
}
