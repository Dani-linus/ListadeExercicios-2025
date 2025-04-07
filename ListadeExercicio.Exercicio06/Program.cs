using System.Net.Http.Headers;

namespace ListadeExercicio.Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a primeira nota: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o peso da primeira nota: ");
            double p1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o peso da segunda nota: ");
            double p2 = Convert.ToDouble(Console.ReadLine());

            double media_ponderada = (n1 * p1 + n2 * p2) / (p1 + p2);

            Console.WriteLine($"A média ponderada é {media_ponderada}");
        }
    }
}
