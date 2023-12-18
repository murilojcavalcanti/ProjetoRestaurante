using Figgle;
using ProjetoRestauranteUsuario.Interface;
namespace ProjetoRestauranteUsuario
{

    public class Program
    {
        public static void Main(string[] args)
        {
            ConsoleKeyInfo teclaUsuario;
            do
            {
                MostrarNomeRestaurante();
                Console.WriteLine("BEM VINDO AO RESTAURANTE GEEKS </BISTRÔ>" + "\nAperte Enter para começar");
                teclaUsuario = Console.ReadKey();
            } while (teclaUsuario.Key != ConsoleKey.Enter);
            MenuPrincipal.ExibirMenu();
        }
        public static void MostrarNomeRestaurante()
        {
            string nomeRestaurante = FiggleFonts.Standard.Render("Restaurante");
            Console.WriteLine(nomeRestaurante);
        }
    }
}