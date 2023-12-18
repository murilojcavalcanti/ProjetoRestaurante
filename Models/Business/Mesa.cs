
namespace ProjetoRestauranteUsuario.Models.Business
{
    using Enums;
    using CardapioBistro;

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
                _reservaMesa = new Reservas(dataReserva, cpf, turno);
                _statusMesa = StatusMesaEnum.Reservado;
            }
            else
            {
                Console.WriteLine($"A mesa não comporta {limitePessoas} pessoas");
            }
        }
        internal bool MesaReservada(DateTime dataReserva, string cpf, char turno)
        {
            return _reservaMesa.ConfirmacaoReserva(dataReserva, cpf, turno);
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

        internal void PedirConta()
        {
            _contaMesa.ExibirDetalhes();
            _contaMesa.Pagar();
            _statusMesa = StatusMesaEnum.Disponivel;
        }
        internal void FazerPedido(int indice)
        {
            var pedido = new Pedido(CardapioPratos.SelecionarItem(indice));
            _contaMesa.AdicionarPedido(pedido);
        }

        internal void AbrirConta()
        {
            _statusMesa = StatusMesaEnum.Ocupada;
            _contaMesa = new Conta();
        }
    }
}
