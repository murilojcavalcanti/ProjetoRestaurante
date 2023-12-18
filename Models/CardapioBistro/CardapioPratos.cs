using ProjetoRestauranteUsuario.Models.AlimentosBistro;

namespace ProjetoRestauranteUsuario.Models.CardapioBistro
{
    internal class CardapioPratos : CardapioBase<Prato>
    {
        internal CardapioPratos()
        {
            cardapioCompleto = new List<Prato>();
        }

        internal static Prato SelecionarItem(int indice)
        {
            return cardapioCompleto[indice];
        }
    }
}
