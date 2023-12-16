﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private Reservas _reservaMesa;

        internal int Numero
        {
            get { return _numero; }
        }
        internal int Capacidade
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
        public Reservas Reservas { get { return _reservaMesa; } }

        public Mesa(int numero, int capacidade)
        {
            this._numero = numero;
            this._capacidade = capacidade;
            this._statusMesa = StatusMesaEnum.Disponivel;
        }

        public void Reservar(DateTime dataReserva, string cpf, char turno)
        {
            this._reservaMesa = new Reservas(dataReserva, cpf, turno);
            _statusMesa = StatusMesaEnum.Reservado;
        }
        public bool MesaReservada(DateTime dataReserva, string cpf, char turno)
        {
            if (_reservaMesa.DataReserva == dataReserva && _reservaMesa.CpfCliente == cpf && _reservaMesa.Turno == turno)
            {
                AbrirConta();
                return true; ;
            }
            else
            {
                return false;
            }
        }
        public void PedirConta()
        {
            _contaMesa.ExibirDetalhes();
            _contaMesa.Pagar();
            _statusMesa = StatusMesaEnum.Disponivel;
        }
        public void FazerPedido(int indice)
        {
            var pedido = new Pedido(Cardapio.SelecionarPrato(indice));
            _contaMesa.AdicionarPedido(pedido);
        }

        public void AbrirConta()
        {
            _statusMesa = StatusMesaEnum.Ocupada;
            this._contaMesa = new Conta();
        }
    }
}
