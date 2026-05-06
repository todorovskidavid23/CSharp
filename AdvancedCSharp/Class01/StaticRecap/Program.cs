
using StaticRecap;

HelloWorld();
void HelloWorld()
{
    Console.WriteLine("Hello, David!");
}
Console.ReadLine();



var mario = new Developer("Mario","Rossi",23);
Console.WriteLine(mario.GetNumberOfDevelopers());
Console.WriteLine(Developer.NumberOfDevelopers);
//mario.ResetNumberOfDeveloper();
Developer.ResetNumberOfDevelipers();
Console.WriteLine(mario.GetNumberOfDevelopers());

Console.ReadLine();