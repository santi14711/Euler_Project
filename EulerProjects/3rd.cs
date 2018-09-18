using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProjects
{
    class _3rd
    {
        /*The prime factors of 13195 are 5, 7, 13 and 29.
            What is the largest prime factor of the number 600851475143 ?*/
        public static void hola()
        {

            long num = 600851475143;
            int x = 2;

            for (int i = 0; i < num / 2; i++)
            {
                if (num % x == 0) //check if the number is divisible by 2,3,4...
                {
                    num /= x;    //If it is divisible, we divide and save on num

                    x = 2;      //reset the divisor number

                }
                else
                {
                    x++; //if it's not divisible, will increment the value for keep looking
                }
            }
            Console.WriteLine(num);



            Console.ReadLine();

        }
    }
}
