using ASP.NET.MVC.Class02.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET.MVC.Class02.Controllers
{
    public class CoursesController : Controller
    {
        private List<Course> _courses = new List<Course>()
        {
            new Course { Id = 1, Name = "C# Basics", NumberOfClasses = 10 },
            new Course { Id = 2, Name = "ASP.NET Core MVC", NumberOfClasses = 15 },
            new Course { Id = 3, Name = "Entity Framework Core", NumberOfClasses = 12 }
        };

        //default HTTPGET method
        public IActionResult GetAllCourses()
        {
            return Json(_courses);
            //po defult , the method name is used as the route name, so the route will be /courses/getallcourses
            //http get for default, so the route will be /courses/getallcourses
            // za da ja pogodime mora url da bide: localhost:port/courses/getallcourses
            // convention based routing, the route will be /courses/getallcourses
            // if we want to change the route, we can use the [Route] attribute, so the route will be /courses/all
            // if we want to change the route, we can use the [HttpGet] attribute, so the route will be /courses/all
            //list of objects, so we can use the Json method to return the list of objects as JSON
            //
        }

        public IActionResult GetCourseById(int id)  //localhost:port/courses/getCoursesById/10
        {
            return Json(_courses.FirstOrDefault(x => x.Id == id));
            //query string parameter, so the route will be /courses/getCoursesById?id=10
            // ? means that the parameter is optional, so the route will be /courses/getCoursesById or /courses/getCoursesById?id=10
        }

        public JsonResult GetCourseByName(string name) //localhost:port/courses/ASP.NET%20Core%20MVC -- custom
        {
            return Json(_courses.FirstOrDefault(x => x.Name == name));
        }

        public IActionResult GetCourseByIdAndName(int id, string name) //localhost:port/courses/getCourseByIdAndName/1/C%23%20Basics
        {
            return Json(_courses.FirstOrDefault(x => x.Id == id && x.Name == name));
        }
    }
}
