using AutoMapper;
using Database;
using Microsoft.AspNetCore.Mvc;
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
    public class StudentsService : IStudentsService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public StudentsService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<int> AddStudentAsync(AddStudentDTO student)
        {
            var AddStudent = new Student
            {
                BrojIndeksa = student.BrojIndeksa,
                Ime = student.Ime,
                Prezime = student.Prezime,
                Godina = student.Godina,
               

            };

            await _context.Students.AddAsync(AddStudent);
            await _context.SaveChangesAsync();

            return AddStudent.StudentId;
        }

        public async Task<int> EditStudentAsync(EditStudentDTO student, int id)
        {
            Student s = _context.Students.Find(id);

            if (!string.IsNullOrEmpty(student.Ime) && student.Ime != "string")
            {
                s.Ime = student.Ime;
            }
            if (!string.IsNullOrEmpty(student.Prezime) && student.Prezime != "string")
            {
                s.Prezime = student.Prezime;
            }
            if (student.BrojIndeksa != 0)
            {
                s.BrojIndeksa = student.BrojIndeksa;
            }
            if (student.Godina != 0)
            {
                s.Godina = student.Godina;
            }
            await _context.SaveChangesAsync();

            return id;
        }
        public async Task<GetStudentDTO> GetStudentAsync(int id)
        {
            var x = await _context.Students.FirstOrDefaultAsync(x => x.StudentId == id);

            var student = _mapper.Map<GetStudentDTO>(x);

            return student;
        }

        public async Task<List<GetStudentDTO>> GetStudentsAsync()
        {
            return await _context.Students.Select(x => _mapper.Map<GetStudentDTO>(x)).ToListAsync();
        }

        public async Task<int> DeleteStudentAsync(int id)
        {
            if(id <= 0)
            {
                return 1;
            }
            Student stu = await _context.Students.FirstOrDefaultAsync(x => x.StudentId == id);

            _context.Remove(stu);
            await _context.SaveChangesAsync();

            return 0;

        }


    }
}
