using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRestauranteUsuario.Interface.Metodos
{
    internal class CapacidadeMesa
    {
        internal static void ReservaMesa()
        {
            int quantidadePessoas = LerNumeroInt("Deseja mesa para quantas pessoas?", 1, 10);

            Console.WriteLine($"Você escolheu mesa para {quantidadePessoas} pessoas");
        }

        public static int LerNumeroInt(string prompt, int min, int max)
        {
            int numero;
            bool numValido = false;

            do
            {
                Console.Write($"\n{prompt} \n");
                numValido = int.TryParse(Console.ReadLine(), out numero);

                if (!numValido || numero <= min || numero >= max)
                {
                    Console.WriteLine("Você não digitou um número válido. Tente novamente.");
                }
            } while (!numValido || numero <= min || numero >= max);

            return numero;
        }

        //public static void RecepcionarCliente()
        //{
        //    do
        //    {
        //        Console.Clear();
        //        MostrarNomeRestaurante();
        //        Console.WriteLine("BEM VINDO AO RESTAURANTE SEM NOME");
        //        int quantidadePessoas = LerNumeroInt("Deseja mesa para quantas pessoas?", 1, 10);

        //        Console.WriteLine($"Você escolheu mesa para {quantidadePessoas} pessoas" +
        //            $"\n Digite 's' para confirmar ou qualquer tecla pra escolher novamente");
        //    } while (Console.ReadLine().ToLower() != "s");
        //}
    }
}
