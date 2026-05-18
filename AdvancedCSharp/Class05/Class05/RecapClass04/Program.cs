//https://regex101.com/
//https://excalidraw.com/
//development lifecycle


//Generics <T> 
//class methods interface
//Extension metodi
//bez da se menuva osnovnata implementacija na tip class da gi extendneme
//so novi funckionalnosti
//ne go pipame postoeckiot metod
//mozeme da si napravim enasi sto kje gi zakacime na niv 
//KAKO CONSCETPT gi nadopolnuva postoeckite funkiona;mosti so nasi novi metodi
//mora da e static class sledi => static metodi 
//bez this ListHelper.ListItems klasicen primer za helper
//kje ima greska ListHelper>PrintItems<int>(integers)
//ako sakame postockite funckionalnosti kako tip gi nadopolnime togas kreirame exrtension metodi
//dodavame this (this List<T> items)
//i mozeme integets.PrintItems() ni e dostpano kako extension
//za ova da se povika kje imame error ako nemame this vo metodot

using RecapClass04;
//using RecapClass04.Piggybacking; OVA SE BRISE I SE STAVA SAMO
//using ExtenstionMethods

//StringExtensions se = new StringExtensions();
string bobLong = "Bob Bobsky";
string bobShoren = bobLong.Truncate(3);
Console.WriteLine(bobShoren);
Console.WriteLine(StringExtensions.Truncate(bobLong, 3));
StringExtensions.Truncate(bobLong, 3);

Console.WriteLine(bobLong.Quote());

//Product product = new Product
//
//{
// Id=1;
// Description="desc";
// Title="Product Title"
//}

//ni treba Using

//product.PrintInfo();

//NA RAM SE CUVA

//HEAP
//Reference types
//STRING
//za referentnite tipovi se cuva vo stack i pokazuva kon heap
//

//STACK
//sto se cuva drugo vo stackot e Person bob= referencata varijablata do referentnite tipovi
//samo bob//
//bob si pokazuva kon Heap {id=1,name="B"};
//LIFO LastInFirstOut
//Value types
//Vo stack se cuva varijablata
//int num1 adresata varijablata i vrednosta na value types int num1=10 i num1 i 10 se cuvaat na stack
//Pass by value
//int num2 = num1;
//adresata ne ja davame sega ja imame vrednosta isto kako da smenapisale num2=10;
//ako se smeni num2=100;
//num1=10;




//STACK
//VALUE T
//Int num1=10;

//REFERENCE T
//Person bob samo bob a pokazuva kon Heap kade stp si ima podatovi;
//List<>, Object, class , string;
//vrednostite na referentnite tipovi
//ne nmize da value types da bide null