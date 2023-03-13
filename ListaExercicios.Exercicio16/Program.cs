namespace ListaExercicios.Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor para A:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite um valor para B:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite um valor para C:");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a + b >= c)
                Console.WriteLine("A soma de a + b não é menor que c");
            else
                Console.WriteLine("A soma de a + b é menor que c");

            Console.ReadLine();
        }
    }
}