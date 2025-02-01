using Microsoft.EntityFrameworkCore;
using Sql_and_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql_and_EF.Data
{
    public class AppDbContext : DbContext
    {
        //Connection string
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MakingScienceSweeftAccelerationDb;Trusted_Connection=True;ConnectRetryCount=0");
        //db schema
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //many to many relationship
            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.Pupils)
                .WithMany(p => p.Teachers)
                .UsingEntity(j => j.ToTable("TeacherPupil"));
        }
        //db sets
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Pupil> Pupils { get; set; }

    }
}
