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
    [Route("api/status_student")]
    public class StatusStudentController : ControllerBase
    {
        
        private readonly IStatusStudentService _studentsStatusService;
        public StatusStudentController(IStatusStudentService studentsStatusService)
        {
            _studentsStatusService = studentsStatusService;
        }


        [HttpGet("get_students_status")]
        public async Task<ActionResult<List<GetStatusStudentDTO>>> GetAllStatusOfStudents()
        {
            return Ok(await _studentsStatusService.GetStatusOfAllStudentsAsync());
        }

        [HttpGet("get_student_status")]
        public async Task<ActionResult<GetStatusStudentDTO>> GetStatusOfStudent(int id)
        {
            return Ok(await _studentsStatusService.GetStatusStudentAsync(id));
        }

        [HttpPost("add_status_student")]
        public async Task<ActionResult<int>> AddStudent([FromBody] AddStatusStudentDTO statusstudent)
        {
            return Ok(await _studentsStatusService.AddStatusStudentAsync(statusstudent));
        }

        [HttpPut("edit_status_student")]
        public async Task<ActionResult<int>> EditStatusOfStudent([FromBody] EditStatusStudentDTO statusstudent, int id)
        {
            return Ok(await _studentsStatusService.EditStatusStudentAsync(statusstudent, id));
        }

        [HttpDelete("delete_student_status")]
        public async Task<ActionResult<int>> DeleteStatusOfStudetn( int id)
        {
            return Ok(await _studentsStatusService.DeleteStatusStudentAsync(id));
        }

    }
}
