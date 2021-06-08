using System.Collections.Generic;
using ProjetoProdutos_POO.Classes;

namespace ProjetoProdutos_POO.Interfaces
{
    public interface IProduto
    {
        string Cadastrar(Produto produto);
        List<Produto> Listar();
        string Deletar(Produto produto);
    }
}