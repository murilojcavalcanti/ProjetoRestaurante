using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRestauranteUsuario.Models.AlimentosBistro
{
    internal class Prato : Alimento
    {
        public Prato(string nome, decimal preco, string descricao) : base(nome, preco, descricao)
        {
            this.Descricao = descricao;
            this.Preco = preco;
            this.Nome = nome;
        }

    }
}
