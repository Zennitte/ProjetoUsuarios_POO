using System;
using ProjetoProdutos_POO.Interfaces;

namespace ProjetoProdutos_POO.Classes
{
    public class Login : ILogin
    {
        public bool Logado { get; set; }
        Usuario novoUsuario = new Usuario();
        public Login()
        {
            bool checar = true;
            int codigoU = 0;
            int select;
            do
            {

                Console.WriteLine(@"
Olá! O que deseja fazer?
1 - Cadastrar usuário
2 - Fazer o Login 
3 - Deslogar
0 - Sair");
                select = int.Parse(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        Console.WriteLine("Digite seu nome: ");
                        string nomeU = Console.ReadLine().ToLower();
                        codigoU += 1;
                        Console.WriteLine("Digite seu email: ");
                        string emailU = Console.ReadLine().ToLower();
                        Console.WriteLine("Digite sua senha: ");
                        string senhaU = Console.ReadLine();
                        Usuario usuario1 = new Usuario(codigoU, nomeU, emailU, senhaU);
                        // novoUsuario.Cadastrar(usuario1);
                        Console.WriteLine(novoUsuario.Cadastrar(usuario1));
                        break;
                    case 2:
                        do
                        {
                            Console.WriteLine("Digite seu email: ");
                            string emailLogar = Console.ReadLine().ToLower();
                            Console.WriteLine("Digite sua senha: ");
                            string senhaLogar = Console.ReadLine();
                            if (novoUsuario.usuarios.Find(x => x.Email == emailLogar).Senha == senhaLogar)
                            {
                                Console.WriteLine(Logar(novoUsuario));
                                checar = false;
                            }
                            else
                            {
                                Console.WriteLine("O email ou a senha estão incorretos");
                            }
                        } while (checar == true);
                        checar = true;
                        break;
                    case 3:
                        do
                        {
                            Console.WriteLine("Digite seu email para deslogar: ");
                            string emailDeslogar = Console.ReadLine().ToLower();
                            Console.WriteLine("Digite sua senha para deslogar: ");
                            string senhaDeslogar = Console.ReadLine();
                            if (novoUsuario.usuarios.Find(x => x.Email == emailDeslogar).Senha == senhaDeslogar)
                            {
                                Console.WriteLine(Deslogar(novoUsuario));
                                checar = false;
                            }
                            else
                            {
                                Console.WriteLine("O email ou a senha estão incorretos");
                            }
                        } while (checar == true);
                        checar = true;
                        break;
                }
            } while (select != 0);
        }
        public string Logar(Usuario usuario)
        {
            if (Logado == false)
            {
                Logado = true;
                return ("Você foi logado");
            }
            return ("Você já está logado!");
        }
        public string Deslogar(Usuario usuario)
        {
            if (Logado == true)
            {
                Logado = false;
                return ("Você foi deslogado");
            }
            return ("Você já está deslogado!");
        }
    }
}