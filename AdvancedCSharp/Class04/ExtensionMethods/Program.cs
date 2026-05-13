using ExtensionMethods.Helpers;

List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
//List<string> strings = new List<string>();
List<string> strings = ["str1", "str2", "str3"];

ListHelper.PrintItems<int>(numbers);
ListHelper.PrintItems<string>(strings);
//problemot sto imame povtoruvanje

numbers.PrintItems();
//OVDE NE TREBA PARAMETAR;
//Ova raboti zaradi THIS
//dodadi FUNKCIONALONT PrintItems();