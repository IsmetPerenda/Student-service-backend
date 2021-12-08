using Microsoft.AspNetCore.Mvc;
using StudentService.Entities;
using StudentService.Interfaces;
using StudentService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentService.Controllers
{
    [ApiController]
    [Route("api/reports")]
    public class ReportController : ControllerBase
    {
        private readonly IReportService _reportsService;

        public ReportController(IReportService reportsService)
        {
            _reportsService = reportsService;
        }

        [HttpGet("get_student_info")]
        public async Task<ActionResult<List<StudentsInfoReport>>> GetStudentsInfo(int studentID)
        {
            return Ok(await _reportsService.GetStudentsInfoAsync(studentID));
        }

        [HttpGet("get_kurs_with_all_students")]
        public async Task<ActionResult<List<StudentiNaKursu>>> GetAllStudentsOnKurs(int id)
        {
            return Ok(await _reportsService.GetAllStudentsOnKursAsync(id));
        }

        [HttpGet("get_student_kurses")]
        public async Task<ActionResult<List<StudentiNaKursu>>> GetAllStudentKurses(int id)
        {
            return Ok(await _reportsService.GetAllKursesOfStudentAsync(id));
        }
    }
}
