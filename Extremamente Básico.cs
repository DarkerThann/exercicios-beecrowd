using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicio: https://www.beecrowd.com.br/judge/pt/problems/view/1001

            int num1, num2, x;

            Console.Write("Insira um número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Insira outro número: ");
            num2 = int.Parse(Console.ReadLine());

            x = num1 + num2;
            Console.WriteLine($"X = {x}");

            Console.ReadLine();
        }
    }
}
