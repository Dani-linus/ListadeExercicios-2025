namespace ListadeExercicios.Exercicios01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region input de dados
            Console.WriteLine("Digite o comprimento da caixa:" );
            decimal comprimento = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o tamanho da largura:" );
            decimal largura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a altura da caixa: ");
            decimal altura = Convert.ToDecimal(Console.ReadLine());
            #endregion

            #region processamento de dados
            decimal volume_caixa = comprimento * largura * altura;
            #endregion

            #region output dos dados
            Console.WriteLine($"O volume da caixa é {volume_caixa}.");
            #endregion

            Console.ReadLine();
        }
    }
}
