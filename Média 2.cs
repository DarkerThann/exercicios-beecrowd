using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicio: https://www.beecrowd.com.br/judge/pt/problems/view/1006

            double[] nota = new double[3];

            for (int i = 0; i < 3; i++)
            {
                nota[i] = Convert.ToDouble(Console.ReadLine());
            }

            double media = (2 * nota[0]) + (3 * nota[1]) + (5 * nota[2]);
            Console.WriteLine($"MEDIA = {media / 10:0.0}");

            Console.ReadLine();

        }
    }
}
