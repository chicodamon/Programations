namespace Ex2
{
	class Program
	{
		static void Main(string[] args)
		{ 
			//Pedir dois numeros e somar
			int n1, n2;

			Console.WriteLine("Indique o primeiro numero a somar: ");

			n1 = int.Parse(Console.ReadLine());

			Console.WriteLine("Indique o segundo: ");

			n2 = int.Parse(Console.ReadLine());

			Console.WriteLine("A soma dos dois numeros dados é de: "+(n1+n2));
		}

	}
}