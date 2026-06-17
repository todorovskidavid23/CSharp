using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAndPrinciple.GoodPractices
{
    internal class Loops
    {
        public List<string> Names = new List<string> { "Alice", "Bob", "Charlie", "David", "Eve" };

        public void PrintNames()
        {
            //bad example:
            for(int counter=0; counter<Names.Count; counter++)
            {
                if (Names[counter].Length == Names.Count)
                {
                    Console.WriteLine(Names[counter]);
                }
            }

            //Good Example:
            foreach (var name in Names)
            {
                if (name.Length == Names.Count)
                {
                    Console.WriteLine(name);
                }
            }

            int listCount = Names.Count;

            foreach (var name in Names)
            {
                if (name.Length == listCount)
                {
                    Console.WriteLine(name);
                }
            }



            //variable koga pravime variabla dva pati se koristi Names.Count
            //sekogas koga imame potreba varijabla da bide inicjializirana nadvor od FOR
            //sekogas e dobro da bide nadvor od loopl
        }

        public void PrintAlice()
        {
            //bad example:
            //celo vreme kje vrti 
            foreach (string name in Names)
            {
                if(name == "Alice")
                {
                    Console.WriteLine(name);
                }
            }

            foreach (string name in Names)
            {
                if(name == "Alice")
                {
                    Console.WriteLine(name);
                    break; //Exit the loop after finding "Alice" ne kositsi tolku mnogu memorija

                }
            }
        }

    }
}
