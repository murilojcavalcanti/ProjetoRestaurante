
namespace ProjetoRestauranteUsuario.Models.Business
{
    internal class ReservaData
    {
        private static List<Reservas> _reservas = new List<Reservas>();

        internal List<Reservas> Reservas
        {
            get { return _reservas; }
            set { _reservas = value; }
        }

        internal static Reservas Reservar(DateTime dataReserva, string cpf, char turno, Mesa mesa)
        {
            if (VerificarReserva(cpf) != false)
            {
                throw new Exception("O CPF informado já possui uma reserva.");
            }
            var reserva = new Reservas(dataReserva, cpf, turno, mesa);
            _reservas.Add(reserva);
            return reserva;
        }

        internal static bool VerificarReserva(string cpf)
        {
            var reservaEncontrada = _reservas.FirstOrDefault(reserva => reserva.CpfCliente == cpf);

            if (reservaEncontrada != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal static Reservas SelecionarReserva(string cpf)
        {
            return _reservas.FirstOrDefault(reserva => reserva.CpfCliente == cpf);
        }

    }
}
