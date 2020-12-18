using System;
using Aula_POO_Interface.Classes;

namespace Aula_POO_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();

            produto1.Codigo = 123;
            produto1.Nome = "CyberPunk 2077";
            produto1.Preco = 200;

            Produto produto2 = new Produto();

            produto2.Codigo = 124;
            produto2.Nome = "Assassins Creed Valhalla";
            produto2.Preco = 200;

            Produto produto3 = new Produto();

            produto3.Codigo = 125;
            produto3.Nome = "Watch Dogs Legion";
            produto3.Preco = 150;

            Console.ResetColor();

            Carrinho carrinho = new Carrinho();

            carrinho.Cadastrar(produto1);
            carrinho.Cadastrar(produto2);
            carrinho.Listar();

            Console.ForegroundColor = ConsoleColor.Green;
            carrinho.Alterar(produto2.Codigo, produto3);
            carrinho.Listar();

            Console.ForegroundColor = ConsoleColor.Red;
            carrinho.Deletar(produto1);
            carrinho.Listar();
        }
    }
}
