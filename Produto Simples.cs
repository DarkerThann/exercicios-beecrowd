using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicio: https://www.beecrowd.com.br/judge/pt/problems/view/1004

            int valor1, valor2, prod;
            
            valor1 = Convert.ToInt32(Console.ReadLine());
            valor2 = Convert.ToInt32(Console.ReadLine());

            prod = valor1 * valor2;

            Console.WriteLine();
            Console.WriteLine($"PROD = {prod}");

            Console.ReadLine();
        }
    }
}
