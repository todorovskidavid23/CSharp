using ASP.NET.MVC.Class03.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET.MVC.Class03.Controllers
{
    [Route("students")]
    public class StudentController : Controller
    {
        //prvo nesto koga gradime controller za da MORAME PREKU SERVICES
        //instance od toj service

        private StudentService _studentService;
        public StudentController()
        {
            _studentService = new StudentService();
        }

        //model imame baza, imame logika,imame controller, 
        //korisnikot treba nesto da napravi mora da se napravi akcija HttpGet 
        //KAKOV REQUEST NI TREBA

        [HttpGet("getById/{id:int}")]
        public IActionResult GetStudentById(int id)
        {
            var student = _studentService.GetStudentWithActiveCourse(id);
            if (student == null)
            {
                return Content("Student not found!!!");
            }
            return Json(student);
        }

    }
}
