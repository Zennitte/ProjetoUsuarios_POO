using System;
using ProjetoProdutos_POO.Interfaces;

namespace ProjetoProdutos_POO.Classes
{
    public class Login : ILogin
    {
        public bool Logado { get; set; }
        Usuario novoUsuario = new Usuario();
        Marca novaMarca = new Marca();
        Produto novoProduto = new Produto();
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
2 - Fazer Login 
3 - Deslogar
4 - Cadastrar marca
5 - Listar marcas
6 - Deletar marca
7 - Cadastrar Produto
8 - Listar Produtos
9 - Deletar produto
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

                            Usuario usuarioEncontrado = novoUsuario.usuarios.Find(x => x.Email == emailLogar && x.Senha == senhaLogar);

                            if (usuarioEncontrado != null)
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
                    case 4:
                        if (Logado)
                        {
                            Console.WriteLine("Qual o código da marca você deseja cadastrar?");
                            int _codigo = int.Parse(Console.ReadLine());

                            Console.WriteLine("Qual marca você quer cadastrar?");
                            string _nomeMarca = Console.ReadLine();

                            Marca m1 = new Marca(_codigo, _nomeMarca);

                            Console.WriteLine(novaMarca.Cadastrar(m1));
                        }
                        else
                        {
                            Console.WriteLine("Você precisa estar logado para realizar essa ação");
                        }
                        break;
                    case 5:
                        if (Logado)
                        {
                            foreach (var item in novaMarca.ListaMarcas)
                            {
                                Console.WriteLine($"Nome: {item.NomeMarca} / Código: {item.Codigo}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Você precisa estar logado para realizar essa ação");
                        }
                        break;
                    case 6:
                        if (Logado)
                        {
                            Console.WriteLine("Digite o nome da marca que o quer deletar");
                            string _nomeMarca = Console.ReadLine();

                            Marca marcaEncontrada = novaMarca.ListaMarcas.Find(x => x.NomeMarca == _nomeMarca);

                            Console.WriteLine(novaMarca.Deletar(marcaEncontrada));
                        }
                        else
                        {
                            Console.WriteLine("Você precisa estar logado para realizar essa ação");
                        }
                        break;
                    case 7:
                        if (Logado)
                        {
                            Console.WriteLine("Digite o código do produto");
                            int _codigo = int.Parse(Console.ReadLine());

                            Console.WriteLine("Digite o nome do produto");
                            string _nomeProduto = Console.ReadLine();

                            Console.WriteLine("Digite o preço do produto");
                            float _preco = float.Parse(Console.ReadLine());

                            // Console.WriteLine("Digite a marca do produto");
                            // Marca _marca = novaMarca.ListaMarcas.Find(x => x.n)



                        }
                        else
                        {
                            Console.WriteLine("Você precisa estar logado para realizar essa ação");
                        }
                        break;
                    case 8:
                        if (Logado)
                        {
                            Console.WriteLine("Qual produto você quer deletar?");
                            string _nomeProduto = Console.ReadLine();

                            // Produto produtoEncontrado = novoProduto.ListaProdutos.fi
                        }
                        break;
                    case 9:
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção inválida");
                        Console.ForegroundColor = ConsoleColor.White;
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