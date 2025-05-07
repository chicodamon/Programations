using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FT_04_PSI_M9_Francisco
{
    internal class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }

        public Livro(string titulo, string autor, int ano)
        {
            Titulo = titulo;
            Autor = autor;
            Ano = ano;
        }

        //public void listarTudo()
        //{
        //    Console.WriteLine($"Livro -> Titulo: {Titulo}, Autor: {Autor}, Ano: {Ano}.");
        //}

        public void alterAno()
        { 
            Console.WriteLine("Alterar ano de publicacao ");
            Console.WriteLine("Introduza o novo ano!");
            int NovoAno = Convert.ToInt32( Console.ReadLine() );
            if (NovoAno >= 1900 && NovoAno <= DateTime.Now.Year)
            {
                Ano = NovoAno;
            }
            else
            {
                Console.WriteLine("Ano Invalido!");
            }
        }

        public override string ToString() 
        {
            return $"Dados do livro -> Titulo: {Titulo}, Autor {Autor}, Ano: {Ano}";
        }
    }
}
