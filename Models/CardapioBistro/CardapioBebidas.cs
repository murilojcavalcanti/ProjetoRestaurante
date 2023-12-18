using ProjetoRestauranteUsuario.Models.AlimentosBistro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRestauranteUsuario.Models.CardapioBistro
{
    internal class CardapioBebidas : CardapioBase<Bebida>
    {
        internal CardapioBebidas()
        {
            cardapioCompleto = new List<Bebida>
            {
                new Bebida("Lasanha", 15.99m, "Massa com molho de tomate, queijo e carne."),
            };


        }
    }
}
