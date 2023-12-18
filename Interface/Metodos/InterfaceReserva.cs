using ProjetoRestauranteUsuario.Models.Business;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRestauranteUsuario.Interface.Metodos
{
    internal class InterfaceReserva
    {
        public static bool FazerReserva()
        {
            Console.WriteLine("Digite o seu CPF:");
            string cpf = Console.ReadLine();

            Console.WriteLine("Digite a data da reserva (no formato dd/MM/yyyy):");
            if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataReserva))
            {
                Console.WriteLine("Digite o turno da reserva (M para manhã, T para tarde, N para noite):");
                char turno = char.ToUpper(Console.ReadKey().KeyChar);


                Reservas reserva = new Reservas(dataReserva, cpf, turno);

                if (reserva.ConfirmacaoReserva(dataReserva, cpf, turno))
                {
                    Console.WriteLine("Reserva confirmada!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Não foi possível confirmar a reserva.");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Formato de data inválido.");
                return false;
            }
        }

        public static void TemReserva()
        {
            bool sair = false;

            do
            {
                Console.Clear();

                Console.WriteLine("Gostaria de fazer seu pedido?"+"Veja as opções em nosso cardápio:");
                string[] opcoesUsuario = { "1. Visualizar cardápio de pratos", "2. Visualizar cardápio de bebidas", "3. Sair" };
                
                var opcoes = new ConsoleMenu(opcoesUsuario);
                int selecaoUsuario = opcoes.ShowMenu();
                switch (selecaoUsuario)
                {
                    case 0:
                        InterfaceCardápio.CardapioPratos();
                        break;
                    case 1:
                        InterfaceCardápio.CardapioBebidas();
                        break;
                    case 2:
                        sair = true;
                        break;
                }

                Console.WriteLine("Pressione Enter para continuar...");
                Console.ReadLine();

            } while (!sair);
        }
    }
    
}
