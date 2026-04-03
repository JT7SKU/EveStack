
using System.Text.Json;

namespace EveStack.SDE.Service
{
    sealed class SDERyyni : Grain
    {
        private string latestbuild = "developers.eveonline.com/static-data/tranquility/latest.jsonl";
        private string sde;
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

        private static async Task<List<T>> LueJsonRivitAsync(string latestbuild)
        {
            var tulos = new List<T>();

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
