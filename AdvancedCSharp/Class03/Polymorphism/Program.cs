//Console.WriteLine("Hello, World!");
//една метода во повеќе облици
//два вида  run time
//overloading
//overriding

//runtime overriding
//compile time overloading //isto ime razlicni parametri


//Runtime polymorphism OVERRIDING
#region RunTime Polymophism

using Polymorphism.Models;
using Polymorphism.Services;

Pet randomPet = new Pet()
{
    Name = "Mali"
};
randomPet.Eat();


Cat zuza = new Cat
{
    Name = "Zuza",
    IsLazy = true
};
zuza.Eat();



//Dog

Dog aks = new Dog
{
    Name = "Aks",
};
aks.Eat();

Dog test = new Dog();//string DEFUALT E NULL

string a = "vaka";
string b = a;
b = "TEST";
Console.WriteLine(a);//vaka
Console.WriteLine(b);//TEST

#endregion


#region Compile Time Method Overloading

PetService petService = new PetService();
petService.PrintPetInfo();
petService.PrintPetInfo(aks);
petService.PrintPetInfo(zuza);

petService.PrintPetInfo("Owner", aks);

petService.PrintPetInfo(aks,"Owner1");//redosled e mnogu biten OVERLOAD





#endregion