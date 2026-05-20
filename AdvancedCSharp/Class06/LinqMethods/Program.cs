// See https://aka.ms/new-console-template for more information
//https://download-directory.github.io/ za kopiranje na github folders.

using LinqMethods.Data;
using LinqMethods.Entities;
using LinqMethods.Helpers;

Console.WriteLine("Hello, World!");





Console.ReadLine();

//List e class Genericka sto implementira nekoi Interfaces
//od IList<T> imame IdenxOf, Insert, RemoveAt : ICollection<T> imame Count IsReadOnly, Add, Clear, Contains
//Iterable objects IEnumerable 
//na site kolekcii imame dictionary

// kje printa kakov bilo  tip na Collection ako koristime IEnumerable

//Language Integrated Lagnuage set na metodi da kreirame data ource,
//exteren resurs databaza itn. 
//
//Where Filter return IEnumerable
//Select Map ist broj na elementi vrakja
//WHERE SEKOGAS VRAKJA IENUMERABLE;

//So methodi so lambda expressions
//LINQ with Lambda
IEnumerable<Student> findBobsLambda = SEDC.Students
    .Where(s => s.FirstName.Equals("Bob", StringComparison.OrdinalIgnoreCase));

foreach (Student student in findBobsLambda)
{
    Console.WriteLine($"{student.FirstName} {student.LastName}");
}


//SQL like LINQ
IEnumerable<Student> findBobsSql = from s in SEDC.Students
                                   where s.FirstName == "Bob"
                                   select s;

foreach (Student student in findBobsSql)
{
    Console.WriteLine($"{student.FirstName} {student.LastName}");
}

//Select

List<string> firstNames = SEDC.Students.Select(s => s.FirstName).ToList();
firstNames.PrintSimple();

//IEnumabrable e interface sto go imame site kolekcii i e genericki za site kolekcii

//var bobs = SEDC.Students
//    .Where(s => s.FirstName.Equals("Bob", StringComparison.OrdinalIgnoreCase))
//    .Select(s => new
//    {
//        s.FirstName,
//        s.LastName
//    });

//foreach (var bob in bobs)
//{
//    Console.WriteLine($"{bob.FirstName} {bob.LastName}");
//}

//Example: Get students whic are part-time and have subjects from the programming academy

IEnumerable<Student> programmingStudentsSqlLike =
        from student in SEDC.Students
        where student.IsPartTime
        && (from subject in student.Subjects
           where subject.Type == Academy.Programming
           select subject).Count() != 0
        select student;



List<Student> programmingStudentsLambda =
    SEDC.Students
        .Where(student =>
        student.IsPartTime
        && student.Subjects.Any(subject => subject.Type == Academy.Programming))
        .ToList();


//

//🔵 Single()
//var student = SEDC.Students.Single();

//👉 Очекува точно 1 елемент

//❗ правила:
//ако има 0 елементи → фрла exception
//ако има повеќе од 1 → фрла exception
//работи само кога си 100% сигурен дека резултатот е единствен
//🟡 SingleOrDefault()
//var student = SEDC.Students.SingleOrDefault();

//👉 Очекува 0 или 1 елемент

//❗ правила:
//ако има 0 елементи → враќа null
//ако има 1 елемент → го враќа тој
//ако има повеќе од 1 → фрла exception

//////////////////////Student petko = SEDC.Students.First(s => s.FirstName == "Petko");//frla exeption deka go vrakja prviot element ako go zadovoli uslovot
//ako ne frla Exeption
Student petko1 = SEDC.Students.FirstOrDefault(s => s.FirstName == "Petko");//frla exeption deka go vrakja prviot element ako go zadovoli uslovot
//default vrednost dava null dea e default
//NEMA DA FRLI EXEPTION TUKU KJE DADE NULL


//////////Student bob = SEDC.Students.Single(s => s.FirstName == "Bob");//ocekuva eden element
//ocekuva da e toj edinsteniot ELEMENT ako ne frla exeption
Student bob1 = SEDC.Students.SingleOrDefault(s => s.FirstName == "Bob");//kje si frli exeption
//ako nema takov element kje dade null




//any e barem edno
bool hasBob = SEDC.Students.Any(s => s.FirstName == "Bob");



//All site elementi dali go zadovoluvaat uslovot
bool areAllAdults = SEDC.Students.All(s => s.Age >=18);//site treba da se nad 18 godini ako ne kje padne
Console.WriteLine(areAllAdults);

//Distinct removes all duplicates values vrakja unikatni vrednosti
//site iminja bez duplikati

List<string> distinctStudentNames = SEDC.Students
    .Select(s => s.FirstName)
    .Distinct()
    .ToList();

distinctStudentNames.PrintSimple();
