namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcular a area de um triangulo area = base * altura /2
            double Area, Base, Altura;
            Console.WriteLine("Calculadora de Area do triangolo!");
            Console.WriteLine("Qual o valor da base do triangulo? ");
            Base = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor da altura do trianulo? ");
            Altura = double.Parse(Console.ReadLine());

            //Calculo area = base x altura /2
            Area = Base * Altura /2;

            Console.WriteLine("O valor da area do triangulo é de: " + Area);

        }

    }
}