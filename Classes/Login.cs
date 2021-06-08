using System;

namespace ProjetoProdutos_POO.Classes
{
    public class Login
    {
        private bool Logado;
        public void FazerLogin()
        {
            Console.WriteLine(@"
Olá! O que deseja fazer?
1 - Cadastrar usuário
2 - Fazer o Login 
3 - Sair");
            string select = Console.ReadLine();

            switch (select)
            {
                case "1":
                    Console.WriteLine("Digite seu nome: ");
                    string nomeCadastro = Console.ReadLine();
                    Console.WriteLine("Digite seu código: ");
                    string codigoCadastro = Console.ReadLine();
                    Console.WriteLine("Digite seu email: ");
                    string emailCadastro = Console.ReadLine();
                    Console.WriteLine("Digite seu senha: ");
                    string senhaCadastro = Console.ReadLine();
                    Usuario usuario = new Usuario(nomeCadastro, codigoCadastro, emailCadastro, senhaCadastro);
                    Usuario.Cadastrar(usuario);
                    break;
                case "2":
                    
                    break;
            }
        }
        public string Logar(Usuario usuario)
        {

            return "Batata";
        }
        public string Deslogar(Usuario usuario)
        {

            return "Batata";
        }
    }
}