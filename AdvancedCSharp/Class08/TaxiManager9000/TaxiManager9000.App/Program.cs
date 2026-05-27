//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

////biznis logika e service
////data access dataAcces
////Entity Domain Layer Domain Modeli glavnite modeli 
//Car car1 = new Car
//{
//    Name = "car1",
//    Description = "Desctiption1"
//};
//List<Car> cars = [car1];

//Car car1Db = cars.FirstOrDefault();

//Car car2 = new Car
//{
//    Name = "car2",
//    Description = "Desctiption2"
//};

//car1Db = car2;
////car 1 kje pokazuva kon objektot 2 
//Console.WriteLine(car1Db.Name);
//Console.WriteLine(cars[0].Name);
//Console.WriteLine(car2.Name);


//class Car
//{
//    public string Name { get; set; }
//    public string Description { get; set; }
//}




using TaxiManager9000.App;

Console.Title = "Taxi Manager 9000";

TaxiManagerUI taxiManagerUI = new TaxiManagerUI();

taxiManagerUI.InitApp();