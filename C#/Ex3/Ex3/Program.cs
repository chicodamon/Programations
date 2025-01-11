namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pedir dois numeros e saber a diferença
            int n1, n2;

            Console.WriteLine("Indique o primeiro numero: ");

            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Indique o segundo numero: ");

            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("A diferença dos dois numeros dados é de: " + (n1 - n2));
        }

    }
}