using System;

namespace ProjetoProdutos_POO.Classes
{
    public class Login
    {
        private bool Logado;
        Usuario usuario = new Usuario();
        public Login()
        {
            do
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
                        int codigoCadastro = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite seu email: ");
                        string emailCadastro = Console.ReadLine();
                        Console.WriteLine("Digite sua senha: ");
                        string senhaCadastro = Console.ReadLine();
                        Usuario usuario1 = new Usuario(codigoCadastro, nomeCadastro, emailCadastro, senhaCadastro);
                        usuario.Cadastrar(usuario1);
                        break;
                    case "2":
                        Logar();
                        break;
                }
            } while (Logado == true);
        }
        public string Logar()
        {
            Console.WriteLine("Digite seu email: ");
            string emailLogar = Console.ReadLine();
            Console.WriteLine("Digite sua senha: ");
            string senhaLogar = Console.ReadLine();
            if (usuario.usuarios.Find(x => x.Email == emailLogar).Senha == senhaLogar)
            {
                
            }
            else
            {
                Console.WriteLine("O email ou a senha estão incorretos");
            }
            return "Você foi Logado!";
        }
        public string Deslogar(Usuario usuario)
        {
            
            return "Você foi deslogado!";
        }
    }
}