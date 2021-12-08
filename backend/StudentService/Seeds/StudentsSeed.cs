using StudentService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentService.Seeds
{
    public class StudentsSeed
    {
        public static List<Student> Students { get; } = new()
        {
            new Student { StudentId = 1, BrojIndeksa = 111, Ime = "Chris", Prezime = "Hemsworth", Godina = 1 },
            new Student { StudentId = 2, BrojIndeksa = 122, Ime = "Natalie", Prezime = "Portman", Godina = 2 },
            new Student { StudentId = 3, BrojIndeksa = 133, Ime = "Brianna", Prezime = "Wong", Godina = 3 },
            new Student { StudentId = 4, BrojIndeksa = 144, Ime = "James ", Prezime = "Hines", Godina = 1 },
            new Student { StudentId = 5, BrojIndeksa = 155, Ime = "Leon ", Prezime = "Moran", Godina = 2 },
            new Student { StudentId = 6, BrojIndeksa = 166, Ime = "Simpson ", Prezime = "Evans", Godina = 3 },
            new Student { StudentId = 7, BrojIndeksa = 177, Ime = "Mccullough ", Prezime = "Curry", Godina = 1 },
            new Student { StudentId = 8, BrojIndeksa = 188, Ime = "Angelia ", Prezime = "Ruiz", Godina = 2 },
            new Student { StudentId = 9, BrojIndeksa = 199, Ime = "Hinton ", Prezime = "Love", Godina = 3 },
            new Student { StudentId = 10, BrojIndeksa = 211, Ime = "Adrienne ", Prezime = "Logan", Godina = 1 },
            new Student { StudentId = 11, BrojIndeksa = 222, Ime = "Broderick ", Prezime = "Bentley", Godina = 2 },
            new Student { StudentId = 12, BrojIndeksa = 233, Ime = "Hiram ", Prezime = "Garcia", Godina = 3 },
            new Student { StudentId = 13, BrojIndeksa = 244, Ime = "Deshawn ", Prezime = "Cummings", Godina = 1 },
            new Student { StudentId = 14, BrojIndeksa = 255, Ime = "Normand ", Prezime = "Hughes", Godina = 2 }
   
            };
    }
}
