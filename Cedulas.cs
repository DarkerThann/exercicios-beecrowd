namespace Cedulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício: https://www.beecrowd.com.br/judge/pt/problems/view/1018

            int value;
            value = int.Parse(Console.ReadLine());

            Console.WriteLine($"{value / 100} nota(s) de R$ 100,00");
            value = value % 100;

            Console.WriteLine($"{value / 50} nota(s) de R$ 50,00");
            value = value % 50;

            Console.WriteLine($"{value / 20} nota(s) de R$ 20,00");
            value = value % 20;

            Console.WriteLine($"{value / 10} nota(s) de R$ 10,00");
            value = value % 10;

            Console.WriteLine($"{value / 5} nota(s) de R$ 5,00");
            value = value % 5;

            Console.WriteLine($"{value / 2} nota(s) de R$ 2,00");
            value = value % 2;

            Console.WriteLine($"{value / 1} nota(s) de R$ 1,00");
            value = value % 2;

            Console.ReadLine();
        }
    }
}