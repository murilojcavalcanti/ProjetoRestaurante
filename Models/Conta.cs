using System;

namespace ProjetoRestauranteUsuario.Models
{
    public class Conta
    {
        private List<Pedido> pedidos = new List<Pedido>();
        public bool Pago { get; private set; }


        public void AdicionarPedido(Pedido pedido)
        {
            pedidos.Add(pedido);
        }

        public decimal CalcularTotal()
        {
            decimal total = 0;

            foreach (var pedido in pedidos)
            {
                total += pedido.CalcularTotal();
            }

            return total;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine("Detalhes da Conta:");

            foreach (var pedido in pedidos)
            {
                pedido.ExibirItens();
                Console.WriteLine("-------------------------");
            }

            Console.WriteLine($"Total da Conta: R$ {CalcularTotal():F2}");
        }

        public void Pagar()
        {
            Pago = true;
            Console.WriteLine("Pedido foi pago.");
        }

    }
}

