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
    public class ReportService : IReportService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public ReportService(IMapper mapper,DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<List<StudentsInfoReport>> GetStudentsInfoAsync(int studentID)
        {
            return await _context.StudentsInfoReport.FromSqlRaw("EXEC [dbo].[GetStudentsInfoProcedure] {0};", studentID).ToListAsync(); 
        }

        public async Task<List<StudentiNaKursu>> GetAllStudentsOnKursAsync(int id)
        {
            return await  _context.StudentiNaKursu.FromSqlRaw("EXEC [dbo].[GetAllStudentsOnKurs] {0};", id).ToListAsync();

        }

        public async Task<List<KurseviStudenta>> GetAllKursesOfStudentAsync(int id)
        {
            return await _context.KurseviStudenta.FromSqlRaw("EXEC [dbo].[GetAllKursesOfStudent] {0};", id).ToListAsync();
        }
    }
}
