using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProjects
{
    class _10th
    {
        /*The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

        Find the sum of all the primes below two million.*/



        int sumPrimes = 2;
        void crive(int n)
        {


            //bool[] prime = new bool[n + 1];
            //Parallel.For(0, n + 1, index => prime[index] = true);
            //for (int p = 0; p * p <= n; p++)
            //{
            //    if (prime[p])
            //    {
            //        for (int i = p * 2; i <= n; i += p)
            //            prime[i] = false;
            //    }
            //}

            //int sum = 0;
            //for (int p = 2; p <= n; p++)
            //{
            //    if (prime[p])
            //    {

            //        sum += p;
            //        Console.WriteLine(sum);
            //    }
            //}

            //Console.ReadLine();



            int divisor = 2;
            int sum = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int ni = 0; ni <Math.Sqrt(ni) ; ni++)
                {


                    if (ni % divisor == 0)
                    {
                        sum += ni;

                    }
                    divisor++;


                }

                divisor = 2;
            }


            Console.Write(sum);
            Console.ReadLine();



        }
}
}
