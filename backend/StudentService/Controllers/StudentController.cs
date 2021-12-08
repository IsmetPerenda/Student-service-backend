using Microsoft.AspNetCore.Mvc;
using StudentService.Interfaces;
using StudentService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentService.Controllers
{
    [ApiController]
    [Route("api/student")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentsService _studentsService;
        public StudentController(IStudentsService studentsService)
        {
            _studentsService = studentsService;
        }

        [HttpGet("get_students")]
        public async Task<ActionResult<List<GetStudentDTO>>> GetAllstudents()
        {
            return Ok(await _studentsService.GetStudentsAsync());
        }

        [HttpGet("get_student")]
        public async Task<ActionResult<GetStudentDTO>> GetStudent(int id)
        {
            return Ok(await _studentsService.GetStudentAsync(id));
        }

        [HttpPost("add_student")]
        public async Task<ActionResult<int>> AddStudent([FromBody] AddStudentDTO student)
        {
            return Ok(await _studentsService.AddStudentAsync(student));
        }

        [HttpPut("edit_student")]
        public async Task<ActionResult<int>> EditStudent([FromBody] EditStudentDTO student,int id)
        {
            return Ok(await _studentsService.EditStudentAsync(student,id));
        }

        [HttpDelete("delete_student")]
        public async Task<ActionResult<int>> DeleteStatusOfStudetn(int id)
        {
            return Ok(await _studentsService.DeleteStudentAsync(id));
        }
    }
}
