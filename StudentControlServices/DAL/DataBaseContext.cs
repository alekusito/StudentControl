using Microsoft.EntityFrameworkCore;
using PersonEntities = StudentControl.PersonServices.Entities;
using ParametrizationEntities = StudentControl.ParametrizationServices.Entities;

namespace StudentControl.DAL
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }

        public DbSet<PersonEntities.Person> Persons { get; set; }
        public DbSet<ParametrizationEntities.Belt> Belts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonEntities.Person>().ToTable("PERSON");
            modelBuilder.Entity<ParametrizationEntities.Belt>().ToTable("BELT");
        }
    }
}
