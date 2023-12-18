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
            cardapioCompleto = new List<Bebida>();
        }

        internal static Bebida SelecionarItem(int indice)
        {
            return cardapioCompleto[indice];
        }
    }
}
