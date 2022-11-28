using System;

namespace L1_E4
{
    /*Ex.4 Scrieti un program care va afisa semnul unui numar citit de la tastatura
           • Daca numarul este pozitiv, va afisa “+”
           • Daca numarul este negativ, va afisa “-”
           • Daca numarul este 0, va afisa “0”
    */
    class Program
    {
        static void Main(string[] args)
        {
            int numar;

            Console.WriteLine("Introduceti un numar");
            numar = int.Parse(Console.ReadLine());

            if (numar > 0)
            {
                Console.WriteLine("+");
            }
            else if (numar < 0)
            {
                Console.WriteLine("-");
            }
            else 
            {
                Console.WriteLine("0");
            }

        }
    }
}
