namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Receber dois numeros e retornar o maior entre eles

            int n1, n2;

            Console.WriteLine("Introduza o primeiro numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduza o segundo numero: ");
            n2 = int.Parse(Console.ReadLine());

            if (n1 < n2)
                Console.WriteLine("O maior numero é: " + n2);
            else if (n1 > n2)
                Console.WriteLine("O maior numero é: " + n1);
            else
            {
                Console.WriteLine("Os numeros sao iguais! ");
            }
        }

    }
}