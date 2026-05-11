//slusi samo za nasleduvanje na klasi
//abstract class klasa public abstract Person za da kazeme deka se naleduva od ovaa klasa
//razlikata sto e samo sto ingeritance ne gi pravivme apstraktni NE MOZE da se pravi instanca od abstract
//abstract method sekoja klasa sto alseuva override treba da ima (OVDE JA IMAME SAMO DEFICNIJATA za metodot)
//Klasite sto kje nasledat imame nova metoda sto kje ima override
//Inetrface se contract dogovoi so onie raboti sto trebada ima edna klasa
//sekoja implemetacija na interfejs mora da ima void ista kako interfecaot MORA DA IMA TAKVA MEODA
//od edna klasa se inheritance, od interface kolku sakame moze nasledivanje : Person, IDeveloper, ITester

//Programa za menanjziranje na orderi so osonvno meni

//Console.ForegroundColor=ConsoleColor.Red;
//Console.WriteLine("========== Welcome to Order Managment System ==========");
//Console.ResetColor();

using Class03.Static;
using Class03.Static.Enums;
using Class03.Static.Helpers;
using Class03.Static.Models;

//ConsoleHelper consoleHelper = new ConsoleHelper();
//SEKAGE KAJ STO KJE JA KORISTIME TREBA DA PRAVIME INSTANCA

//MOZE DA SE POVIKAAT BEZ INSTANCA STATIC

//REISKORISTUVANJE

ConsoleHelper.WriteError("Message ERROR");
Console.WriteLine(OrdersStaticDB.Users.Count);

bool isRunning = true;

while (true)
{
    Console.WriteLine("========== Welcome to Order Managment System ==========");
    Console.WriteLine("\nPlease choose an option:");
    Console.WriteLine("1) List all users");
    Console.WriteLine("2) Create order for user");
    Console.WriteLine("3) Exit");

    string choice= Console.ReadLine();

    switch (choice)
    {
        case "1":
            ConsoleHelper.WriteInColor("\nList of Users:");
            OrdersStaticDB.ListUsers();
            break;
        case "2":
            ConsoleHelper.WriteInColor("\nEnter User Id:",ConsoleColor.Yellow);
            string userId = Console.ReadLine();

            ConsoleHelper.WriteInColor("\nEnter Order Title:", ConsoleColor.Yellow);
            string title = Console.ReadLine();

            ConsoleHelper.WriteInColor("\nEnter Description:", ConsoleColor.Yellow);
            string description = Console.ReadLine();

            Order newOrder = new Order
            {
                Title = title,
                Description=description,
                Status=OrderStatus.Processing
            };
            OrdersStaticDB.InsertOrders(newOrder, Convert.ToInt32(userId));

            break;
        case "3":
            ConsoleHelper.WriteInColor("Goodbye", ConsoleColor.DarkCyan);
            isRunning = false;
            break;

        default:
            ConsoleHelper.WriteError("Invalid choice. Try again.");
            break;
    }

}
