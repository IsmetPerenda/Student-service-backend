using Microsoft.EntityFrameworkCore;
using StudentService.Entities;
using StudentService.Seeds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<StatusStudent> StatusStudents { get; set; }
        public DbSet<StudentsInfoReport> StudentsInfoReport { get; set; }
        public DbSet<KurseviStudenta> KurseviStudenta { get; set; }
        public DbSet<StudentiNaKursu> StudentiNaKursu { get; set; }
        public DbSet<Kurs> Kursevi { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(StudentsSeed.Students);
            modelBuilder.Entity<StatusStudent>().HasData(StatusStudentsSeed.StatusStudents);
            modelBuilder.Entity<Kurs>().HasData(KurseviSeed.Kursevi);

            modelBuilder.Entity<StudentsInfoReport>().HasNoKey();
            modelBuilder.Entity<StudentiNaKursu>().HasNoKey();
            modelBuilder.Entity<KurseviStudenta>().HasNoKey();
        }
    }



}
