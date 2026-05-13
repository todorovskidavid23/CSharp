//Console.WriteLine("Hello, World!");
//Статички класи(static classes) се класи што не можат да се инстанцираат
//(не може да се направи објект од нив).
//Тие служат за чување на методи и податоци што се заеднички и не зависат од конкретен објект.

//Дали може нестатички (non-static) член во статичка класа?

//❌ Не може.

//Во static class сите членови мора да бидат static.

//Дали може статички (static) член во нестатичка класа?

//✅ Да, може.

//Нестатичка класа може да има и static и non-static членови.

//za sto se koristat Genericite
//vo abstract imame override nemame implementacija
//vo abs imame 

//Generici zaednico za site
//Static Non-static
//Припаѓа на класата	        Припаѓа на објект
//Една заедничка копија	        Секој објект има своја копија
//Се користи преку име на класа	Се користи преку објект
//Не бара креирање објект	    Бара object instance

//Stricly type e C# jazikot

//imame logika sto imaat povekje tipovi
//Classa e List<> 
//koristime klasa da kreirame od bilo koj tip
//List<T> poseven entitet da imame number list, 
//posebni tipovi
//Collection e zaenicka za site tipovi
//posevno da site tipovi
//Generics 
//Ova sto go koristime e Genericka Class
using Generics.Domain.Data;
using Generics.Domain.Models;
using Generics.Helpers;

List<int> numbers = new List<int>() { 1,2,3,4,5,6,7};
//List<string> strings = new List<string>();
List<string> strings = ["str1", "str2","str3"];
List<bool> bools = new List<bool>() { true,false,true};
//fleksibilni za da rabotat 
//RANEC PRIMER
//List<T> daka si se kreiraat
//SKRATENO OD T
//<Tipovi>

//Genericki klasa,metod,inteface


// od non generic
NonGenericListHelper nonGenericListHelper = new NonGenericListHelper();
nonGenericListHelper.PrintStrings(strings);
nonGenericListHelper.PrintInfoForStrings(strings);

nonGenericListHelper.PrintInts(numbers);
nonGenericListHelper.PrintInfoForInts(numbers);

nonGenericListHelper.PrintBooleans(bools);
nonGenericListHelper.PrintInfoForBooleans(bools);

Console.WriteLine("GenericListHelper");
GenericListHelper genericListHelper = new GenericListHelper();
genericListHelper.PrintItems<string>(strings);
//genericListHelper.PrintItemsInfo<string>(strings);
//Deka e static mora da BIDE POVIKANO OD CLASATA
GenericListHelper.PrintItemsInfo<string>(strings);

genericListHelper.PrintItems<int>(numbers);
GenericListHelper.PrintItemsInfo<int>(numbers);

genericListHelper.PrintItems<bool>(bools);
GenericListHelper.PrintItemsInfo(bools);







#region Generic Classes

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n========== Generic Classes ==========\n");
Console.ResetColor();

GenericDB<Order> OrdersDb = new GenericDB<Order>();//T kje bide Order
GenericDB<Product> ProductsDb = new GenericDB<Product>();//T kje bide Product

//Inserting Data
OrdersDb.Insert(new Order {Id=1,Address="Bob St,",Reciever="Bob"});
OrdersDb.Insert(new Order {Id=2,Address="John St,",Reciever="John"});
OrdersDb.Insert(new Order {Id=3,Address="Jane St,",Reciever="Jane"});

ProductsDb.Insert(new Product { Id = 1, Title = "Mouse", Description = "Wireless mouse" });
ProductsDb.Insert(new Product { Id = 2, Title = "USB", Description = "64MB" });
//ProductsDb.Insert(new Product { Id = 3, Title = "Mouse", Description = "Wireless mouse" });


OrdersDb.PrintAll();
ProductsDb.PrintAll();

//GenericDB<string> StringDb = new GenericDB<string>();//sega ne moze deka NASLEDUVA OD BASE ENTITY
//GenericDB<Developer> DeveloperDb = new GenericDB<Developer>();


#endregion