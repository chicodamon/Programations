using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT_03_PSI_M9_Francisco
{
    internal class Viatura
    {
        public string Marca;
        public string Modelo;
        public int NumPortas;
        public int Ano;

        public static List<Viatura> ListaViaturas = new List<Viatura>();

        public Viatura(string marca, string modelo, int numPortas, int ano) 
        {
            Marca = marca;
            Modelo = modelo;
            NumPortas = numPortas;
            Ano = ano;
        }

        public static void CriarViatura(string marca, string modelo, int numPortas, int ano)
        {
            Viatura nova = new Viatura(marca, modelo, numPortas, ano);
            ListaViaturas.Add(nova);
            Console.WriteLine("Viatura criada!");
        }

        public static void ListarViaturas()
        {
            if (ListaViaturas.Count == 0)
            {
                Console.WriteLine("Nenhuma viatura registada.");
                return;
            }

            Console.WriteLine("Lista de Viaturas:");
            foreach (var v in ListaViaturas) //igual ao blade @foreach
            {
                Console.WriteLine($"{v.Marca} {v.Modelo} - {v.NumPortas} portas - Ano {v.Ano}");
            }
        }

        public static void EditarViatura()
        {
            if (ListaViaturas.Count == 0)
            {
                Console.WriteLine("Nenhuma viatura registada para editar.");
                return;
            }

            Console.WriteLine("Escolha o número da viatura que deseja editar:");
            for (int i = 0; i < ListaViaturas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {ListaViaturas[i].Marca} {ListaViaturas[i].Modelo} - {ListaViaturas[i].NumPortas} portas - Ano {ListaViaturas[i].Ano}");
            }

            Console.Write("Número da viatura: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= ListaViaturas.Count)
            {
                Viatura v = ListaViaturas[index - 1];

                Console.Write("Nova marca (atual: " + v.Marca + "): ");
                string novaMarca = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(novaMarca)) v.Marca = novaMarca;

                Console.Write("Novo modelo (atual: " + v.Modelo + "): ");
                string novoModelo = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(novoModelo)) v.Modelo = novoModelo;

                Console.Write("Novo número de portas (atual: " + v.NumPortas + "): ");
                if (int.TryParse(Console.ReadLine(), out int novoNumPortas))
                {
                    v.NumPortas = novoNumPortas;
                }

                Console.Write("Novo ano (atual: " + v.Ano + "): ");
                if (int.TryParse(Console.ReadLine(), out int novoAno))
                {
                    v.Ano = novoAno;
                }

                Console.WriteLine("Viatura editada com sucesso!");
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }
        }

        public static void RemoverViatura()
        {
            if (ListaViaturas.Count == 0)
            {
                Console.WriteLine("Nenhuma viatura registada para remover.");
                return;
            }

            Console.WriteLine("Escolha o número da viatura que deseja remover:");
            for (int i = 0; i < ListaViaturas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {ListaViaturas[i].Marca} {ListaViaturas[i].Modelo} - {ListaViaturas[i].NumPortas} portas - Ano {ListaViaturas[i].Ano}");
            }

            Console.Write("Número da viatura: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= ListaViaturas.Count)
            {
                ListaViaturas.RemoveAt(index - 1); // remove a viatura selecionada
                Console.WriteLine("Viatura removida com sucesso!");
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }
        }

    }
}
