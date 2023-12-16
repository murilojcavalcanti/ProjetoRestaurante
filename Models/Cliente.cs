using ProjetoRestauranteUsuario.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRestauranteUsuario.Models
{
    internal class Cliente : Usuario 
    {
        internal Cliente(string nome, int id)
            : base(nome, id)
        {
            this.nome = nome;
            this.id = id;
        }

    }
}
