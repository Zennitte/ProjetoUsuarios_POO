using System.Collections.Generic;
using ProjetoProdutos_POO.Classes;
namespace ProjetoProdutos_POO.Interfaces
{
    public interface IMarca
    {
         string Cadastrar(Marca marca);
         List<Marca> Listar();
         string Deletar(Marca marca);
    }
}