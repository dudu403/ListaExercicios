namespace ListaExercicios.Exercicio26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, digite o fatorial: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int resultado = 1;
            string contaFatorial = "";
            var fatorialInicial = a;

            while (a != 1)
            {
                contaFatorial = $"{contaFatorial} {a} X";
                resultado = resultado * a;
                a = a - 1;
            }
            Console.WriteLine($"{fatorialInicial}! = {contaFatorial} 1 = {resultado}");
            Console.ReadLine();
        }
    }
}