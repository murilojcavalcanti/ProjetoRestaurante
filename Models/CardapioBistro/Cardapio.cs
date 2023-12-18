using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRestauranteUsuario.Models.CardapioBistro
{

    using Interface;
    using ProjetoRestauranteUsuario.ReceivingData;

    internal abstract class CardapioBase<T> where T : Alimento
    {
        protected List<T> cardapioCompleto;

        internal int MostrarCardapio()
        {
            string[] nomesItens = cardapioCompleto.Select(item => item.Nome).ToArray();
            ConsoleMenu menuCardapio = new ConsoleMenu(nomesItens);
            return menuCardapio.ShowMenu();
        }

        internal void AdicionarItem(T item)
        {
            cardapioCompleto.Add(item);
        }

        internal void RemoverItem(T item)
        {
            cardapioCompleto.Remove(item);
        }

        internal T SelecionarItem(int indice)
        {
            return cardapioCompleto[indice];
        }

        internal void ExibirItens()
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