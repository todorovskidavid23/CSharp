using ASP.NET.MVC.Class03.DataAccess;
using ASP.NET.MVC.Class03.Models.Domains;
using ASP.NET.MVC.Class03.Models.DTOs;

namespace ASP.NET.MVC.Class03.Services
{
    public class StudentService
    {
        //public Student GetStudentWithActiveCourse(int id)
        //{
        //    var student = InMemoryDb.Students.FirstOrDefault(x => x.Id == id);
        //    if (student == null)
        //    {
        //        return null;
        //    }
        //    

        //    return student;
        //}

        //namesto domanksi model treba da bide DTO-to treba da vrakjame od tip DTO
        public StudentWithCourseDTO GetStudentWithActiveCourse(int id)
        {
            //vo baza koga prebaruvame sekogas vrakja od modelot ,
            //domanski model vo dto toa se pravi so mapiranje
            var student = InMemoryDb.Students.FirstOrDefault(x => x.Id == id);
            if (student == null)
            {
                return null;
            }
            var studentDTO = new StudentWithCourseDTO()
            {
                //sekoe propery 
                Id=student.Id,
                FullName=$"{student.FirstName} {student.LastName}",
                Age=DateTime.Now.Year - student.DateOfBirth.Year,
                NameOfActiveCourse = student.ActiveCourse.Name,
            };
            return studentDTO;
        }

    }
}
