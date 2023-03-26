using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class Contact
    {
        [Key]
        public int CoId { get; set; }
        [Required(ErrorMessage = "الاسم مطلوب")]
        public string? Name { get; set; }
        [Required(ErrorMessage ="البريد الإلكتروني مطلوب")]
        [EmailAddress]
        public string? Email { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
    }
}
