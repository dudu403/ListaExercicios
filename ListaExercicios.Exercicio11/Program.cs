namespace ListaExercicios.Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int divisores = 0;

            Console.WriteLine("Digite um número:");
            num = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    divisores++;    
            }

            if (divisores == 2)
            {
                Console.WriteLine("É um número primo");
            } else
            {
                Console.WriteLine("Não é número primo");
            }
                

        }
    }
}