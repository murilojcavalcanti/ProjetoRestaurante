using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRestauranteUsuario.Models.Usuarios
{
    internal abstract class Usuario
    {
        protected string nome;
        protected int id;

        internal Usuario(string nome, int id)
        {
            this.nome = nome;
            this.id = id;
        }
    }
}
