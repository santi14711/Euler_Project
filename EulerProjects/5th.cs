using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProjects
{
    class Class2
    {
        void prin4()
        {
            /*2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
            What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?*/


            int i = 20; //variable que guardara el valor

            while (i % 2 != 0 || i % 3 != 0 || i % 4 != 0 || i % 5 != 0 ||
                     i % 6 != 0 || i % 7 != 0 || i % 8 != 0 || i % 9 != 0 ||
                     i % 10 != 0 || i % 11 != 0 || i % 12 != 0 || i % 13 != 0 ||
                     i % 14 != 0 || i % 15 != 0 || i % 16 != 0 || i % 17 != 0 ||
                     i % 18 != 0 || i % 19 != 0 || i % 20 != 0) //verificamos que mientras no sea divisible siga en el ciclo, del contrario sale y conseguimos el valor
            {
                i += 20; //avanzamos de 20 en 20 porque son los multiplos
            }
            Console.WriteLine(i);
            Console.ReadLine();

        }
    }
}
