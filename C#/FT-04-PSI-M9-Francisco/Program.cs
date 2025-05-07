using System.ComponentModel;

namespace FT_04_PSI_M9_Francisco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;

            Livro[] livros = new Livro[]
            {
                new Livro("A melodia n sei q", "Tchikolo", 2000),
                new Livro("Terra!", "Antonio", 1992),
                new Livro("Lusiadas das coubes", "Tchikolo", 2007)
            };

            for (int i = 0; i < livros.Count(); i++)
            {
            Console.WriteLine(livros[i]);
            Console.WriteLine($"Deseja alterar o ano de publicacao do livro com o titulo: '{livros[i].Titulo}' ?");
            Console.WriteLine("1 - Para continuar!");
            Console.WriteLine("2 - Seguinte!");
                x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    livros[i].alterAno();
                    Console.WriteLine(livros[i]);
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("Invalido!");
                    break;
            }
            }
        }
    }
}
