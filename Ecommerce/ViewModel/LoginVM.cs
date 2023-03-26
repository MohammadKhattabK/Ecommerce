using System.ComponentModel.DataAnnotations;

namespace Ecommerce.ViewModel
{
    public class LoginVM
    {
        [EmailAddress]
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
