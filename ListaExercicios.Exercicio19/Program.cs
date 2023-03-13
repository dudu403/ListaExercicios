namespace ListaExercicios.Exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, insira o seu peso: ");
            decimal peso = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Agora, digite a sua altura:");
            decimal altura = Convert.ToDecimal(Console.ReadLine());

            decimal IMC = peso / (altura * altura);
            Console.WriteLine($"Seu IMC é de {IMC.ToString("F")}");

            if (IMC <= 18.5m)
                Console.WriteLine("De acordo com o seu IMC, você está Abaixo do Peso");
            else if (IMC >= 18.5m && IMC <= 24.9m)
                Console.WriteLine("De acordo com o seu IMC, você está com o Peso Normal");
            else if (IMC >= 25.0m && IMC <= 29.9m)
                Console.WriteLine("De acordo com o seu IMC, você está Acima do Peso");
            else if (IMC >= 30.0m)
                Console.WriteLine("De acordo com o seu IMC, você está Obeso");

            Console.ReadLine();
        }
    }
}