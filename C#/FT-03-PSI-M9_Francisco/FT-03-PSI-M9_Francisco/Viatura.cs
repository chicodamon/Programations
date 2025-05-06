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

        public Viatura(string marca, string modelo, int numPortas, int ano) 
        {
            Marca = marca;
            Modelo = modelo;
            NumPortas = numPortas;
            Ano = ano;
        }

        public string obterMarca()
        {
            return Marca;
        }
        public string obterModelo()
        {
            return Modelo;
        }
        public int obterNumPortas()
        {
            return NumPortas;
        }

        public int obterAno() 
        {
            return Ano;
        }

        public void alterNumPortas(int numPortas) 
        {
            this.NumPortas = numPortas;
        }

        public void alterAno(int ano) 
        {
            this.Ano = ano;
        }
    }
}
