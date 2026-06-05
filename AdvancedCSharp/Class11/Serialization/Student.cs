using System;
using System.Collections.Generic;
using System.Text;

namespace Serialization
{
    public class Student
    {

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public bool IsPartTime { get; set; }
        
        public Student(string? firstName, string? lastName, int age, bool isPartTime)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            IsPartTime = isPartTime;
        }

    }
}
