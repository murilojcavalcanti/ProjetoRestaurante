
namespace ProjetoRestauranteUsuario.Interface.InterfaceUsuarios
{
    internal class InterfaceFuncionario
    {
        internal static void LogarSistema ()
        {
            Console.WriteLine("Digite seu login: ");
            string login = Console.ReadLine();
            Console.WriteLine("Digite sua senha: ");
            string senha = Console.ReadLine();
            if (login == "admin" && senha == "admin")
            {
                Console.WriteLine("Login efetuado com sucesso!");
                Console.WriteLine("Pressione Enter para continuar...");
                Console.ReadLine();
                InterfaceFuncionario.ExibirMenuFuncionario();
            }
            else
            {
                Console.WriteLine("Login ou senha incorretos!");
                Console.WriteLine("Pressione Enter para continuar...");
                Console.ReadLine();
                InterfaceFuncionario.LogarSistema();
            }
        }

        private static void ExibirMenuFuncionario()
        {
            bool sair = false;

            do
            {
                Console.Clear();
                Console.WriteLine("Escolha uma das opções abaixo para começar:\n");
            } while (!sair);
        }

    }
}
