using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRestauranteUsuario.Interface.Metodos
{
    using Models.CardapioBistro;
    using Models.Usuarios.AcervoUsuarios;
    internal class AtualizarDados
    {
        public static void AtualizarCardapio()
        {
            Console.Clear();
            Console.WriteLine("Atualizando cardápio...");
            CardapioPratos.RecebeJson(@"../../../ReceivingData/pratos.json");
            CardapioBebidas.RecebeJson(@"../../../ReceivingData/bebidas.json");
            Console.WriteLine("Cardápio atualizado com sucesso!");
            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }

        internal static void AtualizarFuncionarios()
        {
            Console.Clear();
            Console.WriteLine("Atualizando funcionários...");
            FuncionarioData.RecebeJson(@"../../../ReceivingData/funcionarios.json");
            Console.WriteLine("Funcionários atualizados com sucesso!");
            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}
