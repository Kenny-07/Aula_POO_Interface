using System;
using System.Collections.Generic;

namespace Aula_POO_Interface.Classes
{
    public class Carrinho : ICarinho
    {
        public float ValorTotal { get; set; }

        List<Produto> carinho = new List<Produto>();

        public void Alterar(int _codigo, Produto produto)
        {
            carinho.Find(x => x.Codigo == _codigo).Nome = produto.Nome;
            carinho.Find(x => x.Codigo == _codigo).Preco = produto.Preco;
        }

        public void Cadastrar(Produto produto)
        {
            carinho.Add( produto );
        }

        public void Deletar(Produto produto)
        {
            carinho.Remove( produto );
        }

        public void Listar()
        {
            foreach ( Produto p in carinho){

                Console.WriteLine($"R$ {p.Preco,2} - {p.Nome}");

            }
        }
    }
}