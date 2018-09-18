using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProjects
{
    class _9th
    {

        //A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

        // a 2 + b 2 = c 2
        //For example, 3 2 + 4 2 = 9 + 16 = 25 = 5 2.

        //There exists exactly one Pythagorean triplet for which a +b + c = 1000.
        //Find the product abc.
        void prin9()
        {

            int ccuadrado = 0, a = 0, b = 0, c;

            for (a = 1; a < 500; a++)

                for (b = 0; b < 500; b++)
                {
                    ccuadrado = (a * a) + (b * b);
                    c = (int)Math.Sqrt(ccuadrado);

                    Console.WriteLine("a {0}, b {1}, c{2}", a, b, c);
                    if ((a + b + c) == 1000 && (a * a) + (b * b) == c * c)
                    {
                        Console.WriteLine(a * b * c);
                        Console.ReadLine();
                    }
                }
        }

    }
}
