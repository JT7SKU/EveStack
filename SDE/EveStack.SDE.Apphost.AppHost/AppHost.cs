public partial class Program
{
    private static void Main(string[] args)
    {
        var rakentaja = DistributedApplication.CreateBuilder(args);

        var postress = rakentaja.AddPostgres("postgres");
        var postreDB = postress.AddDatabase("pgdb");
        rakentaja.AddProject<Projects.EveStack_SDE_Api>("evestack-sde-api").WaitFor(postreDB).WithReference(postreDB);
        


        rakentaja.Build().Run();
    }
}

