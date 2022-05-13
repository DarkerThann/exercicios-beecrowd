using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd17
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercício: https://www.beecrowd.com.br/judge/pt/problems/view/1016

            int distancia = 0;
            distancia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"{(60 * distancia) / 30} minutos");

            Console.ReadLine();
        }
    }
}
