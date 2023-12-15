using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRestauranteUsuario
{
    public class Prato
    {
        private double preco { get; set; }
        private string nome { get; set; }
        private string descricao { get; set; }
        
        public Prato(string nome, double preco, string descricao)
        {
            this.nome = nome;
            this.preco = preco;
            this.descricao = descricao;
        }

        public void obterInformações ()
        {
            Console.WriteLine($"Nome: {this.nome} \nDescrição: {this.descricao} \nPreço: {this.preco}");
        }
    }
}
