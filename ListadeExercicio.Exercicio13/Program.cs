namespace ListadeExercicio.Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor para calcular o fatorial: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int fat = 1;
           // int fatorial = 0;

            for ( int  i = 1; i <= numero; i++)
            {
                fat *= i;
               
            }
            Console.WriteLine($"{numero}! = {fat} ");
            Console.ReadLine();
            {

            }
        }
    }
}
