namespace ListadeExercicios.Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region input de dados
            Console.WriteLine("Digite o raio do cilindro: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a altura do cilindro: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            #endregion

            #region processamento de dados
            double volume = Math.PI * Math.Pow(raio, 2) * altura;
            #endregion

            #region output de dados
            Console.WriteLine($"O volume do cilindro é {volume}");
            #endregion

            Console.ReadLine();
        }
    }
}
