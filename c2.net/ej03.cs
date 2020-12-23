using System;
using System.Collections.Generic;
using System.Text;

namespace c2.net
{
    class ej03
    {
        static void Main(string[] args)
        {
            int X = 20, Y = 5;
            double M = 6.1, N = 3.2;
            Console.WriteLine("Variable X = " + X);
            Console.WriteLine("Variable Y = " + Y);
            Console.WriteLine("Variable M = " + M);
            Console.WriteLine("Variable N = " + N);
            Console.WriteLine(X + " + " + Y + " = " + (X + Y));
            Console.WriteLine(X + " - " + Y + " = " + (X - Y));
            Console.WriteLine(X + " * " + Y + " = " + X * Y);
            Console.WriteLine(X + " / " + Y + " = " + X / Y);
            Console.WriteLine(X + " % " + Y + " = " + X % Y);
            Console.WriteLine(N + " + " + M + " = " + (N + M));
            Console.WriteLine(N + " - " + M + " = " + (N - M));
            Console.WriteLine(N + " * " + M + " = " + N * M);
            Console.WriteLine(N + " / " + M + " = " + N / M);
            Console.WriteLine(N + " % " + M + " = " + N % M);
            Console.WriteLine(X + " + " + N + " = " + (X + N));
            Console.WriteLine(Y + " / " + M + " = " + Y / M);
            Console.WriteLine(Y + " % " + M + " = " + Y % M);
            Console.WriteLine("Variable X = " + X + " el doble es " + 2 * X);
            Console.WriteLine("Variable Y = " + Y + " el doble es " + 2 * Y);
            Console.WriteLine("Variable M = " + M + " el doble es " + 2 * M);
            Console.WriteLine("Variable N = " + N + " el doble es " + 2 * N);
            Console.WriteLine(X + " + " + Y + " + " + N + " + " + M + " = " + (X + Y + M + N));
            Console.WriteLine(X + " * " + Y + " * " + N + " * " + M + " = " + (X * Y * M * N));
        }
    }
}
