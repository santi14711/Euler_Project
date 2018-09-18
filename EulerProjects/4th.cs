using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProjects
{
    class Class1
    {
        /*A palindromic number reads the same both ways. 
             * The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
            Find the largest palindrome made from the product of two 3-digit numbers.*/

        void prin3()
        {
            int max = 0; //variable que guarda el maximo 
            int b = 0; //variable de primer numero
            int a = 0; //variable de segundo numero
            int amax = 0; //variable que guarda el maximo multiplo a
            int bmax = 0; //variable que guarda el maximo multiplo b

            for (a = 100; a < 1000; a++) //recorremos el primer numero 
            {
                for (b = 100; b < 1000; b++) //y por cada cambio en el primero cambiamos el segundo
                {

                    if (palindrome(a, b) == true) //si esa multiplicacion es palindroma la guardamos
                    {

                        if ((a * b) > max) //pero verificamos que sea el valor maximo que hayamos conseguido 
                        {
                            max = a * b;
                            amax = a; //guardamos valores de los multiplos
                            bmax = b;

                        }

                    }
                    Console.WriteLine("------" + max + "-----" + amax + "-------" + bmax);
                    Console.ReadLine();
                }
            }

        }

    

    public static bool palindrome(int x, int y) //funcion que determina si son palindromos 
    {
        int z = x * y; //enviamos 2 numeros y conseguimos su resultado 

        string pal = Convert.ToString(z); //convertimos el resultado a string

        char[] palinv = pal.ToCharArray(); //pasamos el string a un array
        Array.Reverse(palinv); //invertimos el array 
        string palinvertido = new string(palinv); //lo volvemos a un string distinto 
        if (pal.Equals(palinvertido)) //verificamos si ambos son iguales y retornamos un valor 
        {
            return true;
        }
        else
        {
            return false;
        }
    }
       
}}