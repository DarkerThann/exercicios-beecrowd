namespace Teste_de_Seleçao_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercicio: https://www.beecrowd.com.br/judge/pt/problems/view/1035

            int[] abcd = new int[4];
            
            for (int i = 0; i < 4; i++)
            {
                abcd[i] = int.Parse(Console.ReadLine());
            }

            bool validacao = abcd[1] > abcd[2] && abcd[3] > abcd[0] && abcd[2] + abcd[3] > abcd[0] + abcd[1] && abcd[2] > 0 && abcd[3] > 0 && abcd[0] % 2 == 0;
            if (validacao)
            {   
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores não aceitos");
            }
        }
    }
}
