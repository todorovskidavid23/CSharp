//Boxing i Unboxing
//value type vo reference i obratno

//value type i reference type
//string e referenten tip no bez value ne se dodava referneca

//1.Value Type

//Value type директно ја чува вредноста.

//Кога копираш variable → се копира самата вредност.

//Примери:
//int
//double
//char
//bool
//struct
//enum

//2.Reference Type

//Reference type НЕ ја чува директно вредноста.

//Туку чува адреса (reference) до објект во memory.

//Примери:
//class
//string
//array
//object
//delegate

int number1 = 9000;
object objNumber1 = number1;
//OVA E BOXING value type vo Referent type
//na kraj na den SE E OBJEKT 
object objNumber2 = 1000;
int number2 = (int)objNumber2; //castiranje casting
//unboxing
