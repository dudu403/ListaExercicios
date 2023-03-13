namespace ListaExercicio.Exercicio25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número de 1 a 10: ");
            var n = Convert.ToInt32(Console.ReadLine());
            if (n > 10)
            {
                Console.WriteLine("O número informado é maior que 10");
            }
            else
            {
                for (int i = 0; i <= 10; i++)
                    Console.WriteLine($"{i} X {n} = {n * i}");
            }
            Console.ReadLine();
        }
    }
}