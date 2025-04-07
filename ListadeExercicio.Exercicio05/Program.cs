namespace ListadeExercicio.Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o salário base do vendedor: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o total de vendas do vendedor: ");
            double total_vendas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o percentual de vendas : ");
            
            double percentual = Convert.ToDouble(Console.ReadLine());

            double comissao = total_vendas * (percentual / 100);
            double salario_total = salario + comissao;

            Console.WriteLine($"O salário total do vendedor foi {salario_total}");
        }
    }
}
