using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRestauranteUsuario
{

    using Interface;
    using ProjetoRestauranteUsuario.ReceivingData;
    using System.Text.Json;
    using Newtonsoft.Json;
    using System.Text.Json;
    using System.Text.Json;
    using System.Globalization;

    internal static class Cardapio
    {
        private static List<Prato> cardapioCompleto = new List<Prato>()
        {
            new Prato("Lasanha", 15.99m, "Massa com molho de tomate, queijo e carne."),
            new Prato("Sushi", 22.50m, "Arroz temperado com peixe cru e algas."),
            new Prato("Pizza Margherita", 12.50m, "Pizza com molho de tomate, mussarela e manjericão."),
            new Prato("Hambúrguer", 9.99m, "Pão, carne, queijo, alface, tomate e molhos."),
            new Prato("Salada Caesar", 8.75m, "Alface, croutons, queijo parmesão e molho Caesar."),
            new Prato("Tacos", 11.25m, "Tortillas com carne, queijo, alface e molhos."),
            new Prato("Risoto de Cogumelos", 14.20m, "Arroz cremoso com cogumelos e queijo parmesão."),
            new Prato("Frango Assado", 13.45m, "Frango temperado e assado no forno."),
            new Prato("Massa Carbonara", 16.30m, "Espaguete com molho à base de ovos, queijo e bacon."),
            new Prato("Churrasco", 18.75m, "Carnes grelhadas, como picanha, linguiça e frango.")
        };

       
        internal static int mostrarCardapio()
        {
            string[] nomesPratos = cardapioCompleto.Select(prato => prato.Nome).ToArray();
            ConsoleMenu menuCardapio = new ConsoleMenu(nomesPratos);
            return menuCardapio.ShowMenu();
        }

        internal static void addAlimento(Prato prato)
        {
            cardapioCompleto.Add(prato);
        }

        internal static void removerAlimento(Prato prato)
        {
            cardapioCompleto.Remove(prato);
        }
        internal static void RecebeJson(string caminho)
        {

            ReceiveData.RecebeArquivoClientes(cardapioCompleto,caminho);

              
        }

        internal static Prato SelecionarPrato (int indice)
        {
            return cardapioCompleto[indice];
        }

        internal static void ApenasExibirPratos()
        {
            ConsoleKeyInfo teclaUsuario;
            do
            {
                Console.WriteLine($"{cardapioCompleto}\n"+"\nPressione Enter para voltar ao menu principal...");
                teclaUsuario = Console.ReadKey();
            } while(teclaUsuario.Key != ConsoleKey.Enter);
            
        }

        internal static void ApenasExibirBebidas()
        {
            ConsoleKeyInfo teclaUsuario;
            do
            {
                Console.WriteLine($"!!!!CARDAPIO DE BEIBDAS AQUI!!!!\n" + "\nPressione Enter para voltar ao menu principal...");
                teclaUsuario = Console.ReadKey();
            } while (teclaUsuario.Key != ConsoleKey.Enter);
        }
    }
}
