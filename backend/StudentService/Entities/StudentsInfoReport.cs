using StudentService.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentService.Entities
{
    public class StudentsInfoReport
    {
        public int StudentId { get; set; }
        public int BrojIndeksa { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Godina { get; set; }
        public int StatusStudentaId { get; set; }
        public Status NazivStatusa { get; set; }
    }
}
