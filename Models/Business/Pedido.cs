
using ProjetoRestauranteUsuario.Models.AlimentosBistro;

namespace ProjetoRestauranteUsuario.Models.Business
{
    internal class Pedido
    {
        private int id;
        private List<Prato> pratosDoPedido = new List<Prato>();
        private List<Bebida> bebidasDoPedido = new List<Bebida>();

        internal int Id
        {
            get { return id; }
            set { id = value; }
        }

        internal Pedido(Prato pedido)
        {
            pratosDoPedido.Add(pedido);
        }

        internal decimal CalcularValorPedido()
        {
            decimal valorDoPedido = 0;

            foreach (Prato prato in pratosDoPedido)
            {
                valorDoPedido += prato.Preco;

            }
            return valorDoPedido;
        }

    }
}
