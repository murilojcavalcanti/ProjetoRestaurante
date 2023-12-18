using Newtonsoft.Json;

namespace ProjetoRestauranteUsuario.Models.Usuarios
{
    using Enums;

    internal class Funcionario : Usuario
    {
        private CargoFuncionario cargo;
        private string login;
        private string senha;

        internal CargoFuncionario Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        internal string Login
        {
            get { return login; }
            set { login = value; }
        }

        internal string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        [JsonConstructor]
        internal Funcionario(string nome, int id, CargoFuncionario cargo, string login, string senha)
        : base(nome, id)
        {
            this.cargo = cargo;
            this.login = login;
            this.senha = senha;
        }

        //internal void AbrirConta(Mesa mesa)
        //{
        //    mesa.Conta(new Conta());
        //}

        //internal void FecharConta(Mesa mesa)
        //{
        //    mesa.Conta.FecharConta();
        //}
    }
}
