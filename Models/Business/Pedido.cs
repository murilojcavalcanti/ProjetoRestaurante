using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoRestauranteUsuario.Models.AlimentosBistro;

namespace ProjetoRestauranteUsuario.Models.Business
{
    internal class Pedido
    {
        private int id;
        private List<Prato> pratosDoPedido = new List<Prato>();
        private decimal valorDoPedido;

        internal int Id
        {
            get { return id; }
            set { id = value; }
        }
        internal decimal ValorDoPedido
        {
            get { return valorDoPedido; }
            set { valorDoPedido = value; }
        }

        internal Pedido(Prato prato)
        {
            pratosDoPedido.Add(prato);
        }

        internal decimal CalcularValorPedido()
        {

            foreach (Prato prato in pratosDoPedido)
            {
                valorDoPedido += prato.Preco;

            }
            return valorDoPedido;
        }

    }
}
