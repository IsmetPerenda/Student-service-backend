using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentService.Entities
{
    public class Kurs
    {
        public int KursId { get; set; }
        public string NazivKursa { get; set; }
        public List<Student> Studenti { get; set; } = new List<Student>();
    }
}
