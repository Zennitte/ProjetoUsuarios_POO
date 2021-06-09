using System;
using System.Collections.Generic;
using ProjetoProdutos_POO.Interfaces;

namespace ProjetoProdutos_POO.Classes
{
    public class Marca : IMarca
    {
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; }    
        public List<Marca> ListaMarcas = new List<Marca>();
        public Marca()
        {

        }
        public Marca(int _codigo,string _nomeMarca)
        {
            this.Codigo = _codigo;
            NomeMarca = _nomeMarca;
            DataCadastro = DateTime.Now;            
        }
        public string Cadastrar(Marca marca)
        {
            ListaMarcas.Add(marca);
            return "Marca Cadastrada";;
        }

        public string Deletar(Marca marca)
        {
            ListaMarcas.RemoveAll(x => x.NomeMarca == marca.NomeMarca);
            return "Marca Removida";
        }

        public List<Marca> Listar()
        {
            return ListaMarcas;
        }
    }
}