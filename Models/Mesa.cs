using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ProjetoRestauranteUsuario.Enums;

namespace ProjetoRestauranteUsuario.Models
{
    internal class Mesa
    {
        private readonly int _numero;
        private int _capacidade;
        private StatusMesaEnum _statusMesa;
        private Conta _contaMesa;
        private Cardapio _numeroNoCardapio;

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
        public Cardapio Cardapio { get { return _numeroNoCardapio; } }

        public Mesa(int numero, int capacidade)
        {
            this._numero = numero;
            this._capacidade = capacidade;
            this._statusMesa = StatusMesaEnum.Disponivel;
            this._contaMesa = new Conta();
        }

        public void reservar()
        {
            _statusMesa = StatusMesaEnum.Reservado;
        }
        public decimal pedirConta()
        {
            _contaMesa.ExibirDetalhes();
            _contaMesa.Pagar();
        }
        public void fazerPedido(int numeroPedido)
        {
            _contaMesa.AdicionarPedido(_numeroNoCardapio.SelecionarPrato(numeroPedido));
        }
    }
}
