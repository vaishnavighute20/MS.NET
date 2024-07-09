using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentMgmtSystem.Services;
using StudentMgmtSystem.Entities;
namespace StudentMgmtSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;

        }

        [HttpGet]
        public IActionResult Display()
        {
          return Ok(_studentService.GetStudents()); 
            
        }
        //public IActionResult Index()
        //{
        // List<Student> students = _studentService.GetStudents();
        //return Ok(students);
        // }

       

    }
}