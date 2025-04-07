namespace ListadeExercicio.Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region input de dados
            Console.WriteLine("Digite a quilometragem inicial: ");
            double quilometragem_inicial = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quilometragem final: ");
            double quilometragem_final = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite quantidade de combustivel em litros: ");
            double qtd_litros = Convert.ToDouble(Console.ReadLine());

            #endregion

            #region processamento de dados
            double distancia = quilometragem_final - quilometragem_inicial;
            double consumo = qtd_litros / distancia;
            #endregion

            #region
            Console.WriteLine($"O consumo do combustivel por quilômetro percorrido é {consumo.ToString("F3")}");
            Console.ReadLine();
            #endregion
        }
    }
}
