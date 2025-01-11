namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Receber o valor ao kg de um produto e a quantidade em kg para calcular o valor total do produto

            double Pkg, quantidade, Vpago;

            Console.WriteLine("Preço/Kg do produto: ");
            Pkg = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade(KG): ");
            quantidade = double.Parse(Console.ReadLine());

            Vpago = Pkg * quantidade;

            Console.WriteLine("O valor a ser pago é de: "+Vpago);
        }

    }
}