using UniversityApiBackend.Models.DataModels;
namespace UniversityApiBackend.Services
{
    public class Services
    {
        //Search users by email
        public static void SearchByEmail(string userEmail) 
        {
            var userList = new[]
            {
                new User
                {
                    Id = 1,
                    UserName = "Tomas",
                    UserLastname = "da Silveira",
                    Email = "tomasda@email.com",
                    Password = "1232345"
                },
                new User
                {
                    Id = 2,
                    UserName = "Gonzalo",
                    UserLastname = "Montiel",
                    Email = "gonzalo@email.com",
                    Password = "444448"
                },
                new User
                {
                    Id = 3,
                    UserName = "Manuel",
                    UserLastname = "Barrios",
                    Email = "manu@email.com",
                    Password = "5555555553"
                },
            };

            var foundUser = from user in userList
                            where user.Email == userEmail
                            select user.UserName;
        }

        public static void SearchStudents() 
        {

            var classRoom = new[]
            {
                new Student
                {
                    Id = 1,
                    Name = "Tomas",
                    Lastname = "da Silveira",
                    Age = 17,
                },
                new Student
                {
                    Id = 2,
                    Name = "Emiliano",
                    Lastname = "Martinez",
                    Age = 19,
                },
                new Student
                {
                    Id = 3,
                    Name = "Enzo",
                    Lastname = "Fernandez",
                    Age = 22,
                },
                new Student
                {
                    Id = 4,
                    Name = "Nicolas",
                    Lastname = "Tagliafico",
                    Age = 18,
                    Courses = new[] 
                    {
                        new Course 
                        {
                            Id = 1,
                            Name = "Data Science",
                            Level = Level.Advanced 
                        }
                    }
                }
            };

            //Search for students of legal age
            var majorityStudents = from student in classRoom
                                   where student.Age > 18
                                   select student.Name;

            //Search for students with at least one course
            var studentsWithCourse = from student in classRoom
                                     where student.Courses.Any()
                                     select student.Name;
        }

        public static void SearchCourses() 
        {
            var courseList = new[]
            {
                new Course
                {
                    Id = 1,
                    Name = "Data Science",
                    Level = Level.Advanced,
                    Students = new[]
                    {
                        new Student
                        {
                          Id = 4,
                          Name = "Nicolas",
                          Lastname = "Tagliafico",
                          Age = 18
                        }
                    }
                },
                new Course
                {
                    Id = 2,
                    Name = "Cybersecurity",
                    Level = Level.Basic,
                    Categories = new[] 
                    {
                        new Category 
                        {
                            Name = "Computer Science" 
                        }
                    }

                },
                new Course
                {
                    Id = 3,
                    Name = "Introduction To Algorithms",
                    Level = Level.Basic,
                    Categories = new[]
                    {
                        new Category
                        {
                            Name = "Computer Science"
                        }
                    }
                }
            };

            //Search for courses at a given level that have at least one student enrolled.
            var advancedCoursesWithAny = from course in courseList
                                         where course.Level == Level.Advanced
                                         && course.Students.Any()
                                         select course.Name;

            //Search for courses of a given level that are of a given category
            var coursesComputerScienceBasics = from course in courseList
                                               where course.Level == Level.Basic
                                               && course.Categories.All(category => category.Name == "Computer Science")
                                               select course.Name;

            //Search for courses without students
            var coursesWithoutStudents = from course in courseList
                                         where course.Students.Count() == 0
                                         select course.Name;
        }
    }
}
