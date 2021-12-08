using StudentService.Entities;
using StudentService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentService.Interfaces
{
    public interface IReportService
    {
        Task<List<StudentsInfoReport>> GetStudentsInfoAsync(int studentID);

        Task<List<StudentiNaKursu>> GetAllStudentsOnKursAsync(int id);
        Task<List<KurseviStudenta>> GetAllKursesOfStudentAsync(int id);
    }
}
