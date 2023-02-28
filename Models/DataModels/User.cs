using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    public class User : BaseEntity
    {
        [Required, StringLength(50)]
        public string? UserName { get; set; }

        [Required, StringLength(50)]
        public string? UserLastname { get; set; }

        [Required, EmailAddress]
        public string? Email { get; set; }
        
        [Required]
        public string? Password { get; set; }
    }
}
