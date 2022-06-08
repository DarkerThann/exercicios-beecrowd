namespace notas_e_moedas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Exercicio: https://www.beecrowd.com.br/judge/pt/problems/view/1021


            double value = double.Parse(Console.ReadLine());

            Console.WriteLine("NOTAS:");

            int cash100 = (int)value / 100;
            Console.WriteLine($"{cash100} notas (s) de R$ 100.00");

            double rest100 = value % 100;
            int cash50 = (int)rest100 / 50;
            Console.WriteLine($"{cash50} notas (s) de R$ 50.00");

            double rest50 = rest100 % 50;
            int cash20 = (int)rest50 / 20;
            Console.WriteLine($"{cash20} notas (s) de R$ 20.00");

            double rest20 = rest50 % 20;
            int cash10 = (int)rest20 / 10;
            Console.WriteLine($"{cash10} notas (s) de R$ 10.00");

            double rest10 = rest20 % 10;
            int cash5 = (int)rest10 / 5;
            Console.WriteLine($"{cash5} notas (s) de R$ 5.00");

            double rest5 = rest10 % 5;
            int cash2 = (int)rest5 / 2;
            Console.WriteLine($"{cash2} notas (s) de R$ 2.00");

            double coin = value - (cash100 * 100 + cash50 * 50 + cash20 * 20 + cash10 * 10 + cash5 * 5 + cash2 * 2);

            Console.WriteLine("MOEDAS:");

            Console.WriteLine($"{Math.Floor(coin / 1.00)} moeda (s) de R$ 1.00");

            coin = coin % 1.00;
            Console.WriteLine($"{Math.Floor(coin / 0.50)} moeda (s) de R$ 0.50");

            coin = coin % 0.50;
            Console.WriteLine($"{Math.Floor(coin / 0.25)} moeda (s) de R$ 0.25");

            coin = coin % 0.25;
            Console.WriteLine($"{Math.Floor(coin / 0.10)} moeda (s) de R$ 0.10");

            coin = coin % 0.10;
            Console.WriteLine($"{Math.Floor(coin / 0.05)} moeda (s) de R$ 0.05");

            coin = coin % 0.05;
            Console.WriteLine($"{Math.Floor(coin / 0.01)} moeda (s) de R$ 0.01");

        }
    }
}