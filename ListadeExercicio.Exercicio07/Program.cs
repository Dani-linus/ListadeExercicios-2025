using System.ComponentModel;

namespace ListadeExercicio.Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

          

            bool primo = true;

            if (numero <= 1)
            {
                primo = false; 
            }
            else
            {
                int limite = (int)Math.Sqrt(numero); 

                for (int i = 2; i <= limite; i++)
                {
                    if (numero % i == 0)
                    {
                        primo = false;
                        break; 
                    }
                }
            }

            if (primo)
                Console.WriteLine($"{numero} é um número primo.");
            else
                Console.WriteLine($"{numero} não é um número primo.");

            Console.ReadLine();
        }
    
    }
}
