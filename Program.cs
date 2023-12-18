﻿using Figgle;
using ProjetoRestauranteUsuario.Interface;
using ProjetoRestauranteUsuario.Interface.Metodos;
using ProjetoRestauranteUsuario.Models.Business;
namespace ProjetoRestauranteUsuario
{

    public class Program
    {
        public static void Main(string[] args)
        {
            AtualizarDados.AtualizarMesas();
            MesaData.ExibirMesas();
            //AtualizarDados.AtualizarCardapio();
            //AtualizarDados.AtualizarFuncionarios();
            //AtualizarDados.AtualizarMesas();
            //Console.Clear();

            //ConsoleKeyInfo teclaUsuario;
            //do
            //{
            //    MostrarNomeRestaurante();
            //    Console.WriteLine("BEM VINDO AO RESTAURANTE GEEKS </BISTRÔ>" + "\nAperte Enter para começar");
            //    teclaUsuario = Console.ReadKey();
            //} while (teclaUsuario.Key != ConsoleKey.Enter);
            //MenuPrincipal.SelecionarUsuario();
        }
        public static void MostrarNomeRestaurante()
        {
            string nomeRestaurante = FiggleFonts.Standard.Render("Restaurante");
            Console.WriteLine(nomeRestaurante);
        }
    }
}