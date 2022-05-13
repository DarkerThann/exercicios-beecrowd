using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd18
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double[] tempoKm = new double[2];
            double litros = 0;

            for (int i = 0; i < 2; i++)
            {
                tempoKm[i] = Convert.ToInt32(Console.ReadLine());
            }

            litros = (tempoKm[0] * tempoKm[1]) / 12;
            Console.WriteLine();
            Console.Write(litros.ToString("0.000"));

            Console.ReadLine();
        }
    }
}
