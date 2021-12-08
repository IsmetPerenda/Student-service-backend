using Microsoft.AspNetCore.Mvc;
using StudentService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentService.Interfaces
{
    public interface IStudentsService
    {
        Task<List<GetStudentDTO>> GetStudentsAsync();
        Task<GetStudentDTO> GetStudentAsync(int id);
        Task<int> AddStudentAsync(AddStudentDTO student);
        Task<int> EditStudentAsync(EditStudentDTO student,int id);
        Task<int> DeleteStudentAsync(int id);
      
    }
}
