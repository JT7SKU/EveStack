
namespace EveStack.SDE.Service
{
    public class SDERyyni : Grain, ISDERyyni
    {
        private string latestbuild = "developers.eveonline.com/static-data/tranquility/latest.jsonl";
        private string sde = "";
        public Task GetLatestBuild()
        {
            try
            {
                sde = LueJsonRivit(latestbuild);
            }
            catch (Exception)
            {

                throw;
            }

            return Task.CompletedTask;
        }

        private string LueJsonRivit(string latestbuild)
        {
            throw new NotImplementedException();
        }
    }
}
