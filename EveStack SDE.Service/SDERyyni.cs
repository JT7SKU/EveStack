using System.Text.Json;
namespace EveStack_SDE.Service
{
    public class SDERyyni
    {
        private string latestbuild = "developers.eveonline.com/static-data/tranquility/latest.jsonl";
        private string sde = "";
        public Task GetLatestBuild()
        {
            try
            {
                sde = ReadJsonl(latestbuild);
            }
            catch (Exception)
            {

                throw;
            }
            
            return Task.CompletedTask;
        }

        private string ReadJsonl(string latestbuild)
        {
            throw new NotImplementedException();
        }
    }
}
