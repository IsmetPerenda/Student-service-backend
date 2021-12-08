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
    [Route("api/kurs")]
    public class KursController : ControllerBase
    {
        private readonly IKursService _kursService;
        public KursController(IKursService kursService)
        {
            _kursService = kursService;
        }
        [HttpGet("get_all_kurs")]
        public async Task<ActionResult<List<GetKursDTO>>> GetAll()
        {
            return Ok(await _kursService.GetAllAsync());
        }



        [HttpGet("get_kurs")]
        public async Task<ActionResult<GetStatusStudentDTO>> GetOneKurs(int id)
        {
            return Ok(await _kursService.GetKursAsync(id));
        }

        [HttpPost("add_kurs")]
        public async Task<ActionResult<int>> AddStudent([FromBody] AddKursDTO kurs)
        {
            return Ok(await _kursService.AddKurs(kurs));
        }

        [HttpPut("edit_kurs")]
        public async Task<ActionResult<int>> EditStatusOfStudent([FromBody] EditKursDTO kurs, int id)
        {
            return Ok(await _kursService.EditKurs(kurs, id));
        }

        [HttpDelete("delete_kurs")]
        public async Task<ActionResult<int>> DeleteStatusOfStudetn(int id)
        {
            return Ok(await _kursService.DeleteKurs(id));
        }
    }
}
