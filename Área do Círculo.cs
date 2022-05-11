using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicio: https://www.beecrowd.com.br/judge/pt/problems/view/1002

            double area, raio;
            double pi = 3.14159;

            Console.Write("Raio: ");
            raio = Convert.ToDouble(Console.ReadLine());
            area = pi * Math.Pow(raio, 2);

            Console.Write($"A = {Math.Round(area,4)}");
            Console.ReadLine();
        }
    }
}
