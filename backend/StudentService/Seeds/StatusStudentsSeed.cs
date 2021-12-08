using StudentService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentService.Seeds
{
    public class StatusStudentsSeed
    {
        public static List<StatusStudent> StatusStudents { get; } = new()
        {
            new StatusStudent { StatusStudentaId = 1, NazivStatusa = Common.Status.Redovan },
            new StatusStudent { StatusStudentaId = 2, NazivStatusa = Common.Status.Redovan },
            new StatusStudent { StatusStudentaId = 3, NazivStatusa = Common.Status.Vanredan },
            new StatusStudent { StatusStudentaId = 4, NazivStatusa = Common.Status.Redovan },
            new StatusStudent { StatusStudentaId = 5, NazivStatusa = Common.Status.Redovan },
            new StatusStudent { StatusStudentaId = 6, NazivStatusa = Common.Status.Redovan },
            new StatusStudent { StatusStudentaId = 7, NazivStatusa = Common.Status.Redovan },
            new StatusStudent { StatusStudentaId = 8, NazivStatusa = Common.Status.Vanredan },
            new StatusStudent { StatusStudentaId = 9, NazivStatusa = Common.Status.Vanredan },
            new StatusStudent { StatusStudentaId = 10, NazivStatusa = Common.Status.Redovan },
            new StatusStudent { StatusStudentaId = 11, NazivStatusa = Common.Status.Redovan },
            new StatusStudent { StatusStudentaId = 12, NazivStatusa = Common.Status.Vanredan },
            new StatusStudent { StatusStudentaId = 13, NazivStatusa = Common.Status.Vanredan },
            new StatusStudent { StatusStudentaId = 14, NazivStatusa = Common.Status.Redovan },
        };
    }
}
