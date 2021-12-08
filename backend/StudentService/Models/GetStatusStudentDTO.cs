using StudentService.Common;
using StudentService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentService.Models
{
    public class GetStatusStudentDTO
    {
        public int StatusStudentaId { get; set; }
        public Status NazivStatusa { get; set; }
     
      
    }
}
