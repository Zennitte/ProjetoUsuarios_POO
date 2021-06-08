using ProjetoProdutos_POO.Classes;

namespace ProjetoProdutos_POO.Interfaces
{
    public interface ILogin
    {
         void Login();
         string Logar(Usuario usuario);
         string Deslogar(Usuario usuario);
         
    }
}