using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicio: https://www.beecrowd.com.br/judge/pt/problems/view/1011

            double pi = 3.14159, r;

            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"VOLUME = {(4 /3.0) * pi * Math.Pow(r, 3):0.000}");

            Console.ReadLine();
        }
    }
}
