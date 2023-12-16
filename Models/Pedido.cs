using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRestauranteUsuario.Models
{
    internal class Pedido
    {
        public int ID { get; set; }
        private List<Prato> pratosDoPedido { get; set; }

        private decimal valorDoPedido;

        public Pedido(Prato prato)
        {
            pratosDoPedido.Add(prato);            
        }

        public decimal CalcularValorPedido()
        {

            foreach (Prato prato in pratosDoPedido)
            {
                valorDoPedido += prato.preco;

            }
            return valorDoPedido;
        }

    }
}
