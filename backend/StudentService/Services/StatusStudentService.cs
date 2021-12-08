using AutoMapper;
using Database;
using Microsoft.EntityFrameworkCore;
using StudentService.Entities;
using StudentService.Interfaces;
using StudentService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentService.Services
{
    public class StatusStudentService : IStatusStudentService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public StatusStudentService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<int> AddStatusStudentAsync(AddStatusStudentDTO statusStudent)
        {
            var AddStatusStudent = new StatusStudent
            {
                NazivStatusa = statusStudent.NazivStatusa,
                

            };

            await _context.StatusStudents.AddAsync(AddStatusStudent);
            await _context.SaveChangesAsync();

            return AddStatusStudent.StatusStudentaId;
        }

        public async Task<int> DeleteStatusStudentAsync(int id)
        {
            if (id <= 0)
            {
                return 1;
            }
            StatusStudent ss = await _context.StatusStudents.FirstOrDefaultAsync(x => x.StatusStudentaId == id);

            _context.Remove(ss);
            await _context.SaveChangesAsync();

            return 0;
        }

        public async Task<int> EditStatusStudentAsync(EditStatusStudentDTO statusStudent, int id)
        {
            StatusStudent ss = _context.StatusStudents.Find(id);

          
                ss.NazivStatusa= statusStudent.NazivStatusa;
            
               await _context.SaveChangesAsync();

            return id;
        }

        public async Task<List<GetStatusStudentDTO>> GetStatusOfAllStudentsAsync()
        {
            return await _context.StatusStudents.Select(x => _mapper.Map<GetStatusStudentDTO>(x)).ToListAsync();
        }

        public async Task<GetStatusStudentDTO> GetStatusStudentAsync(int id)
        {
            var x = await _context.StatusStudents.FirstOrDefaultAsync(x => x.StatusStudentaId == id);

            var status = _mapper.Map<GetStatusStudentDTO>(x);

            return status;
        }
    }
}
