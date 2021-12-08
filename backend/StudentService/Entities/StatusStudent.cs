using StudentService.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentService.Entities
{
    public class StatusStudent
    {
        [Key]
        public int StatusStudentaId { get; set; }
        public Status NazivStatusa { get; set; } = Status.Redovan;
        
    }
     
}
