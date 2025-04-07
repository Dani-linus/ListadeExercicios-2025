using System.Runtime.Serialization;

namespace ListadeExercicio.Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double soma = a + b;

            string resultado = soma < c ? "menor" : soma > c ? "maior" : "igual";
            Console.WriteLine($"A soma dos valores de A e B é {resultado} que o valor C informado");
        }
    }
}
