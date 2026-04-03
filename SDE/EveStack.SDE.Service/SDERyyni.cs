
using EveStack.SDE.Kontrakti;

using System.Text.Json;

namespace EveStack.SDE.Service
{
    sealed class SDERyyni([PersistentState("state")] IPersistentState<SDERyyni.SdePakkaus> state) : Grain, ISDERyyni
    {
        private string? perusPath = "developers.eveonline.com/static-data/tranquility/";
        private string? uusingbuildiurli;
        private string? dataJsonlUrli;
        private StaattinenData? sde;
        private List<StaattinenData>? tiedot;
        private  DataFormaatti formaatti;
        private string? dataYamlurl;
        private int buildiNro;

        public string? Uusingbuildiurli { get => uusingbuildiurli; set => uusingbuildiurli = value; }
        public string? DataJsonlUrli { get => dataJsonlUrli; set => dataJsonlUrli = value; }
        public string? DataYamlurl { get => dataYamlurl; set => dataYamlurl = value; }

        
        
        internal class SdePakkaus
        {
            string avain;
            string arvo;
            Dictionary<string, string> keyValuePairs;
        }
       
        Task ISDERyyni.HaeUusiBuildi()
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            return Task.CompletedTask;
        }

       

        async Task<List<SDEJsonLines>> ISDERyyni.LueJsonRivit(string uusinBuildinro)
        {
            var tulos = new List<SDEJsonLines>();

            using (StreamReader reader = new StreamReader(uusinBuildinro))
            {
                string line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                   SDEJsonLines obj = JsonSerializer.Deserialize<SDEJsonLines>(line);
                    tulos.Add(obj);
                }
            }

            return tulos;
        }
    }
}
