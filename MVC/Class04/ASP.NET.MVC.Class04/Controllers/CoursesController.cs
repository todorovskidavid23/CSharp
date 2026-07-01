using ASP.NET.MVC.Class04.DataBase;
using ASP.NET.MVC.Class04.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET.MVC.Class04.Controllers
{
    [Route("courses")]
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            var courses = InMemoryDataBase.Courses;
            var coursesList = new List<CoursesWithStudentDTO>();

            foreach(var course in courses)
            {
                var students = InMemoryDataBase.Students.Where(x => x.ActiveCourse.Id == course.Id)
                    .Select(x => new StudentDTO()
                    {
                        FullName = $"{x.FirstName} {x.FirstName}",
                        Age = DateTime.Now.Year - x.DateOfBirth.Year
                    }).ToList();

                coursesList.Add(new CoursesWithStudentDTO()
                {
                    Id = course.Id,
                    Name = course.Name,
                    Students = students
                });
                //koj mu se aktivni studenti na ovoj kurs SAMO PREKU ACTIVE COUSE
                
            }


            return View(coursesList);
        }
    }
}
