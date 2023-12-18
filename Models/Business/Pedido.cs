
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

        internal Pedido(Bebida pedido)
        {
            bebidasDoPedido.Add(pedido);
        }
    }
}
