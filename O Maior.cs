using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercício: https://www.beecrowd.com.br/judge/pt/problems/view/1013

            int[] num = new int[3];
            int maiorAB = 0;
            int maiorABC = 0;

            for (int i = 0; i < 3; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            maiorAB = (num[0] + num[1] + Math.Abs(num[0] - num[1])) / 2;
            maiorABC = (maiorAB + num[2] + Math.Abs(maiorAB - num[2])) / 2;

            Console.WriteLine($"{maiorABC} eh o maior");
            Console.ReadLine();
        }
    }
}
