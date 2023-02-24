using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
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
        public enum Level
        {
            Basic,
            Intermediate,
            Advanced
        }
    }
}
