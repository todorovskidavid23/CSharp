namespace ASP.NET.MVC.Class04.Models.DTO
{
    public class CoursesWithStudentDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<StudentDTO> Students { get; set; }
    }
}
