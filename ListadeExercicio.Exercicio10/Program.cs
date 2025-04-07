using System.Drawing;
using System.Net;

namespace ListadeExercicio.Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = (peso / Math.Pow(altura, 2));

            Console.WriteLine("------------------------");
            Console.WriteLine($"Seu IMC é: {Math.Round(imc, 2)} ");
            Console.WriteLine("------------------------");

            if (imc <= 18.5)

                Console.WriteLine("Abaixo do peso");

            else if (imc > 18.5 && imc <= 25)

                Console.WriteLine("Peso normal");

            else if (imc > 25 && imc <= 30)

                Console.WriteLine("Acima do peso");

            else if (imc > 30)
                Console.WriteLine("Obeso");
        }
        }
    }
