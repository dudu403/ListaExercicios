namespace ListaExercicios.Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, media;

            Console.WriteLine("Informe a primeira nota: ");

            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota: ");

            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a terceira nota: ");

            nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quarta nota: ");

            nota4 = double.Parse(Console.ReadLine());

            media = 4 / (1 / nota1 + 1 / nota2 + 1 / nota3 + 1 / nota4);

            Console.WriteLine("A média harmônica é: " + media);



        }
    }
}