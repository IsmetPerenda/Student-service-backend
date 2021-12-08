using StudentService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentService.Models
{
    public class EditKursDTO
    {
        public string NazivKursa { get; set; }
        public List<Entities.Student> Studenti { get; set; } = new List<Student>();
    }
}
