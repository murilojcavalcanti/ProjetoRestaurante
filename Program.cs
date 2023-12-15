namespace ProjetoRestauranteUsuario
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Teste");
            string[] opcoes = { "testando opcoes", "testando opcoes 2" };
            var escolha = new ConsoleMenuUsuario(opcoes);
            Console.WriteLine(escolha.ShowMenu());
        }
    }
}