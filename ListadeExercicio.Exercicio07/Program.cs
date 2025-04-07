using System.ComponentModel;

namespace ListadeExercicio.Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % numero == 1)
            {
                Console.WriteLine($"O numero informado {numero} é primo ");
            }
        }
    }
}
