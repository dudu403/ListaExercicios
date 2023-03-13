namespace ListaExercicios.Exercicio23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i <= 200; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}