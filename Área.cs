using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercício: https://www.beecrowd.com.br/judge/pt/problems/view/1012

            double[] abc = new double[3];

            for (int i = 0; i < 3; i++)
            {
                abc[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine();

            // área do triângulo retângulo que tem A por base e C por altura.
            Console.WriteLine($"TRIÂNGULO: {(abc[0] * abc[2]) / 2:0.000}");

            // área do círculo de raio C. (pi = 3.14159)
            Console.WriteLine($"CÍRCULO: {(3.14159 * Math.Pow(abc[2], 2 )):0.000}");

            // área do trapézio que tem A e B por bases e C por altura.
            Console.WriteLine($"TRAPÉZIO: {((abc[0] + abc[1]) / 2) * abc[2]:0.000}");

            // área do quadrado que tem lado B.
            Console.WriteLine($"QUADRADO: {Math.Pow(abc[1], 2):0.000}");

            // área do retângulo que tem lados A e B.
            Console.WriteLine($"RETÂNGULO: {abc[0] * abc[1]:0.000}");


            Console.ReadLine();
        }
    }
}
