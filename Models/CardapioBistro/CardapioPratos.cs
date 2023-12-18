using ProjetoRestauranteUsuario.Models.AlimentosBistro;

namespace ProjetoRestauranteUsuario.Models.CardapioBistro
{
    internal class CardapioPratos : CardapioBase<Prato>
    {
        internal CardapioPratos()
        {
            cardapioCompleto = new List<Prato>
            {
                new Prato("Lasanha", 15.99m, "Massa com molho de tomate, queijo e carne."),
                // Adicione outros pratos conforme necessário
            };
        }
    }
}
