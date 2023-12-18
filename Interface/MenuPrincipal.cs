using Figgle;
using ProjetoRestauranteUsuario.Interface.Metodos;
using ProjetoRestauranteUsuario.Models;
using ProjetoRestauranteUsuario.Models.CardapioBistro;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRestauranteUsuario.Interface
{
    internal class MenuPrincipal
    {
        public static void ExibirMenu()
        {
            bool sair = false;

            do
            {
                Console.Clear();           
                Console.WriteLine("Escolha uma das opções abaixo para começar:\n");


                string[] opcoesUsuario = { "1. Desejo fazer uma reserva", "2. Já possuo reserva", "3. Ver cardápio", "4. Mais informações", "5. Sair" };

                var menuPrincipal = new ConsoleMenu(opcoesUsuario);
                int selecaoUsuario = menuPrincipal.ShowMenu();
                switch (selecaoUsuario)
                {
                    case 0:
                        InterfaceReserva.FazerReserva();
                        break;
                    case 1:
                        InterfaceReserva.TemReserva();
                        break;
                    case 2:
                        MostrarCardapio();
                        break;
                    case 3:
                        InfoRestaurante.Restaurante();
                        break;
                    case 4:
                        sair = true;
                        break;
                }

                Console.WriteLine("Pressione Enter para continuar...");
                Console.ReadLine();

            } while (!sair);
        }

        public static void MostrarCardapio()
        {           
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Veja as opções em nosso cardápio:");
                string[] opcoesUsuario = { "1. Visualizar cardápio de pratos", "2. Visualizar cardápio de bebidas", "3. Voltar ao menu principal" };

                var opcoes = new ConsoleMenu(opcoesUsuario);
                int selecaoUsuario = opcoes.ShowMenu();
                switch (selecaoUsuario)
                {
                    case 0:
                        CardapioPratos.ExibirItens();
                        break;
                    case 1:
                        CardapioBebidas.ExibirItens();
                        break;
                    case 2:
                        ExibirMenu();
                        break;
                }

                Console.WriteLine("Pressione Enter para continuar...");
                Console.ReadLine();

            } 
        }
    }
}
