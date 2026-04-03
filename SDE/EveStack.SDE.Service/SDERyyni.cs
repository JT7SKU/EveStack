
using EveStack.SDE.Kontrakti;

using System.Text.Json;

namespace EveStack.SDE.Service
{
    sealed class SDERyyni([PersistentState("state")] IPersistentState<SDERyyni.SdePakkaus>) : Grain, ISDERyyni
    {
        private string? perusPath;
        private string? uusingbuildiurli;
        private string? dataJsonlUrli; 
        private StaattinenData? sde;
        private List<StaattinenData>? tiedot;
        private  DataFormaatti formaatti;
        private string? dataYamlurl;
        private int buildiNro;

        private SDERyyni()
        {
            this.perusPath = "developers.eveonline.com/static-data/tranquility/";
            this.uusingbuildiurli = $"{perusPath}latest.jsonl";
            this.dataJsonlUrli = $"{perusPath}eve-online-static-data-{buildiNro}-jsonl.zip";
            this.dataYamlurl = $"{perusPath}eve-online-static-data-{buildiNro}-yaml.zip";

        }
        
        internal class SdePakkaus
        {
            string avain;
            string arvo;
            Dictionary<string, string> keyValuePairs;
        }
        public Task GetLatestBuild()
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

       

        public Task HaeUusiBuildi()
        {
            throw new NotImplementedException();
        }

       

        async Task<List<object>> ISDERyyni.LueJsonRivit(string uusinBuildinro)
        {
            var tulos = new List<SdePakkaus>();

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
