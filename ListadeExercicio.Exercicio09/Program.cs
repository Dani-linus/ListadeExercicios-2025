using System;

namespace ListadeExercicio.Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro valor: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            int n3 = Convert.ToInt32(Console.ReadLine());


            if (n1 != n2 && n3 != n1 && n3 != n2 && n1 != n3)
            {
                if (n1 > n2 && n1 > n3)
                {
                    Console.WriteLine(n1);

                    if (n2 > n3)
                    {
                        Console.WriteLine(n2);
                    }
                    else
                    {
                        Console.WriteLine(n3);
                    }
                }
                if (n2 > n1 && n2 > n3)
                {
                    Console.WriteLine(n2);

                    if (n1 > n3)
                    {
                        Console.WriteLine(n1);
                    }
                    else
                    {
                        Console.WriteLine(n3);
                    }
                }
                if (n3 > n1 && n3 > n2)
                {
                    Console.WriteLine(n3);

                    if (n1 > n2)
                    {
                        Console.WriteLine(n1);
                    }
                    else
                    {
                        Console.WriteLine(n2);
                    }
                   
                }
                Console.ReadLine();
            }
            
        }
        }
}
