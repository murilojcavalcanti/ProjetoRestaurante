using Newtonsoft.Json;
using ProjetoRestauranteUsuario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProjetoRestauranteUsuario.ReceivingData
{
    internal static class ReceiveData
    {
        internal static void RecebeArquivoClientes<T>(List<T> ListaGenerica, string Caminho)
        {
            List<T> ListaDados = new List<T>();

            using (StreamReader stream = new StreamReader(Caminho))
            {
                string jsonString = stream.ReadToEnd();
                ListaDados = JsonConvert.DeserializeObject<List<T>>(jsonString);
            }

            foreach (var item in ListaDados)
            {
                ListaGenerica.Add(item);
            }
        }
    }
}
