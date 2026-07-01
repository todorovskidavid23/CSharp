using ASP.NET.MVC.Class04.DataBase;
using ASP.NET.MVC.Class04.Models.DTO;
using ASP.NET.MVC.Class04.Models.Entities;
using ASP.NET.MVC.Class04.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET.MVC.Class04.Controllers
{
    [Route("students")]
    public class StudentController : Controller
    {
        public IActionResult GetAllStudents()
        {
            var students = InMemoryDataBase.Students.Select(x=> 
            new StudentWithCourseDTO(x.Id, x.FirstName, x.LastName, x.DateOfBirth, x.ActiveCourse.Id, x.ActiveCourse.Name)
            );
            //vaka gi pustame deka pravime CRUD operacii povikauva Domainski model, od baza gi vlece 
            // od domain vo DTO, od eden model kon drug model
            //od baza prakjame (id) za da zaneme koj course id i coues name  PROPERY FOREIGN KEY preku studentot koj aktiven course e
            return View(students);
        }
        //domain/students/1; 1kako parametar
        [HttpGet("{id:int}")]
        public IActionResult GetStudentById(int id)
        {
            var student = InMemoryDataBase.Students.FirstOrDefault(x => x.Id == id);
            //cel domainski model go prakjam , ne e dobro !!!
            if (student == null)
            {
                return View();
            }
            var studentDto = new StudentWithCourseDTO(student.Id, student.FirstName, student.LastName, student.DateOfBirth, student.ActiveCourse.Id, student.ActiveCourse.Name);
            //mapiranje od domanski vo dto model TREBA DTO DA SE ISPRATI
            //studentDTO se isprakja vo viewmodel

            return View(studentDto);
        }

        [HttpGet("create")]//GET: /students/create

        public IActionResult CreateStudent()
        {
            //input forma ne mi treba nisto
            return View();
        }

        //kopce create HTTP post mora da ide do ista routa kako stoe http get mora da bide ista routa
        [HttpPost("create")]
        public IActionResult CreateStudent(CreateStudentVM model)
        {
            var entity = new Student
            {
                //mapiranje od ovoj view da gi napravam vo domanski model da se zacuva vo baza
                FirstName = model.FirstName,
                LastName = model.LastName,
                DateOfBirth = model.DateOfBirth,
                Id = InMemoryDataBase.Students.Count + 1,
                ActiveCourse = InMemoryDataBase.Courses[1]
            };
            //listava .Add
            InMemoryDataBase.Students.Add(entity);//ako go pustime modelot kje pukne
            //da ne vrakjame view ovde vrakjame Redirect
            return RedirectToAction("GetAllStudents");
        }

    }
}
