using System;
using System.Collections.Generic;
using ProjetoProdutos_POO.Interfaces;

namespace ProjetoProdutos_POO.Classes
{
    public class Produto : IProduto
    {
        private int Codigo { get; set; }
        private string NomeProduto { get; set; }
        private float Preco { get; set; }
        private DateTime DataCadastro { get; set; }
        private Marca Marca { get; set; }
        private Usuario CadastradoPor { get; set; }
        private List<Produto> ListaDeProdutos { get; set; }
        List<Produto> ListaProdutos = new List<Produto>(); 
        public Produto()
        {

        }
        public Produto(int _codigo, string _nomeProduto, float _preco, Marca _marca, Usuario _cadastradoPor)  
        {
            this.Codigo = _codigo;
            this.NomeProduto = _nomeProduto;
            this.Preco = _preco;
            this.DataCadastro = DateTime.Now;
            this.Marca = _marca;
            this.CadastradoPor = _cadastradoPor;
            this.ListaDeProdutos = ListaProdutos;
        } 
        public string Cadastrar(Produto produto)
        {
            ListaProdutos.Add(produto);
            return "Produto adicionado";
        }

        public string Deletar(Produto produto)
        {
            ListaProdutos.RemoveAll(x => x.NomeProduto == produto.NomeProduto);
            return "Produto Removido";
        }

        public List<Produto> Listar()
        {
            return ListaProdutos;
        }
    }
}