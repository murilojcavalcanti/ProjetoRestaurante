using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRestauranteUsuario.Models
{
    internal class Reservas
    {
        private string _cpfCliente;
        private DateTime _dataReserva;
        private char _turno;
        private bool _confirmacaoReserva;


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

        internal Reservas(DateTime dataReserva, string cpf, char turno)
        {
            this._dataReserva = dataReserva;
            this._cpfCliente = cpf;
            this._turno = turno;
            this._confirmacaoReserva = true;
        }

        internal bool ConfirmacaoReserva(DateTime dataReserva, string cpf, char turno)
        {
            if (_dataReserva == dataReserva && _cpfCliente == cpf && _turno == turno)
            {
                return true; ;
            }
            else
            {
                return false;
            }
        }
    }
}
