using System.ComponentModel.DataAnnotations;

namespace EveStack.SDE.Kontrakti
{
    public enum DataFormaatti
    {
        JsonLines,
        Yaml
        
    }
    public interface ISDERyyni : IGrainWithStringKey
    {
        Task HaeUusiBuildi();
        Task<List<object>> LueJsonRivit(string uusinBuildinro);
    }
   
    public record Taivaallinen
    {

    }

    public record SDEJsonLines
    {
        string _avain = "sde";
        string? rakennusNumero;
        DateTime? julkaisuPäivä;
    }
    public record StaattinenData
    {
        int buildNumber;
        DateTime releaseDate;
    }
    
}
