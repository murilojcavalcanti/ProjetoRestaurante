
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

        internal void AbrirPedido ()
        {

        }

        internal void EntregarPedido ()
        {

        }

        internal void FecharConta ()
        {

        }
    }
}
