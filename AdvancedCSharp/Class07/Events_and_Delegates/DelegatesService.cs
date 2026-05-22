using System.Security.AccessControl;

namespace Events_and_Delegates
{
    public class DelegatesService
    {

        //kje bides delegate int deka kje vrakja int imeto na delegatot
        private delegate double CalculationDelegate(int num1, int num2);
        //izgradivme nah tip na metoda tipot na metoda sto se upotrebuva
        private delegate void SayDelegate(string text);
        //dvete se void i imaat parametar text
        private void SayHello(string text)
        {
            Console.WriteLine(text);
        }

        //Callback funkcii CallBack Functions
        private void SayWhatever(string whatever, SayDelegate sayMethod) 
        {
            //ist koncept kako callback 
            //prv argument e string a vtoriot e metoda
            sayMethod(whatever);
        }



        private double Calculate(int num1, int num2, CalculationDelegate operation)
        {
            return operation(num1, num2);
        }
        //private double Calculate(int num1, int num2, Func<int,int,double> operation)
        //{
        //    return operation(num1, num2);
        //}

        private double Product(int num1,int num2)
        {
            return num1 * num2;
        }



        public void Run() 
        {
            Console.WriteLine("Hello, World");

            Func<int, int, int> subtractFunc = (num1, num2) => num1 - num2;
            Console.WriteLine(subtractFunc(10,20));

            Action<string, ConsoleColor> printInColor = (text, color) =>
            {
                Console.ForegroundColor = color;
                Console.WriteLine(text);
                Console.ResetColor();
            };

            printInColor($"This is green", ConsoleColor.Green);
            ///Func i Action se Delegate;

            CalculationDelegate subtract = (num1, num2) => num1 - num2;
            Console.WriteLine(subtract(1,3));

            SayDelegate sayHello = new SayDelegate(word => Console.WriteLine(word));
            sayHello("Hello");

            SayDelegate sayHelloAgain = new SayDelegate(SayHello);
            sayHelloAgain("Hello Dav");


            //Callback functions
            SayWhatever("Whatever!", sayHello);
            SayWhatever("Whatever!", SayHello);
            SayWhatever("Whatever!", text=>Console.WriteLine(text));
            SayWhatever("Whatever!", text=>printInColor(text,ConsoleColor.Red));
            //return typot i parametrite
            //


            printInColor("\n========= Calculator Example ==========", ConsoleColor.Magenta);

            //metod ocekuva mora da bide 
            //kakov metod mora da bide od Tip calculation delegate
            //kako placeholder samo ni trebaat num1, num2 ovde ni treba samo metodata
            double sumResult = Calculate(10, 20, (num1, num2) => num1 + num2);
            printInColor("The sum result is " + sumResult, ConsoleColor.Yellow);

            //samo subtract vise si e definirano
            double substractResult = Calculate(10, 20, subtract);
            printInColor("The substract result is " + substractResult, ConsoleColor.Cyan);

            double productResult = Calculate(10, 20, Product);
            printInColor("The product result is " + productResult, ConsoleColor.DarkRed);


        }
    }
}
