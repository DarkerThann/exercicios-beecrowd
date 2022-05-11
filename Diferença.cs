using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace breecowd7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicio: https://www.beecrowd.com.br/judge/pt/problems/view/1007

            int[] num = new int [4];

            for (int i = 0; i < 4; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            int diferenca = (num[0] * num[1]) - (num[2] * num[3]);
           
            Console.WriteLine();
            Console.Write($"DIFERENÇA = {diferenca}");

            Console.ReadLine();
        }
    }
}
