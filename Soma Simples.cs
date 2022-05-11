using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicio: https://www.beecrowd.com.br/judge/pt/problems/view/1003
            
            int num1, num2, soma;

            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            
            soma = num1 + num2;
           
            Console.WriteLine();
            Console.Write($"SOMA = {soma}");

            Console.ReadLine();
        }
    }
}
