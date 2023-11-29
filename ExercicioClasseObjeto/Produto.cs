using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasseObjeto
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome = "") 
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 0;
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"Nome: {Nome}, Preco: {Preco:C2} e Quantidade: {Quantidade}";

        }

        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }
    }
}
