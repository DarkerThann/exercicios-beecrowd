using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicio: https://www.beecrowd.com.br/judge/pt/problems/view/1005

            double nota1, nota2, media;

            nota1 = Convert.ToDouble(Console.ReadLine());
            nota2 = Convert.ToDouble(Console.ReadLine());

            media = (3.5 * nota1) + (7.5 * nota2);

            Console.WriteLine();
            Console.Write($"MEDIA = {media / 11:0.00000}");

            Console.ReadLine();
        }
    }
}
