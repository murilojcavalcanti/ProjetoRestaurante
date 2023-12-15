using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRestauranteUsuario
{
    public static class Cardapio
    {
        private static List<Prato> cardapioCompleto = new List<Prato>()
        {
            new Prato("Lasanha", 15.99, "Massa com molho de tomate, queijo e carne."),
            new Prato("Sushi", 22.50, "Arroz temperado com peixe cru e algas."),
            new Prato("Pizza Margherita", 12.50, "Pizza com molho de tomate, mussarela e manjericão."),
            new Prato("Hambúrguer", 9.99, "Pão, carne, queijo, alface, tomate e molhos."),
            new Prato("Salada Caesar", 8.75, "Alface, croutons, queijo parmesão e molho Caesar."),
            new Prato("Tacos", 11.25, "Tortillas com carne, queijo, alface e molhos."),
            new Prato("Risoto de Cogumelos", 14.20, "Arroz cremoso com cogumelos e queijo parmesão."),
            new Prato("Frango Assado", 13.45, "Frango temperado e assado no forno."),
            new Prato("Massa Carbonara", 16.30, "Espaguete com molho à base de ovos, queijo e bacon."),
            new Prato("Churrasco", 18.75, "Carnes grelhadas, como picanha, linguiça e frango.")
        };

       
        public static void mostrarCardapio()
        {
            string[] nomesPratos = cardapioCompleto.Select(prato => prato.nome).ToArray();
            ConsoleMenuUsuario menuCardapio = new ConsoleMenuUsuario(nomesPratos);
            menuCardapio.ShowMenu();
        }

        public static void addAlimento(Prato prato)
        {
            cardapioCompleto.Add(prato);
        }

        public static void removerAlimento(Prato prato)
        {
            cardapioCompleto.Remove(prato);
        }


    }
}
