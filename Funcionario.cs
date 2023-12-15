
namespace ProjetoRestauranteUsuario
{
    using Enums;
    internal class Funcionario
    {
        private readonly int _matricula;
        private CargoFuncionario _cargo;
        private readonly string _nome;

        internal Funcionario (int matricula, CargoFuncionario cargo, string nome)
        {
            _matricula = matricula;
            _cargo = cargo;
            _nome = nome;
        }

        //internal void AbrirPedido (Mesa mesa)
        //{
        //   //var conta = new Conta (string nome, double preco, string descricao)
            //mesa.Conta(conta);       
        //}

        //internal void FecharConta (Mesa mesa)
        //{
        //    mesa.Conta.FecharConta();
        //}
    }
}
