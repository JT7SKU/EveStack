
using EveStack.SDE.Kontrakti;

using System.Text.Json;

namespace EveStack.SDE.Service
{
    sealed class SDERyyni([PersistentState("state")] IPersistentState<SDERyyni.SdePakkaus>) : Grain, ISDERyyni
    {
        private string latestbuild = "developers.eveonline.com/static-data/tranquility/latest.jsonl";
        private StaattinenData sde;
        private List<StaattinenData> tiedot;
        internal class SdePakkaus
        {

        }
        public Task GetLatestBuild()
        {
            try
            {
                tiedot = LueJsonRivitAsync(latestbuild);
            }
            catch (Exception)
            {

                throw;
            }

            return Task.CompletedTask;
        }

        private static async Task<List<StaattinenData>> LueJsonRivitAsync(string latestbuild)
        {
            var tulos = new List<StaattinenData>();

            using (StreamReader reader = new StreamReader(latestbuild))
            {
                string line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    StaattinenData obj = JsonSerializer.Deserialize<StaattinenData>(line);
                    tulos.Add(obj);
                }
            }

            return tulos;
        }

        public Task HaeUusiBuildi()
        {
            throw new NotImplementedException();
        }

        public Task LueJsonRivit(string uusinBuildi)
        {
            throw new NotImplementedException();
        }
    }
}
