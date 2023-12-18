
namespace ProjetoRestauranteUsuario.Models.Usuarios
{
    internal abstract class Usuario
    {
        protected string nome;
        protected int id;

        internal Usuario(string nome, int id)
        {
            this.nome = nome;
            this.id = id;
        }
    }
}
