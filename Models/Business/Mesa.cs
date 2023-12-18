
namespace ProjetoRestauranteUsuario.Models.Business
{
    using Enums;

    internal class Mesa
    {
        private readonly int _numero;
        private int _capacidade;
        private StatusMesaEnum _statusMesa;
        private Conta _contaMesa;
        private Reservas _reservaMesa;

        public Mesa(int numero, int capacidade)
        {
            _numero = numero;
            _capacidade = capacidade;
            _statusMesa = StatusMesaEnum.Disponivel;

        }
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
        internal Conta Conta 
        { 
            get { return _contaMesa; }
            set { _contaMesa = value; }
        }

        internal Reservas Reservas { get { return _reservaMesa; } }

        internal void Reservar(DateTime dataReserva, string cpf, char turno, int limitePessoas)
        {
            if (_capacidade >= limitePessoas)
            {
                _reservaMesa = ReservaData.Reservar(dataReserva, cpf, turno, this);
                _statusMesa = StatusMesaEnum.Reservado;
            }
            else
            {
                throw new Exception("A mesa não comporta o número de pessoas informado.");
            }
        }
        
        internal void LiberarMesa()
        {
            _statusMesa = StatusMesaEnum.Disponivel;
        }
        internal void FecharConta()
        {
            _contaMesa.ExibirDetalhes();
            _contaMesa.Pagar();
            _statusMesa = StatusMesaEnum.Disponivel;
        }

        internal void AbrirConta()
        {
            _statusMesa = StatusMesaEnum.Ocupada;
            _contaMesa = new Conta();
        }
    }
}
