using System;
using System.Collections.Generic;
using System.Text;

namespace c2.net
{
    class ej5
    {
        static void Main(string[] args)
        {
            //5 - Programa de consola que declare cuatro variables enteras A, B, C
            // y D y asígnale un valor a cada una.A continuación realiza las
            // instrucciones necesarias para que:

            int a = 3, b = 5, c = 4, d = 7;

            b = c;
            c = a;
            a = d;
            d = b;

            Console.WriteLine("B toma el valor de C -> B = " + b);
            Console.WriteLine("C toma el valor de A -> C = " + c);
            Console.WriteLine("A toma el valor de D -> A = " + a);
            Console.WriteLine("D toma el valor de B -> D = " + d);


        }
    }
}
