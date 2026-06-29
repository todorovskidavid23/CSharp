using ASP.NET.MVC.Class04.Models.Entities;

namespace ASP.NET.MVC.Class04.Models.DTO
{
    public class StudentWithCourseDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }

        //vazen del povrzuvanje so Course
        public int CourseId { get; set; }
        public string NameOfCourse { get; set; }

        
        public StudentWithCourseDTO(int id,string firstName, string lastName, DateTime dateOfBirth, int courseId, string nameOfCourse)
        {
            //mapping
            Id = id;
            FullName = $"{firstName} {lastName}";
            Age =DateTime.Now.Year - dateOfBirth.Year;
            CourseId = courseId;
            NameOfCourse = nameOfCourse;
        }

    }
}
