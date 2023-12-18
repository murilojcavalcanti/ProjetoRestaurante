namespace ProjetoRestauranteUsuario.Models.Usuarios
{
    using Enums;
    using Business;

    internal class Funcionario : Usuario
    {
        private CargoFuncionario _cargo;
        private string _login;
        private string _senha;

        internal CargoFuncionario Cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }

        internal string Login
        {
            get { return _login; }
            set { _login = value; }
        }

        internal string Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }

        internal Funcionario() : base("", 0) { }

        internal Funcionario(string nome, int id, CargoFuncionario cargo, string login, string senha, string confSenha)
            : base(nome, id)
        {
            if (senha != confSenha)
            {
                throw new Exception("As senhas não conferem.");
            }
            this.nome = nome;
            this.id = id;
            _cargo = cargo;
            _login = login;
            _senha = senha;
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
