

namespace ProjetoRestauranteUsuario.Models.Usuarios.AcervoUsuarios
{
    using ProjetoRestauranteUsuario.Enums;
    using ReceivingData;
    internal class FuncionarioData
    {
        private static List<Funcionario> _funcionarios = new List<Funcionario>
        {
            new Funcionario("João Silva", 1, CargoFuncionario.Gerente, "joao_silva", "senha123"),
            new Funcionario("Maria Oliveira", 2, CargoFuncionario.Recepcionista, "maria_oliveira", "senha456"),
            new Funcionario("Carlos Santos", 3, CargoFuncionario.Chefe, "carlos_santos", "senha789"),
            new Funcionario("Fernanda Costa", 4, CargoFuncionario.Garçom, "fernanda_costa", "senhaabc"),
            new Funcionario("Ricardo Pereira", 5, CargoFuncionario.Recepcionista, "ricardo_pereira", "senhadef"),
            new Funcionario("Patrícia Lima", 6, CargoFuncionario.Garçom, "patricia_lima", "senhaghi"),
            new Funcionario("André Almeida", 7, CargoFuncionario.Cozinheiro, "andre_almeida", "senhajkl"),
            new Funcionario("Laura Sousa", 8, CargoFuncionario.Garçom, "laura_sousa", "senha123mno"),
            new Funcionario("Roberto Fernandes", 9, CargoFuncionario.Garçom, "roberto_fernandes", "senha456pqr"),
            new Funcionario("Isabel Santos", 10, CargoFuncionario.Cozinheiro, "isabel_santos", "senha789stu"),
        };

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
            }
            else
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
                        Console.WriteLine(funcionario.Login);
                    }

                    Console.WriteLine("\nPressione Enter para voltar ao menu principal...");
                    teclaUsuario = Console.ReadKey();
                } while (teclaUsuario.Key != ConsoleKey.Enter);
            }
        }
    }
}
