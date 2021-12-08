using StudentService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StudentService.Models
{
    public class EditStudentDTO
    {
        public int BrojIndeksa { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Godina { get; set; }
        public List<Kurs> Kursevi { get; set; } = new List<Kurs>();
    }
}
