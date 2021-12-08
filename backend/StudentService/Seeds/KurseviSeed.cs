using Database;
using StudentService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentService.Seeds
{
    public class KurseviSeed
    {
        public static List<Kurs> Kursevi { get; } = new()
        {
            new Kurs { KursId = 1, NazivKursa = "Matematika"},
            new Kurs { KursId = 2, NazivKursa = "Fizika"},
            new Kurs { KursId = 3, NazivKursa = "Hemija" },
            new Kurs { KursId = 4, NazivKursa = "Programiranje" },
            new Kurs { KursId = 5, NazivKursa = "Programiranje 2" }
        };
    }
}
