using BLL.DTOModels;
using BLL.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace BazyDanych.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost]
        public IActionResult AddStudent([FromBody] StudentDTO studentDto)
        {
            _studentService.AddStudent(studentDto);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            var student = _studentService.GetStudent(id);
            return student != null ? Ok(student) : NotFound();
        }

        [HttpPut]
        public IActionResult UpdateStudent([FromBody] StudentDTO studentDto)
        {
            _studentService.UpdateStudent(studentDto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            _studentService.DeleteStudent(id);
            return Ok();
        }
    }
}
