
using System.Text.Json;

namespace EveStack.SDE.Service
{
    sealed class SDERyyni : Grain
    {
        private string latestbuild = "developers.eveonline.com/static-data/tranquility/latest.jsonl";
        private SdePakkaus sde;
        internal class SdePakkaus
        {

        }
        public Task GetLatestBuild()
        {
            try
            {
                sde = LueJsonRivitAsync(latestbuild);
            }
            catch (Exception)
            {

                throw;
            }

            return Task.CompletedTask;
        }

        private static async Task<List<SdePakkaus>> LueJsonRivitAsync(string latestbuild)
        {
            var tulos = new List<SdePakkaus>();

            using (StreamReader reader = new StreamReader(latestbuild))
            {
                string line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    T obj = JsonSerializer.Deserialize<T>(line);
                    tulos.Add(obj);
                }
            }

            return tulos;
        }
    }
}
