using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRestauranteUsuario.Mesa
{
    internal class Mesa
    {
        private readonly int _numero;
        private int _capacidade;
        private StatusMesaEnum _statusMesa;
        private Conta _contaMesa;

        internal int Numero
        {
            get { return _numero; }
        }
        internal bool Capacidade
        {
            get { return _capacidade; }
            set { _capacidade = value; }
        }
        internal StatusMesaEnum StatusMesa
        {
            get { return _statusMesa; }
            set { _statusMesa = value; }
        }
        public Conta Conta { get { return _contaMesa; } }

        public void reservar()
        {
            _statusMesa = StatusMesaEnum.Reservado;
        }
        public decimal pedirConta()
        {
            _contaMesa.exibirDetalhes();
            _contaMesa.Pagar();
        }
        public void fazerPedido()
        {

        }
    }
}
