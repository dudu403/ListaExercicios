namespace ListaExercicios.Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a largura do terreno:");
            var larguraTerreno = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe o comprimento do terreno:");
            var comprimentoTerreno = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("A área total do terreno é de: ");
            var totalTerreno = larguraTerreno * comprimentoTerreno;
            Console.WriteLine(totalTerreno);

            Console.ReadLine();
        }
    }
}