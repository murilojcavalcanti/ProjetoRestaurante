namespace ProjetoRestauranteUsuario.Models.Usuarios
{
    using Enums;
    using Business;

    internal class Funcionario : Usuario
    {
        private CargoFuncionario _cargo;

        internal Funcionario(string nome, int id, CargoFuncionario cargo)
            : base(nome, id)
        {
            this.nome = nome;
            this.id = id;
            _cargo = cargo;
        }

        internal void AbrirConta(Mesa mesa)
        {
            mesa.Conta(new Conta());
        }

        internal void FecharConta(Mesa mesa)
        {
            mesa.Conta.FecharConta();
        }
    }
}
