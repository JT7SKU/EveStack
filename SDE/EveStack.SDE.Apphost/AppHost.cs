public partial class Program
{
    private static void Main(string[] args)
    {
        var rakentaja = DistributedApplication.CreateBuilder(args);

        var postress = rakentaja.AddPostgres("postgres");
        var postreDB = postress.AddDatabase("pgdb");
        rakentaja.AddProject<Projects.SdeApi>("sde-api").WaitFor(postreDB).WithReference(postreDB);
        


        rakentaja.Build().Run();
    }
}

