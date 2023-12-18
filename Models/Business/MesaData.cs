
namespace ProjetoRestauranteUsuario.Models.Business
{
    using ProjetoRestauranteUsuario.Enums;

    internal class MesaData
    {
        private static List<Mesa> _mesas = new List<Mesa>
        {
            new Mesa(1, 4),
            new Mesa(2, 6),
            new Mesa(3, 2),
            new Mesa(4, 8),
            new Mesa(5, 5),
            new Mesa(6, 3),
            new Mesa(7, 10),
            new Mesa(8, 4),
            new Mesa(9, 6),
            new Mesa(10, 7),
            new Mesa(11, 4),
            new Mesa(12, 6),
            new Mesa(13, 2),
            new Mesa(14, 8),
            new Mesa(15, 5),
            new Mesa(16, 3),
            new Mesa(17, 10),
            new Mesa(18, 4),
            new Mesa(19, 6),
            new Mesa(20, 7)
        };

        internal List<Mesa> Mesas
        {
            get { return _mesas; }
            set { _mesas = value; }
        }

        internal static Mesa BuscarMesa(int numero)
        {
            return _mesas.FirstOrDefault(m => m.Numero == numero);
        }

        internal static void AlterarMesa(int numero, int capacidade)
        {
            Mesa mesa = BuscarMesa(numero);
            mesa.Capacidade = capacidade;
        }

        internal static void AbrirConta(int numero)
        {
            Mesa mesa = BuscarMesa(numero);
            mesa.AbrirConta();
        }

        internal static void Reservar(int numero, DateTime dataReserva, string cpf, char turno, int limitePessoas)
        {
            Mesa mesa = BuscarMesa(numero);
            mesa.Reservar(dataReserva, cpf, turno, limitePessoas);
        }

        internal static void FecharConta(int numero)
        {
            Mesa mesa = BuscarMesa(numero);
            mesa.FecharConta();
        }

        internal static void LiberarMesa(int numero)
        {
            Mesa mesa = BuscarMesa(numero);
            mesa.LiberarMesa();
        }

        internal static void ExibirMesasDisponiveis()
        {
            Console.WriteLine("Mesas disponíveis:");
            foreach (Mesa mesa in _mesas)
            {
                if (mesa.StatusMesa == StatusMesaEnum.Disponivel)
                {
                    Console.WriteLine($"Mesa {mesa.Numero} - Capacidade: {mesa.Capacidade}");
                }
            }
        }

        internal static List<string> RetornarMesasDisponiveis()
        {
                        List<string> mesasDisponiveis = new List<string>();
            foreach (Mesa mesa in _mesas)
            {
                if (mesa.StatusMesa == StatusMesaEnum.Disponivel)
                {
                    mesasDisponiveis.Add($"Mesa {mesa.Numero} - Capacidade: {mesa.Capacidade}");
                }
            }
            return mesasDisponiveis;
        }
    }
}
