using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRestauranteUsuario.Models.AlimentosBistro
{
    internal class Bebida : Alimento
    {
        public Bebida(string nome, decimal preco, string descricao) : base(nome, preco, descricao)
        {
            this.Descricao = descricao;
            this.Preco = preco;
            this.Nome = nome;
        }

        internal override void ObterInformacoes()
        {
            Console.WriteLine($"Nome: {this.Nome} \nDescrição: {this.Descricao} \nPreço: {this.Preco}");
        }
    }
}
