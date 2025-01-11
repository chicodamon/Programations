namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Receber valor pago, valor do preço do produto e devolvao troco a ser dado
            double preco, pago, troco;

            Console.WriteLine("Produto: ");
            preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor pago: ");
            pago = double.Parse(Console.ReadLine());

            troco = pago - preco;
            if (troco > 0)
                Console.WriteLine("Troco:  " + troco);
            else if (troco < 0)
                Console.WriteLine("Valor insuficiente");
            else
                Console.WriteLine("Valor certo, nao a troco!");
        }

    }
}