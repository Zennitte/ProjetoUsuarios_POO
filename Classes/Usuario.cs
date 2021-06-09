using System;
using System.Collections.Generic;
using ProjetoProdutos_POO.Interfaces;

namespace ProjetoProdutos_POO.Classes
{
    public class Usuario : IUsuario
    {
        public int Codigo { get; set; }


        public string Nome { get; set; }


        public string Email { get; set; }

        public string Senha { get; set; }
        
        
        public DateTime DataCadastro;
        public List<Usuario> usuarios = new List<Usuario>();
        public Usuario()
        {

        }
        public Usuario(int _codigo, string _nome, string _email, string _senha)
        {
            this.Codigo = _codigo;
            this.Nome = _nome;
            this.Email = _email;
            this.Senha = _senha;
            this.DataCadastro = DateTime.Now;
        }
        public string Cadastrar(Usuario usuario)
        {
            usuarios.Add(usuario);
            return "Cadastro efetuado";
        }

        public string Deletar(Usuario usuario)
        {
            usuarios.Remove(usuario);
            return "Cadastro deletado";
        }
    }
}