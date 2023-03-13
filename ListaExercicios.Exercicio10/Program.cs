namespace ListaExercicios.Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota 1 ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o peso para a nota 1 ");
            int peso1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do 2 Bimestre");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o peso para a nota 2 ");
            int peso2 = int.Parse(Console.ReadLine());

            double md = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);

            Console.WriteLine("A sua media e: {0}", md);
        }
    }
}