namespace ListaExercicios.Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Fahrenheit;
            double Celsius;
            Console.WriteLine("Informe a temperatura em Celsius: ");

            Celsius = double.Parse(Console.ReadLine());

            Celsius = (Celsius * 1.8) + 32;

            Console.WriteLine("A temperatura em Celsius é: " + Celsius);
        }
    }
}