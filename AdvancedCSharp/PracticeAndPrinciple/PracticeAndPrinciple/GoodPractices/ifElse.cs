using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAndPrinciple.GoodPractices
{
    internal class ifElse
    {
        public void CheckTwoNumbers(int numberOne, int numberTwo)
        {
            if(numberOne<=100 && numberTwo <= 100)
            {
                if(numberOne % 2 == 0 && numberTwo%2 == 0)
                {
                    if(numberOne > 0 && numberTwo > 0)
                    {
                        if (numberOne == numberTwo)
                        {
                            Console.WriteLine("Numbers are equal");
                        }
                        else
                        {
                            Console.WriteLine("Numbers are NOT equal");
                        }
                    }
                }
            }

            if(numberOne > 100 && numberTwo > 100) return;
            if (numberOne % 2 == 0 && numberTwo % 2 == 0) return;
            if (numberOne != numberTwo) return;

        }

    }
}
