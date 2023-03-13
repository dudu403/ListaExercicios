namespace ListaExercicios.Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Fahrenheit;
            double Celsius;
            Console.WriteLine("Informe a temperatura em Fahrenheit: ");

            Fahrenheit = double.Parse(Console.ReadLine());

            Celsius = (Fahrenheit - 32) * 5 / 9;

            Console.WriteLine("A temperatura em Celsius é: " + Celsius);

        }
    }
}