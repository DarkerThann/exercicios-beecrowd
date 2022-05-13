using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd16
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercício: https://www.beecrowd.com.br/judge/pt/problems/view/1015

            double[] p1p2 = new double[4];
            double distancia = 0;

            for (int i = 0; i < 4; i++)
            {
                p1p2[i] = Convert.ToDouble(Console.ReadLine());
            }

            distancia = Math.Sqrt(Math.Pow(p1p2[0] - p1p2[2], 2) + Math.Pow(p1p2[1] - p1p2[3], 2));

            Console.WriteLine(distancia.ToString("0.0000"));

            Console.ReadLine();
        }
    }
}
