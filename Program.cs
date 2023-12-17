using Figgle;
namespace ProjetoRestauranteUsuario
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //RecepcionarCliente();

            // CLIENTE CHEGA AO RESTAURANTE
            // CLIENTE É ALOCADO PRA UMA MESA
            // GARÇOM ATENDE O CLIENTE
            // CLIENTE SELECIONA O PRATO

            //Cardapio.mostrarCardapio();
            Console.WriteLine("Pratos adicionados");
            Cardapio.RecebeJson(@"../../../ReceivingData/pratos.json");
            Cardapio.mostrarCardapio();

        }

        public static void RecepcionarCliente()
        {
            do
            {
                Console.Clear();
                MostrarNomeRestaurante();
                Console.WriteLine("BEM VINDO AO RESTAURANTE SEM NOME");
                int quantidadePessoas = LerNumeroInt("Deseja mesa para quantas pessoas?", 1, 10);

                Console.WriteLine($"Você escolheu mesa para {quantidadePessoas} pessoas" +
                    $"\n Digite 's' para confirmar ou qualquer tecla pra escolher novamente");
            } while (Console.ReadLine().ToLower() != "s");

        }

        public static void MostrarNomeRestaurante()
        {
            string nomeRestaurante = FiggleFonts.Standard.Render("Restaurante");
            Console.WriteLine(nomeRestaurante);
        }



        // METODO PRA LER NUMERO INTEIRO, TIRAR DO MAIN DPS
        public static int LerNumeroInt(string prompt, int min, int max)
        {
            int numero;
            bool numValido = false;

            do
            {
                Console.Write($"\n{prompt} \n");
                numValido = int.TryParse(Console.ReadLine(), out numero);

                if (!numValido || numero <= min || numero >= max)
                {
                    Console.WriteLine("Você não digitou um número válido. Tente novamente.");
                }
            } while (!numValido || numero <= min || numero >= max);

            return numero;
        }


    }
}