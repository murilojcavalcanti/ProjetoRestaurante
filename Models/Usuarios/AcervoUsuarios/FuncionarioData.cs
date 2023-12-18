

namespace ProjetoRestauranteUsuario.Models.Usuarios.AcervoUsuarios
{
    using ReceivingData;
    internal class FuncionarioData
    {
        private static List<Funcionario> _funcionarios = new List<Funcionario>();

        internal static void AdicionarFuncionario(Funcionario funcionarioGerente, Funcionario funcionario)
        {
            if (funcionarioGerente.Cargo != Enums.CargoFuncionario.Gerente)
            {
                throw new Exception("Você não tem permissão para adicionar funcionários.");
            }
            _funcionarios.Add(funcionario);
        }

        internal static void RemoverFuncionario(Funcionario funcionarioGerente, Funcionario funcionario)
        {
            if (funcionarioGerente.Cargo != Enums.CargoFuncionario.Gerente)
            {
                throw new Exception("Você não tem permissão para remover funcionários.");
            }
            _funcionarios.Remove(funcionario);
        }

        internal static Funcionario SelecionarFuncionario(int indice)
        {
            return _funcionarios[indice];
        }

        internal static void ExibirFuncionarios(Funcionario funcionarioGerente)
        {
            if (funcionarioGerente.Cargo != Enums.CargoFuncionario.Gerente)
            {
                throw new Exception("Você não tem permissão para exibir funcionários.");
            } else
            {
                if (_funcionarios.Count == 0)
                {
                    Console.WriteLine("Não há funcionários cadastrados.");
                    return;
                }
                ConsoleKeyInfo teclaUsuario;
                do
                {
                    foreach (Funcionario funcionario in _funcionarios)
                    {
                        Console.WriteLine(funcionario.ToString());
                    }

                    Console.WriteLine("\nPressione Enter para voltar ao menu principal...");
                    teclaUsuario = Console.ReadKey();
                } while (teclaUsuario.Key != ConsoleKey.Enter);
            }
        }

        internal static void RecebeJson(string caminho)
        {
            ReceiveData.RecebeArquivos<Funcionario>(_funcionarios, caminho);
        }
    }
}
