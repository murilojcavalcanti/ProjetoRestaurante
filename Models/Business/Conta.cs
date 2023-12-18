using System;

namespace ProjetoRestauranteUsuario.Models.Business
{
    using AlimentosBistro;
    internal class Conta
    {
        private List<Pedido> pedidos = new List<Pedido>();
        private bool pago;

        internal bool Pago
        {
            get { return pago; }
            set { pago = value; }
        }

        internal void AdicionarPedido(Pedido pedido)
        {
            pedidos.Add(pedido);
        }

        internal decimal CalcularTotal()
        {
            decimal total = 0;

            foreach (var pedido in pedidos)
            {
                total += pedido.CalcularValorPedido();
            }

            return total;
        }

        internal void ExibirDetalhes()
        {
            Console.WriteLine("Detalhes da Conta:");

            foreach (var pedido in pedidos)
            {
                pedido.ExibirItens();
                Console.WriteLine("-------------------------");
            }

            Console.WriteLine($"Total da Conta: R$ {CalcularTotal():F2}");
        }

        internal void Pagar()
        {
            Pago = true;
            Console.WriteLine("Pedido foi pago.");
        }

    }
}

