using Microsoft.EntityFrameworkCore;
using UniversityApiBackend.Models.DataModels;

namespace UniversityApiBackend.DataAcces
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options): base(options) 
        {

        }

        //Add DbSets(tables of db)
        public DbSet<Course>? Courses { get; set; }
    }
}
