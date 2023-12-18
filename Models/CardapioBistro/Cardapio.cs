
namespace ProjetoRestauranteUsuario.Models.CardapioBistro
{

    using Interface;
    using ProjetoRestauranteUsuario.Models.AlimentosBistro;
    using ProjetoRestauranteUsuario.Models.Business;
    using ProjetoRestauranteUsuario.ReceivingData;

    internal abstract class CardapioBase<T> where T : Alimento
    {
        protected static List<T> cardapioCompleto  = new List<T>();

        internal static int MostrarCardapio()
        {
            string[] itensFormatados = cardapioCompleto.Select(item => $"{item.Nome} - R${item.Preco:F2}").ToArray();

            var menuCardapio = new ConsoleMenu<string>(itensFormatados);
            return menuCardapio.ShowMenu();
        }

        internal static void AdicionarItem(T item)
        {
            cardapioCompleto.Add(item);
        }

        internal static void RemoverItem(T item)
        {
            cardapioCompleto.Remove(item);
        }

        internal static void ExibirItens()
        {
            ConsoleKeyInfo teclaUsuario;
            do
            {
                foreach (T item in cardapioCompleto)
                {
                    Console.WriteLine(item.Nome);
                }

                Console.WriteLine("\nPressione Enter para voltar ao menu principal...");
                teclaUsuario = Console.ReadKey();
            } while (teclaUsuario.Key != ConsoleKey.Enter);
        }

        internal static void RecebeJson(string caminho)
        {
            ReceiveData.RecebeArquivos<T>(cardapioCompleto, caminho);
        }

    }
}