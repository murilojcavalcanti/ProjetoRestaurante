
namespace ProjetoRestauranteUsuario.Interface.InterfaceBusiness
{
    using Models.Business;

    internal class InterfaceMesa
    {
        internal static int SelecionarMesa()
        {
            var mesasDisponiveis = MesaData.RetornarMesasDisponiveis().ToArray();
            Console.WriteLine("Selecione uma mesa:");
            var opcoesMesa = new ConsoleMenu<string>(mesasDisponiveis);

            return opcoesMesa.ShowMenu();
        }
    }
}
