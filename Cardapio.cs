using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRestauranteUsuario
{
    public static class Cardapio
    {
        private static List<Alimento> cardapioCompleto = new List<Alimento>()
        {
            new Alimento("Lasanha", 15.99, "Massa com molho de tomate, queijo e carne."),
            new Alimento("Sushi", 22.50, "Arroz temperado com peixe cru e algas."),
            new Alimento("Pizza Margherita", 12.50, "Pizza com molho de tomate, mussarela e manjericão."),
            new Alimento("Hambúrguer", 9.99, "Pão, carne, queijo, alface, tomate e molhos."),
            new Alimento("Salada Caesar", 8.75, "Alface, croutons, queijo parmesão e molho Caesar."),
            new Alimento("Tacos", 11.25, "Tortillas com carne, queijo, alface e molhos."),
            new Alimento("Risoto de Cogumelos", 14.20, "Arroz cremoso com cogumelos e queijo parmesão."),
            new Alimento("Frango Assado", 13.45, "Frango temperado e assado no forno."),
            new Alimento("Massa Carbonara", 16.30, "Espaguete com molho à base de ovos, queijo e bacon."),
            new Alimento("Churrasco", 18.75, "Carnes grelhadas, como picanha, linguiça e frango.")
        };

       
        public static void mostrarCardapio()
        {
            string[] nomesPratos = cardapioCompleto.Select(alimento => alimento.nome).ToArray();
            ConsoleMenuUsuario menuCardapio = new ConsoleMenuUsuario(nomesPratos);
            menuCardapio.ShowMenu();
        }

        public static void addAlimento(Alimento alimento)
        {
            cardapioCompleto.Add(alimento);
        }

        public static void removerAlimento(Alimento alimento)
        {
            cardapioCompleto.Remove(alimento);
        }


    }
}
