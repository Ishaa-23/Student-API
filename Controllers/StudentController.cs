using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Student.Models;

namespace Student.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private List<Stud> studList = new List<Stud> {
        new Stud{ Id=1,Name= "Ishaa", Age=22},
        new Stud{ Id=2,Name="Rehaan", Age=16},
        new Stud{ Id=3,Name= "Sharon", Age=16},
        };
        [HttpGet]
        public async Task<ActionResult> GetStudent()
        {
            return Ok(studList);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetStudentById(int id)
        {
            Stud stu = studList.FirstOrDefault(c => c.Id == id);
            if (stu == null)
            {
                return NotFound(new { Message = "Student has not been found." });
            }

            return Ok(stu);
        }
    }
}
