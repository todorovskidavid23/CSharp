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

//Person john=bob vo stack dodavame samo adresata kon istat memoriska alokacija


using ValueReferenceTypes;

int num1 = 10;
int num2 = num1;
int? num4 = null;//ne e nullable type num4  ? go pravi nullable
Console.WriteLine(num4);
num2 = 1000;
Console.WriteLine(num1);
Console.WriteLine(num2);

//Person bob = new Person("Bob", 30);
//Person bob2 = bob;

//za clasa e null za site referentni tipovi e default vrednost e null;

//na stringovite ne moze da se smeni vrednosta deka se immutable
string str1 = "String1";
string str2 = str1;
str2 = "String2";
Console.WriteLine(str1);
Console.WriteLine(str2);
//samo stringovite se porazlicni iako se referenctni tipovi.
