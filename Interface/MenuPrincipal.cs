
namespace ProjetoRestauranteUsuario.Interface
{
    using Interface.Metodos;
    using Models.CardapioBistro;
    using Interface.InterfaceUsuarios;

    internal class MenuPrincipal
    {
        internal static void SelecionarUsuario()
        {
            bool sair = false;

            do
            {
                Console.Clear();
                Console.WriteLine("Escolha uma das opções abaixo para começar:\n");

                string[] opcoesUsuario = { "1. Sou cliente", "2. Sou funcionário", "3. Sair" };

                var menuPrincipal = new ConsoleMenu<string>(opcoesUsuario);
                int selecaoUsuario = menuPrincipal.ShowMenu();
                switch (selecaoUsuario)
                {
                    case 0:
                        InterfaceCliente.ExibirMenuCliente();
                        break;
                    case 1:
                        //InterfaceFuncionario.LogarSistemas();
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
