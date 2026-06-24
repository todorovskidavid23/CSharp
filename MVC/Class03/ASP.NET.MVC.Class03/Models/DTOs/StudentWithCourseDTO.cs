namespace ASP.NET.MVC.Class03.Models.DTOs
{
    public class StudentWithCourseDTO
    {
        //ime na modelot i na kraj DTO deka ovoj model ni e DTO ako e view View na kraj
        //tuka samo properties nemame nikakva biznis logika
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string NameOfActiveCourse { get; set; }
    }
}
