using Microsoft.EntityFrameworkCore;
using Entities = StudentControl.PersonServices.Entities;

namespace StudentControl.DAL
{
    public class StudentControlContext : DbContext
    {
        public StudentControlContext(DbContextOptions<StudentControlContext> options) : base(options)
        {
        }

        public DbSet<Entities.Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entities.Person>().ToTable("PERSON");
        }
    }
}
