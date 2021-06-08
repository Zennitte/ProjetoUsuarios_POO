using ProjetoProdutos_POO.Classes;

namespace ProjetoProdutos_POO.Interfaces
{
    public interface IUsuario
    {
        string Cadastrar(Usuario usuario);
        string Deletar(Usuario usuario);
    }
}