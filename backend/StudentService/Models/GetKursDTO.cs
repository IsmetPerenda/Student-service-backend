using StudentService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentService.Models
{
    public class GetKursDTO
    {
        public int KursId { get; set; }
        public string NazivKursa { get; set; }
        public List<Student> Studenti { get; set; } = new List<Student>();
    }
}
