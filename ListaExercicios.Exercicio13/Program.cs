namespace ListaExercicios.Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de pães vendidos:");
            int paes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de broas vendidas:");
            int broas = Convert.ToInt32(Console.ReadLine());

            var totalPaes = paes * 0.12;
            var totalBroas = broas * 1.50;
            var valorTotalGeral = totalPaes + totalBroas;
            Console.WriteLine($"O total vendido de pães e broas é de: {valorTotalGeral} reais");

            var valorPoupanca = valorTotalGeral * 0.10;
            Console.WriteLine("Valor a ser guardado na Poupança: " + valorPoupanca.ToString("F"));

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}