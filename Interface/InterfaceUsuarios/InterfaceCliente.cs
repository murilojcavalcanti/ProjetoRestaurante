using ProjetoRestauranteUsuario.Interface.InterfaceBusiness;
using ProjetoRestauranteUsuario.Models.Business;
using ProjetoRestauranteUsuario.Models.CardapioBistro;

namespace ProjetoRestauranteUsuario.Interface.InterfaceUsuarios
{
    internal class InterfaceCliente
    {
        public static void ExibirMenuCliente()
        {
            bool sair = false;

            do
            {
                Console.Clear();
                Console.WriteLine("Escolha uma das opções abaixo para começar:\n");

                string[] opcoesUsuario = { "1. Desejo fazer uma reserva", "2. Já possuo reserva", "3. Ver cardápio", "4. Ver mesas disponíveis.", "5. Sair" };

                var menuPrincipal = new ConsoleMenu<string>(opcoesUsuario);
                int selecaoUsuario = menuPrincipal.ShowMenu();

                switch (selecaoUsuario)
                {
                    case 0:
                        InterfaceReserva.FazerReserva(MesaData.BuscarMesa(InterfaceMesa.SelecionarMesa() + 1));
                        break;
                    case 1:
                        InterfaceReserva.TemReserva();
                        break;
                    case 2:
                        MostrarCardapio();
                        break;
                    case 3:
                        MesaData.ExibirMesasDisponiveis();
                        break;
                    case 4:
                        sair = true;
                        break;
                }

            } while (!sair);
        }

        public static void MostrarCardapio()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Veja as opções em nosso cardápio:");
                string[] opcoesUsuario = { "1. Visualizar cardápio de pratos", "2. Visualizar cardápio de bebidas", "3. Voltar ao menu principal" };

                var opcoes = new ConsoleMenu<string>(opcoesUsuario);
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
                        return;
                }

                Console.WriteLine("Pressione Enter para continuar...");
                Console.ReadLine();
            }
        }
    }
}
