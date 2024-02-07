using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nexu_SMS.Entity;
using Nexu_SMS.Repository;


namespace Nexu_SMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentRepo studentRepo;

        public  StudentController(StudentRepo studentRepo)
        {
            this.studentRepo = studentRepo;
        }

        [HttpGet("Get_all_Student")]
        [Authorize(Roles = "Admin,Teacher")]

        public IActionResult Get()
        {
            return Ok(studentRepo.GetAll());
        }

        [HttpGet("GetStudentById/{id}")]
        [Authorize(Roles = "Admin,Teacher")]

        public IActionResult GetStudentById(string id)
        {
            return Ok(studentRepo.Get(id));
        }

        [HttpPost("AddStudent")]
        [Authorize(Roles = "Admin")]
        public IActionResult AddStudent(Student student)
        {
            studentRepo.Add(student);
            return Ok("Student Added");
        }

        [HttpDelete("DeleteStudent/{id}")]
        public IActionResult DeleteStudent(string id) 
        {
            studentRepo.Delete(id);
            return Ok("Student Deleted");
        }
        [HttpPut("Edit_Student")]
        public IActionResult EditStudent(Student student)
        {
            studentRepo.Update(student);
            return Ok(student);
        }

        [HttpPost("RegisterStudent")]
        [Authorize(Roles = "Admin,Teacher,Student")]
        public IActionResult RegisterStudent(Student student)
        {
            studentRepo.AddStudentVal(student);
            return /*Ok(student);*/ StatusCode(200);
        }

        [HttpGet("GetStudentByClass/{cls}")]
        [Authorize(Roles = "Admin,Teacher")]

        public IActionResult GetStdByClass(int cls)
        {
            return Ok(studentRepo.GetStdByClass(cls));
        }

        [HttpGet("GetStudentBySection/{sec}")]
        [Authorize(Roles = "Admin,Teacher")]

        public IActionResult GetStdBySec(string sec)
        {
            return Ok(studentRepo.GetStdBySection(sec));
        }

        [HttpGet("GetStudentByClass,Section/{sec},{cls}")]
        [Authorize(Roles = "Admin,Teacher")]

        public IActionResult GetStdByClassnSec(string sec,int cls)
        {
            return Ok(studentRepo.GetStdBySectionNclass(sec,cls));
        }
    }
}
