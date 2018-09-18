using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProjects
{
    class Class3
    {
        /*The sum of the squares of the first ten natural numbers is,
        12 + 22 + ... + 102 = 385
        The square of the sum of the first ten natural numbers is,
        (1 + 2 + ... + 10)2 = 552 = 3025
        Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
        Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.*/

       void prin6() {
        int sum = 0;
        int exp = 0;

            for (int i = 0; i <= 100 ; i++) // conseguimos la suma de las primeras 100 cifras
            {
                sum += i;
            }

    sum *= sum; //elevamos esa suma al cuadrado

            for (int i = 0; i <= 100; i++) //conseguimos la suma de cada uno de los cuadrados del 1 al 100
            {
                exp = exp + (i* i);
            }

int resultado = sum - exp; //restamos

Console.WriteLine(resultado);
            Console.ReadLine();
        }
    }
}
