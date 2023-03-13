namespace ListaExercicio.Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a temperatura em Graus Celsius?");
            var celsius = Convert.ToDouble(Console.ReadLine());
            var fahrenheit = celsius * 1.8 + 32;
            Console.WriteLine($"A temperatura é de {fahrenheit} graus Fahrenheit");

            Console.ReadLine();
        }
    }
}