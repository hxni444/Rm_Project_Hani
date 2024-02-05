using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nexu_SMS.Entity;
using Nexu_SMS.Repository;
namespace Nexu_SMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class T_AttendanceController : ControllerBase
    {
        private readonly TAttandanceRepo tattendanceRepo;

        public T_AttendanceController(TAttandanceRepo tattendanceRepo)
        {
            this.tattendanceRepo = tattendanceRepo;
        }

        [HttpPost("Add")]
        public IActionResult Add(TAttendance attendance)
        {
            tattendanceRepo.AddAttendance(attendance);
            return Ok(attendance);
        }
    }
}
