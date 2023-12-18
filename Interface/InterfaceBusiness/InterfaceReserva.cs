using ProjetoRestauranteUsuario.Models.Business;
using System.Globalization;

namespace ProjetoRestauranteUsuario.Interface.InterfaceBusiness
{
    internal class InterfaceReserva
    {
        public static void FazerReserva(Mesa mesa)
        {
            Console.WriteLine("Digite o seu CPF:");
            string cpf = Console.ReadLine();

            Console.WriteLine("Digite a data da reserva (no formato dd/MM/yyyy):");
            if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataReserva))
            {
                Console.WriteLine("Digite o turno da reserva (M para manhã, T para tarde, N para noite):");
                char turno = char.ToUpper(Console.ReadKey().KeyChar);

                MesaData.Reservar(mesa.Numero, dataReserva, cpf, turno, 4);
            }
            else
            {
                Console.WriteLine("Formato de data inválido.");
            }
        }

        public static void TemReserva()
        {
            bool sair = false;

            do
            {
                Console.Clear();

                Console.WriteLine("Gostaria de fazer seu pedido?" + "Veja as opções em nosso cardápio:");
                string[] opcoesUsuario = { "1. Visualizar cardápio de pratos", "2. Visualizar cardápio de bebidas", "3. Sair" };

                var opcoes = new ConsoleMenu<string>(opcoesUsuario);
                int selecaoUsuario = opcoes.ShowMenu();
                switch (selecaoUsuario)
                {
                    case 0:
                        InterfaceCardápio.CardapioRefeicoes();
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
