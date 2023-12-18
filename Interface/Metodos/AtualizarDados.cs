using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRestauranteUsuario.Interface.Metodos
{
    using Models.CardapioBistro;
    internal class AtualizarDados
    {
        public static void AtualizarCardapio()
        {
            Console.Clear();
            Console.WriteLine("Atualizando cardápio...");
            CardapioPratos.RecebeJson(@"../../../ReceivingData/pratos.json");
            CardapioBebidas.RecebeJson(@"../../../ReceivingData/bebidas.json");
            Console.WriteLine("Cardápio atualizado com sucesso!");
            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}
