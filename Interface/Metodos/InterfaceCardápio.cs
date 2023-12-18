using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRestauranteUsuario.Interface.Metodos
{
    internal class InterfaceCardápio
    {
        public static void CardapioPratos()
        {
            //Console.WriteLine("Pratos adicionados");
            Cardapio.RecebeJson(@"../../../ReceivingData/pratos.json");
            Cardapio.mostrarCardapio();
        }

        public static void CardapioBebidas()
        {
            
        }
    }
}
