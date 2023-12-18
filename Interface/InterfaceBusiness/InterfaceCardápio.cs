
using ProjetoRestauranteUsuario.Models.Business;
using ProjetoRestauranteUsuario.Models.CardapioBistro;

namespace ProjetoRestauranteUsuario.Interface.InterfaceBusiness
{
    internal class InterfaceCardápio
    {
        internal static void AbrirConta(Reservas reserva)
        {
            reserva.Mesa.AbrirConta();
        }
        public static void CardapioPratosRestaurante(Reservas reserva)
        {
            int selecao = CardapioPratos.MostrarCardapio();

            reserva.Mesa.Conta.AdicionarPedido(CardapioPratos.SelecionarItem(selecao));

            Console.WriteLine("Pedido adicionado com sucesso!");
        }

        public static void CardapioBebidasRestaurante(Reservas reserva)
        {
            int selecao = CardapioBebidas.MostrarCardapio();
            //reserva.Mesa.Conta.AdicionarPedido(CardapioBebidas.SelecionarItem(selecao));
            //Console.WriteLine("Pedido adicionado com sucesso!");
        }
    }
}
