using Newtonsoft.Json;


namespace ProjetoRestauranteUsuario.ReceivingData
{
    internal static class ReceiveData
    {
        internal static void RecebeArquivos<T>(List<T> ListaGenerica, string Caminho)
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
