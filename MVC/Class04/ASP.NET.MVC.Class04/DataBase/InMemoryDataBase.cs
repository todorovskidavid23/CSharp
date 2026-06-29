using ASP.NET.MVC.Class04.Models.Entities;

namespace ASP.NET.MVC.Class04.DataBase
{
    public static class InMemoryDataBase
    {
        public static List<Student> Students { get; set; }//za direktno da si se povika
        public static List<Course> Courses { get; set; }

        

        static InMemoryDataBase()
        {
            //vazno e sto prvo kje se cita vo baza kje pukne deka vo student imame relacija so 
            LoadCourses();
            LoadStudents();
        }

        private static void LoadStudents()
        {
            Students = new List<Student>()
            {
                new Student()
                {
                    Id=1,
                    FirstName="John",
                    LastName="Doe",
                    DateOfBirth=DateTime.Now.AddYears(-20),
                    ActiveCourse=Courses[3]
                },
                new Student()
                {
                    Id=2,
                    FirstName="Bob",
                    LastName="Bobsky",
                    DateOfBirth=DateTime.Now.AddYears(-40),
                    ActiveCourse=Courses[1]
                },
                new Student()
                {
                    Id=3,
                    FirstName="Jill",
                    LastName="Jillsky",
                    DateOfBirth=DateTime.Now.AddYears(-25),
                    ActiveCourse=Courses[2]
                },
                new Student()
                {
                    Id=4,
                    FirstName="Jane",
                    LastName="Doe",
                    DateOfBirth=DateTime.Now.AddYears(-29),
                    ActiveCourse=Courses[2]
                },

            };

        }
        private static void LoadCourses()
        {
            Courses = new List<Course>()
            {
                new Course()
                {
                    Id=1,
                    Name="C#",
                    NumberOfClasses=10
                },
                new Course()
                {
                    Id=2,
                    Name="JavaScript",
                    NumberOfClasses=15
                },
                new Course()
                {
                    Id=3,
                    Name="MVC",
                    NumberOfClasses=10
                },
                new Course()
                {
                    Id=4,
                    Name="SQL",
                    NumberOfClasses=5
                },
            };
        }

    }
}
