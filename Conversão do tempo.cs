namespace Conversao_do_tempo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercicio: https://www.beecrowd.com.br/judge/pt/problems/view/1019

            int valueSec;
            int hour;
            int minute;
            int sec;

            valueSec = int.Parse(Console.ReadLine());

            hour = valueSec / 3600;
            minute = (valueSec - (hour * 3600)) / 60;
            sec = valueSec % 60;

            Console.WriteLine($"{hour}:{minute}:{sec}");
            Console.ReadLine();

        }
    }
}