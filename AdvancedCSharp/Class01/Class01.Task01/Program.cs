Console.WriteLine("Hello, World!");

//
//solid principi
//gradenje aplikacija
//domasni
//
//oop objekto orientiran jazik
//Integrated Development Environment (IDE)
//da se startne toa se e framework
//da se pocne biznik logika 
//framework LTS 
//i drugi jazici si kucame fCharp itn.
//
//Console Application
//izvrsuvanje vo komandna linija na nasata mashina,
//web class library 
//class library biblioteka od classes srodna funckionalnost gi grupirame vo papka
//samo se cuvaat classes 
//separations of conserns, reiskoristuvanje
//Class shablon za gradenje objekt za gradenje Class
//Istanca od class Objekt
//
//Enkapsulacija
//sto smestuvame za sto e struktura od nea koristime
//pretstava od realens svet nekoj entitet, invoice, bilo sto da e bitno e da imaat zaednicki vojstva
//properties i metodite se tie
//Class pomagaat da go pretavime toa 
//Constructo
//STRUCLY TYPE
//Access Modifiers
//odreduvame kade moze da bide dostapen
//internal vo ecen proekt
//private samo vo klasata
//public e sekade dostapno
//rabota so stringovi LINQ
//najcesto se LINQ
//da se  vrti string da se napravi operacija stringovi i nizi
//Enum prestavuvame na konstanti ENUMS enumeracija 
//Collection
//LINQ language integraten Query
//Where Filter kje si se vratat vo novata lista
//Select Map Transformira posetoceka luista 
//
//ErrorHandling
//static vo classes znaci deka propery ili metoda e samo za class samo na clasata samo a ne 
//static class od nea ne moze da se napravi instanca
//preku klasata da se pritapi
//
//na metodata treba static da se stavi VI PROGRAM.CS
//

// 

//1.Create a console applicaion that detect provided names in a provided text


List<string> names = new List<string>();

while (true)
{
    Console.WriteLine("Enter name: 'x' to end");
    string input = Console.ReadLine();
    if (input.ToLower() == "x")
    {
        break;
    }
    
    names.Add(input);
}
Console.WriteLine("Enter text: ");
string text = Console.ReadLine();




char[] separators = new char[] {' '};
string[] words = text.Split(separators);//niza od povekje stringovi spored karakterot sto sme go vnele
Console.WriteLine("\n");
Console.WriteLine("Results:");

foreach (string name in names)
{
    int count = 0;

    foreach (string word in words)
    {
        if (word.ToLower()== name.ToLower())
        {
            count++;
        }
        if (name.Equals(word, StringComparison.OrdinalIgnoreCase))
        {
            count++;
        }//pooptimiziram
    }

    Console.WriteLine($"{name} : {count}");
}




//1.Professor

//1) The application should ask for names to be eneter until the user enters x



//najvazniot del
//
//3) The application should show how many times that name was included in the text ignoring upper/lower case







//2.Create a console application that checks if a day is a working day

Console.WriteLine("Enter a date: ");

