using ASP.NET.MVC.Class02.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET.MVC.Class02.Controllers
{
    //ATRIBUTE ROUTING
    [Route("students")]//localhost:port/students
    public class StudentController : Controller
    {
        private List<Student> _students = new List<Student>
        {
            new Student()
            {
                Id = 1,
                FirstName = "Bob",
                LastName = "Bobski",
                DateOfBirth = DateTime.Now.AddYears(-27)
            },
            new Student()
            {
                Id = 2,
                FirstName = "Jill",
                LastName = "Jilski",
                DateOfBirth = DateTime.Now.AddYears(-37)
            },
            new Student()
            {
                Id = 3,
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = DateTime.Now.AddYears(-45)
            },
            new Student()
            {
                Id = 4,
                FirstName = "Jane",
                LastName = "Doe",
                DateOfBirth = DateTime.Now.AddYears(-17)
            },
        };
        [Route("all")] // students/all //this is the same as the previous one, but this is more specific, because it specifies the HTTP method
        [HttpGet("all")] // students/all //this is the same as the previous one, but this is more specific, because it specifies the HTTP method
        public IActionResult GetAllStudents()//List<Student>
        {
            return Json(_students);
        }

        // students/getById/1 or students/1 -- custome route
        [HttpGet("getById/{id:int}")]
        public IActionResult GetById(int id)
        {
            return Json(_students.FirstOrDefault(x => x.Id == id));
        }

        [Route("id/{id}/name/{name}")] //students/id/1/name/Bob

        public Student GetStudentByIdAndName(int id, string name) //za da mozeme nesto direkno da vratime
        {
            //da ni vratat modeli logika za filter
            //razlikata imame moznost povekje rabori da se vratat vo IActionResult 
            //a ovde mora da se vrati Student
            return _students.FirstOrDefault(x => x.Id == id && x.FirstName == name);

        }

        //defult parametar koga se prakja query parametar da si imame default
        //da ne bide nikogas null po id koga bara 
        //defult da ni bide 1

        [Route("byId/{id=1}")] //student/byId/1 kje ni bide default koa nisto ne mu stavime za parametar
        public Student GetStudentByIdWithDefaultValue(int id)
        {
            return _students.FirstOrDefault(x => x.Id == id);
        }

    }
}
