using UniversityApiBackend.Models.DataModels;

namespace UniversityApiBackend.Services
{
    public interface IStudentsService
    {
        public IEnumerable<Student> GetStudents();
        public IEnumerable<Student> GetStudentsWithCourses();
    }
}
