using AutoMapper;
using StudentService.Entities;
using StudentService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentService
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Student, GetStudentDTO>();
            CreateMap<StatusStudent, GetStatusStudentDTO>();
            CreateMap<Kurs, GetKursDTO>();
        }
    }
}
