namespace ListaExercicios.Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double volume,comprimento, altura;

            Console.WriteLine("Informe o volume: ");
            comprimento = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o comprimento: ");
            altura = double.Parse(Console.ReadLine());

            volume = 3.14159 * comprimento * 2 * altura;

            Console.WriteLine("O volume é: " + volume);


        }
    }
}