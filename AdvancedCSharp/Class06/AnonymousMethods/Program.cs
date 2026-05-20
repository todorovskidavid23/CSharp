


using AnonymousMethods.Models;

List<string> names = new List<string> { "Alice", "Bob", "Charlie", "John", "Anna" };
List<string> empty = [];

//alias na sekoj element od nizata;

string johnname = names.Find(name => name == "John");
Console.WriteLine(johnname);

//ova e nanonimna funkcioja Lambda expression
//ova name e od names listata sekoj element kje se pomine Alice, Bob, Charlie, itn se dur ne go najde John 

//foreach(var name in names)
//{
//    if (name == "John")
//    {
//        return true;
//    }
//}

string? john2Name = names.Find(name =>
{
    if (name == "Jogn")
    {
        return true;
    }
    return false;
})!; //! nema da bide null

//Vo JavaScript 
//const sum=(num1,num2)=>num1+num2;
//sum(10,20); 

//var sum = (num1, num2) => num1 + num2;
//tip strukura sto go definira tipot na <> ovaa metoda e od tip prima dva parametri 

/////// DELEGATI //////// pokomplesna materija imame tip za samite metodi TIP NA METODA

//Func with 2 parameters

//parameter 1=>int
//parameter 2=>int
//parameter 1=>int
//OVERLOAD return type mora da se stavi!!! MNOGU VAZNO
Func<int, int, int> sum = (num1, num2) => num2 + num2;
Console.WriteLine($"Sum : {sum(10,20)}");
//stricly type langage tip na metodi toj tip gi gledame od paramaterite i od return 
//delegat vid na delegat e Func i istio go koristime za da definirmae tip na metoda GENERICKI
//si prima povekje T elementi
//Func metodata kje si prima 1parametar int, 2parametar2 i rezultatot===3parametar e int
//mnogu biten e redosledot posleden 

//BEZ PARAMETRI
Func<bool> isNamesEmpty = () => names.Count == 0;
Console.WriteLine($"Is list empty? {isNamesEmpty()}");


//Example with 1 parametar return typeot e bool NAUCI RETURN TYPE >
Func<List<string>, bool> isListEmpty = list => list.Count == 0;
Console.WriteLine($"Is list names : {isListEmpty(names)}");
Console.WriteLine($"Is list empty : {isListEmpty(empty)}");



Func<int, int, bool> isLarger = (num1, num2) =>
{
    if (num1 > num2)
    {
        return true;
    }
    return false;
};
Console.WriteLine($"Is num1 greather than num2 : {isLarger(10,20)}");

//4 parametri

Func<int, string, double, bool, string> getUserInfo = (id, name, salary, isActive) =>
{

    return @$"ID {id}, Name: {name}, Salary: {salary}, Is Active: {(isActive ? "Yes" : "No")}";
};

string userInfo = getUserInfo(1, "David", 100000, true);
Console.WriteLine(userInfo);

/////////////////////////
///

//Example of a Func that uses class as type
Func<Person, string> getPersonName = person =>
{
    return person.Name;
};

Person bob = new Person()
{
    Name = "Bob",
};
Console.WriteLine(getPersonName(bob));

//Person person = new Person()
//{
//    Id = 1,
//    Name = "Martin",
//    Salary = 50000,
//    IsActive = true
//};

//string result = getInfo(person);

//Console.WriteLine(result);

//Func<void> printHello=()=>Console.WriteLine("Hello");
//ACTION ako sakame da ACTION vrakja niso osven VOID

Action printHello = () => Console.WriteLine("Hello");
printHello();
printHello();

//Func<> ne moze da vrati VOID
//za taa cel e sozdaden Action

//tuka nemame return type tuku samo parametrite
//PARAMETERS koga koristime action
Action<string> printRed = word =>
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(word);
    Console.ResetColor();
    //return word; void ne moze da ima return na vrednost;
};
printRed("Something went wrong");


//////////
///
//od samiot Enum e ova ConsoleColor
Action<string, ConsoleColor> printInColor = (text, color) =>
{
    Console.ForegroundColor = color;
    Console.WriteLine(text);
    Console.ResetColor();
};

printInColor("This is blue text", ConsoleColor.Blue);
printInColor("This is green text", ConsoleColor.Green);

//metoda kako parmaetar da nis tigne
//treba da isoratime callback i funcion kako argument istoto i ode
//high order function da si krerame
//

//DELEGATI I EVENTI SE MNOGU VAZNI

#region Pericate
//return typeot e bool NAUCI RETURN TYPE
//vid na delegat prima samo eden parametar d bilo koj tip 
// vrakja boolean
Predicate<Person> isActive = person => person.IsActive;
Person bob2 = new();
Console.WriteLine(isActive(bob2));//default e false



#endregion



#region MyRegion

#endregion

printInColor("\nFUNC & Action with hof and LINQ",ConsoleColor.DarkMagenta);
string foundBob = names.Find(n => n == "Bob");


Predicate<string> isJill = n => n == "Jill";
string foundJill = names.Find(isJill);//ova prima Predicate

Func<string,bool> isJillFunc = n => n == "Jill";
string foundJillFirst = names.FirstOrDefault(isJillFunc);//ova prima Func



//filtriranje na site names sto pocnuvaat so J
//kreirame anonimna metoda
Func<string, bool> nameStartsWithJ = n => n.StartsWith("J");
List<string> namesWithJ = names.Where(nameStartsWithJ).ToList();//po default vrakja IEnumerable od string
List<string> namesWithJ2 = names.Where(n => nameStartsWithJ(n)).ToList();
List<string> namesWithJ3 = names.Where(n => n.StartsWith("J")).ToList();
List<string> namesWithJ4 = names.Where(n =>
{
    if (n.StartsWith("J"))
    {
        return true;
    }
    return false;
}).ToList();

//namesWithJ.ForEach(n => Console.WriteLine(n));
namesWithJ.ForEach(Console.WriteLine);



