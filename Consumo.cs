using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd14
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercício: https://www.beecrowd.com.br/judge/pt/problems/view/1014

            int x = 0;
            double y = 0;

            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{x / y:0.000} km/l") ;

            Console.ReadLine();
        }
    }
}
