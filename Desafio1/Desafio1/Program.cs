using System;
using System.Collections.Generic;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1, y = 0, z = 0;
            var lista = new List<int>();

            System.Console.WriteLine("Digite um número inteiro");
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                z = x + y;

                lista.Add(z);

                y = x;
                x = z;
            }
            if (lista.Contains(n))
            {
                System.Console.WriteLine($"O número {n}, pertence as sequência Fibonacci");
            }
            else
            {
                System.Console.WriteLine($"O número {n}, Não pertence as sequência Fibonacci");
            }
            Console.ReadLine();
        }
    }
}
