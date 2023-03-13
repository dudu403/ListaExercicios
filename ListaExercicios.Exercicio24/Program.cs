namespace ListaExercicios.Exercicio24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var resultado = 0;
            for (int numero = 1; numero <= 500; numero++)
            {
                if (numero % 2 == 1 && numero % 3 == 0)
                    resultado = resultado + numero;
            }

            Console.WriteLine($"O resultado é: {resultado}");
            Console.ReadLine();
        }
    }
}