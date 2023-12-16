namespace ProjetoRestauranteUsuario.Models
{
    using Enums;
    internal class Funcionario : Usuario
    {
        private CargoFuncionario _cargo;

        internal Funcionario(string nome, int id, CargoFuncionario cargo) 
            : base(nome, id)
        {
           this.nome = nome;
           this.id = id;
           this._cargo = cargo;
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
