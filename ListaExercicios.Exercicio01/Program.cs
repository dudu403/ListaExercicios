namespace ListaExercicios.Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double volume, comprimento, largura, altura;

            Console.WriteLine("Informe o volume: ");
            comprimento = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o comprimento: ");
            largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura: ");
            altura = double.Parse(Console.ReadLine());

            volume = comprimento * largura * altura;

            Console.WriteLine("O volume da caixa é: " + volume);







        }
    }
}