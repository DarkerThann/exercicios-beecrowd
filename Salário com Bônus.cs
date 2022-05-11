using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace breecrowd9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicio: https://www.beecrowd.com.br/judge/pt/problems/view/1009
            string nome;
            nome = Console.ReadLine();

            double[] salarioVendas = new double[2];

            for (int i = 0; i < 2; i++)
            {
                salarioVendas[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine();
            Console.Write($"TOTAL = R$ {salarioVendas[1] * 0.15 + salarioVendas[0]:0.00}");

            Console.ReadLine();

        }
    }
}
