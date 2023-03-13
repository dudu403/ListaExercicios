namespace ListaExercicios.Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int R  = int.Parse(Console.ReadLine());
            double Pi = 3.14;
            double RaioCubo = Math.Pow(R, 3);
            double volume = (4.0 / 3) * Pi * RaioCubo;

            Console.WriteLine("Volume = " + volume);

        }
    }
}