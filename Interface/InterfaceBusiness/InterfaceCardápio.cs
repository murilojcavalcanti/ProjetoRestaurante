
using ProjetoRestauranteUsuario.Models.AlimentosBistro;
using ProjetoRestauranteUsuario.Models.Business;
using ProjetoRestauranteUsuario.Models.CardapioBistro;
using System.IO;

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

            Prato prato = CardapioPratos.SelecionarItem(selecao);

            reserva.Mesa.Conta.AdicionarPedido(prato);

            reserva.Mesa.Conta.ValorTotal += prato.Preco;
            Console.WriteLine("Pedido adicionado com sucesso!");
        }

        public static void CardapioBebidasRestaurante(Reservas reserva)
        {
            int selecao = CardapioBebidas.MostrarCardapio();

            Bebida bebida = CardapioBebidas.SelecionarItem(selecao);
            reserva.Mesa.Conta.AdicionarPedido(bebida);

            reserva.Mesa.Conta.ValorTotal += bebida.Preco;
            Console.WriteLine("Pedido adicionado com sucesso!");
        }
    }
}
