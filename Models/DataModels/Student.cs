using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    public class Student : BaseEntity
    {
        [Required, StringLength(50)]
        public string? Name { get; set; }
        [Required, StringLength(50)]
        public string? Lastname { get; set; }
        [Required]
        public DateTime Birthday { get; set; }

        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
