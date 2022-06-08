namespace idade_em_dias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercicio: https://www.beecrowd.com.br/judge/pt/problems/view/1020

            int age;
            int year;
            int month;
            int day;

            age = int.Parse(Console.ReadLine());

            year = age / 365;
            month = (age % 365) / 30;
            day = (age % 365) - (month * 30);

            Console.WriteLine($"{year} anos (s)\n{month} mes (es)\n{day} dia (s)");

        }
    }
}