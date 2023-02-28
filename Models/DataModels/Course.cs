using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{ 

    public enum Level
    {
        Basic,
        Intermediate,
        Advanced
    } 

    public class Course : BaseEntity
    {
        [Required, StringLength(50)]
        public string? Name { get; set; }

        [Required, StringLength(280)]
        public string? DescriptionShort { get; set; }
        public string? DescriptionLong { get; set; }
        public string? TargetPublic { get; set; }
        public string? Objectives { get; set; }
        public string? Requirements { get; set; }
        public Level Levels { get; set; } = Level.Basic;

        [Required]
        public Chapter Chapter { get; set; } = new Chapter();

        [Required]
        public ICollection<Category> Categories { get; set; } = new List<Category>();

        [Required]
        public ICollection<Student> Students { get; set; } = new List<Student>();

    }
}
