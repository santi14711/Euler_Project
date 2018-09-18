
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProjects
{
    class Class4
    {

        /* By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        What is the 10 001st prime number?*/

        void prin7()
        {
            int contador = 3, numero = 4;

            for (numero = 4; contador < Math.Sqrt(10001) + 1; numero = numero + 2)
            {
                int a = 0, i;

                for (i = 1; i < (numero + 1); i++)
                {
                    if (numero % i == 0)
                    {
                        a++;
                        Console.WriteLine(numero);
                    }
                }
                if (a == 2)
                {
                    contador++;
                    a = 0;
                    if (contador == 10001)
                    {
                        Console.WriteLine(numero + " es el " + (contador + 1) + " numero primo");
                    }
                }
            }

            Console.ReadLine();

        }
    }
}
