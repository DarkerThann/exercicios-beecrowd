using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] peca1 = new int[2];
            int[] peca2 = new int[2];
            double[] valor = new double[2];

            for(int i = 0; i < 2; i++)
            {
                peca1[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            valor[0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < 2; i++)
            {
                peca2[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            valor[1] = Convert.ToDouble(Console.ReadLine());
           
            Console.WriteLine();
            Console.WriteLine($"VALOR A PAGAR = R$ {(peca1[1] * valor[0]) + (peca2[1] * valor[1]):0.00}");

            Console.ReadLine();

        }
    }
}
