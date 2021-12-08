using StudentService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentService.Interfaces
{
    public interface IStatusStudentService
    {
        Task<List<GetStatusStudentDTO>> GetStatusOfAllStudentsAsync();
        Task<GetStatusStudentDTO> GetStatusStudentAsync(int id);
        Task<int> AddStatusStudentAsync(AddStatusStudentDTO statusStudent);
        Task<int> EditStatusStudentAsync(EditStatusStudentDTO statusStudent, int id);
        Task<int> DeleteStatusStudentAsync(int id);
    }
}
