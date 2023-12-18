
namespace ProjetoRestauranteUsuario.Models.Business
{
    using ProjetoRestauranteUsuario.Enums;
    using ReceivingData;

    internal class MesaData
    {
        private static List<Mesa> _mesas = new List<Mesa>();

        internal List<Mesa> Mesas
        {
            get { return _mesas; }
            set { _mesas = value; }
        }

        internal static void AdicionarMesa(Mesa mesa)
        {
            _mesas.Add(mesa);
        }

        internal static Mesa BuscarMesa(int numero)
        {
            return _mesas.FirstOrDefault(m => m.Numero == numero);
        }

        internal static void RemoverMesa(int numero)
        {
            _mesas.Remove(BuscarMesa(numero));
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

        internal static void ExibirMesas(StatusMesaEnum? statusMesaFiltro = null)
        {
            //var mesasFiltradas = _mesas.Where(mesa => statusMesaFiltro == null || mesa.StatusMesa == statusMesaFiltro);

            //return mesasFiltradas.Select(mesa =>
            //    $"Mesa {mesa.Numero.ToString("D2")} - {mesa.Capacidade} pessoa{(mesa.Capacidade != 1 ? "s" : "")}")
            //    .ToArray();
            foreach (var mesa in _mesas)
            {
                if (statusMesaFiltro == null || mesa.StatusMesa == statusMesaFiltro)
                {
                    Console.WriteLine($"Mesa {mesa.Numero} - {mesa.Capacidade}");
                }
            }
        }

        internal static void RecebeJson(string caminho)
        {
            ReceiveData.RecebeArquivos<Mesa>(_mesas, caminho);
        }


    }
}
