﻿using System.ComponentModel.DataAnnotations;

namespace Ecommerce.ViewModel
{
    public class RegisterVM
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        [Compare("Password")]
        public string? ConfiremPassword { get; set; }
    }
}
