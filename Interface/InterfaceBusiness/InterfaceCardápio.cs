using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoRestauranteUsuario.Models.CardapioBistro;

namespace ProjetoRestauranteUsuario.Interface.InterfaceBusiness
{
    internal class InterfaceCardápio
    {
        public static void CardapioRefeicoes()
        {
            CardapioPratos.MostrarCardapio();
        }

        public static void CardapioBebidas()
        {

        }
    }
}
