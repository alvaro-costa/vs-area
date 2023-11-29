using System;

namespace ExercicioClasseObjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto("Camisa", 23.99, 9);

            Console.WriteLine(produto);
            Console.WriteLine($"Valor em estoque: {produto.ValorTotalEstoque():C2}");

            Produto outroProduto = new Produto {Nome = "Meia", Preco = 22.22 };

            Console.WriteLine(outroProduto);
            Console.WriteLine($"Valor em estoque: {outroProduto.ValorTotalEstoque():C2}");
        } //main

    }
}