using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoRestauranteUsuario.Models.CardapioBistro;

namespace ProjetoRestauranteUsuario.Interface.Metodos
{
    internal class InterfaceCardápio
    {
        public static void CardapioRefeicoes()
        {
            CardapioPratos.RecebeJson(@"../../../ReceivingData/pratos.json");
            CardapioPratos.MostrarCardapio();
        }

        public static void CardapioBebidas()
        {
            
        }
    }
}
