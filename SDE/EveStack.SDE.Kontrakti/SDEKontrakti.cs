using System.ComponentModel.DataAnnotations;

namespace EveStack.SDE.Kontrakti
{
    internal enum DataFormaatti
    {
        JsonLines,
        Yaml
        
    }
    public interface ISDERyyni : IGrainWithStringKey
    {
        Task HaeUusiBuildi();
        Task LueJsonRivit(string uusinBuildi);
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
