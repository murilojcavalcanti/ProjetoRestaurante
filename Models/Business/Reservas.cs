
namespace ProjetoRestauranteUsuario.Models.Business
{
    internal class Reservas
    {
        private string _cpfCliente;
        private DateTime _dataReserva;
        private char _turno;
        private Mesa _mesa;
        private bool _confirmacaoReserva;

        internal Mesa Mesa
        {
            get { return _mesa; }
            set { _mesa = value; }
        }

        internal string CpfCliente
        {
            get { return _cpfCliente; }
            set { _cpfCliente = value; }
        }

        internal char Turno
        {
            get { return _turno; }
            set { _turno = value; }
        }

        internal DateTime DataReserva
        {
            get { return _dataReserva; }
            set
            {
                if (value >= DateTime.Now)
                {
                    _dataReserva = value;
                    _confirmacaoReserva = true;
                }
                else
                {
                    Console.WriteLine("A data reservada não está disponível.");
                    _confirmacaoReserva = false;
                }
            }
        }

        internal Reservas(DateTime dataReserva, string cpf, char turno, Mesa mesa)
        {
            _dataReserva = dataReserva;
            _cpfCliente = cpf;
            _turno = turno;
            _confirmacaoReserva = true;
            _mesa = mesa;
        }

    }
}
