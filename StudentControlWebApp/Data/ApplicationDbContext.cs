using Microsoft.EntityFrameworkCore;
using StudentControlWebApp.Entities;

namespace StudentControlWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Belt> Belts { get; set; }
        public DbSet<Person> Persons {get; set;}

        /// <summary>
        /// Se mapea la entidad con la tabla en la BDD
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Belt>().ToTable("BELT");
            modelBuilder.Entity<Person>().ToTable("PERSON");
        }
    }
}