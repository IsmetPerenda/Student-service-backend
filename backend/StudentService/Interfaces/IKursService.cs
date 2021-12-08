using StudentService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentService.Interfaces
{
    public interface IKursService
    {
        Task<List<GetKursDTO>> GetAllAsync();
        Task<GetKursDTO> GetKursAsync(int id);
        Task<int> AddKurs(AddKursDTO kurs);
        Task<int> EditKurs(EditKursDTO kurs, int id);
        Task<int> DeleteKurs(int id);
      
    }
}
