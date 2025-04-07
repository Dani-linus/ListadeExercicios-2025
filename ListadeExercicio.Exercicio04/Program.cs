namespace ListadeExercicio.Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a temperatura em escala Celsius: ");
            int celsius = Convert.ToInt32(Console.ReadLine());

            int fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine($" A temperatura em escala Fahrenheit é : {fahrenheit}");
        }
    }
}
