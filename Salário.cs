using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicio: https://www.beecrowd.com.br/judge/pt/problems/view/1008

            int[] numHora = new int[2];

            for (int i = 0; i < 2; i++)
            {
                numHora[i] = Convert.ToInt32(Console.ReadLine());
            }

            double salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"NUMBER = {numHora[0]}");    
            Console.Write($"SALARY = U$ {numHora[1] * salario:0.00}");
            Console.ReadLine();
        }
    }
}
