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
    public class SDEKontrakti
    {

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
    public record SDE
    {
        int buildNumber;
        DateTime releaseDate;
    }
    
}
