namespace ListaExercicios.Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome?");
            var nome = Console.ReadLine();

            Console.WriteLine("Qual a sua idade?");
            int idade = Convert.ToInt32(Console.ReadLine());

            int diasDeVida = idade * 365;

            Console.WriteLine($"{nome} você já viveu {diasDeVida} dias de vida");

            Console.ReadLine();
        }
    }
}