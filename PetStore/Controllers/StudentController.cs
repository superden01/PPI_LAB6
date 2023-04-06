using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        [Route("getStudents")]
        public async Task<IActionResult> GetStudents()
        {
            var students = new List<Student>()
            {
                new Student()
                {
                    Id = 1,
                    Name = "Denis",
                    Age = 20,
                    City  ="Nikolaev"
                }
            };
            return Ok(students); 
        }
    }
}
