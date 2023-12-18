using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRestauranteUsuario.Models.CardapioBistro
{

    using Interface;
    using ProjetoRestauranteUsuario.Models.AlimentosBistro;
    using ProjetoRestauranteUsuario.ReceivingData;
    using AlimentosBistro;

    internal abstract class CardapioBase<T> where T : Alimento
    {
        protected static List<T> cardapioCompleto;

        internal static int MostrarCardapio()
        {
            string[] nomesItens = cardapioCompleto.Select(item => item.Nome).ToArray();
            ConsoleMenu menuCardapio = new ConsoleMenu(nomesItens);
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

        internal static T SelecionarItem(int indice)
        {
            return cardapioCompleto[indice];
        }

        internal static void ExibirItens()
        {
            ConsoleKeyInfo teclaUsuario;
            do
            {
                foreach (T item in cardapioCompleto)
                {
                    Console.WriteLine(item.ToString());
                }

                Console.WriteLine("\nPressione Enter para voltar ao menu principal...");
                teclaUsuario = Console.ReadKey();
            } while (teclaUsuario.Key != ConsoleKey.Enter);
        }
    }
}