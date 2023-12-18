using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRestauranteUsuario.Models.AlimentosBistro
{
    abstract class Alimento
    {
        private decimal preco;
        private string nome;
        private string descricao;

        internal decimal Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        internal string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        internal string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public Alimento (string nome, decimal preco, string descricao)
        {
            this.nome = nome;
            this.preco = preco;
            this.descricao = descricao;
        }

        internal void ObterInformacoes()
        {
            Console.WriteLine($"Nome: {this.Nome} \nDescrição: {this.Descricao} \nPreço: {this.Preco}");
        }
    }
}
