using System;
using System.Collections.Generic;
using System.Text;

namespace c2.net
{
    class ej02
    {
        static void Main(string[] args)
        {
            //Escribe un programa de consola que realice lo siguiente: declarar una variable N de tipo
            //int, una variable A de tipo double y una variable C de tipo char y asigna a cada una un valor.

            int n = 7;
            Double a = 9;
            char c = 'a';

            Console.WriteLine("Variable N = " + n);
            Console.WriteLine("Variable A = " + a);
            Console.WriteLine("Variable C = " + c);

            Console.WriteLine(n+a);
            Console.WriteLine(a-n);
            Console.WriteLine("Valor numérico del carácter " + c + " = " + (int)c);

            Console.ReadKey();
        }
    }
}
