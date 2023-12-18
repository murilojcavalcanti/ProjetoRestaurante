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
                Console.WriteLine("Formato de data inválido.\n");
                FazerReserva(mesa);
            }
        }

        public static void TemReserva()
        {
            bool sair = false;
            Console.WriteLine("Digite o seu CPF:");
            string cpf = Console.ReadLine();

            if (ReservaData.VerificarReserva(cpf))
            {
                var reserva = ReservaData.SelecionarReserva(cpf);
                InterfaceCardápio.AbrirConta(reserva);

                do
                {
                    Console.Clear();

                    Console.WriteLine("Gostaria de fazer seu pedido?" + "Veja as opções em nosso cardápio e selecione o que desejar:");
                    string[] opcoesUsuario = { "1. Cardápio de pratos", "2. Cardápio de bebidas", "3. Sair" };

                    var opcoes = new ConsoleMenu<string>(opcoesUsuario);
                    int selecaoUsuario = opcoes.ShowMenu();
                    switch (selecaoUsuario)
                    {
                        case 0:
                            InterfaceCardápio.CardapioPratosRestaurante(reserva);
                            break;
                        case 1:
                            InterfaceCardápio.CardapioBebidasRestaurante(reserva);
                            break;
                        case 2:
                            sair = true;
                            reserva.Mesa.FecharConta();
                            break;
                    }
                } while (!sair);
            } else
            {
                Console.WriteLine("Não há reserva para este CPF.");
            }
        }
    }

}
