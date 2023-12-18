
namespace ProjetoRestauranteUsuario.Models.Business
{
    using AlimentosBistro;
    internal class Conta
    {
        private List<Pedido> pedidos = new List<Pedido>();
        private bool pago;
        private decimal valorTotal = 0;

        internal decimal ValorTotal
        {
            get { return valorTotal; }
            set { valorTotal = value; }
        }

        internal bool Pago
        {
            get { return pago; }
            set { pago = value; }
        }

        internal List<Pedido> Pedidos
        {
            get { return pedidos; }
            set { pedidos = value; }
        }

        internal void AdicionarPedido(Prato pedidoCliente)
        {
            var pedido = new Pedido(pedidoCliente);
            pedidos.Add(pedido);
        }

        internal void AdicionarPedido(Bebida pedidoCliente)
        {
            var pedido = new Pedido(pedidoCliente);
            pedidos.Add(pedido);
        }

        internal decimal CalcularTotal()
        {
            return valorTotal;
        }

        internal void ExibirDetalhes()
        {
            Console.WriteLine("Detalhes da Conta:");

            Console.WriteLine($"Total da Conta: R$ {CalcularTotal():F2}");
        }

        internal void Pagar()
        {
            Pago = true;
            Console.WriteLine("Pedido foi pago.");
        }

    }
}

