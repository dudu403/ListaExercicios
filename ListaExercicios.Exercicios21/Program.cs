namespace ListaExercicios.Exercicios21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int c;

            if (a == b)
                c = a + b;
            else
                c = a * b;

            Console.WriteLine("O resultado do cálculo é de: " + c);
            Console.ReadLine();
        }
    }
}