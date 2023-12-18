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
        public Prato(string nome, decimal preco, string descricao)
        {
            this.nome = nome;
            this.preco = preco;
            this.descricao = descricao;
        }

        internal void obterInformações()
        {
            Console.WriteLine($"Nome: {nome} \nDescrição: {descricao} \nPreço: {preco}");
        }
    }
}
