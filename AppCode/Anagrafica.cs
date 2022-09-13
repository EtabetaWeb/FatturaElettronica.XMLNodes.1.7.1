public class Anagrafica
{
    /// <summary>
    /// Ditta, denominazione o ragione sociale (ditta, impresa, società, ente), da valorizzare solo se non sono valorizzati gli elementi informativi 1.2.1.3.2 <Nome> e 1.2.1.3.3 <Cognome>
    /// </summary>
    public string Denominazione;

    /// <summary>
    /// Nome della persona fisica. Da valorizzare insieme all'elemento informativo 1.2.1.3.3  <Cognome> e solo se non è valorizzato l'elemento informativo 1.2.1.3.1 <Denominazione>
    /// </summary>
    public string Nome;

    /// <summary>
    /// Cognome della persona fisica. Da valorizzare insieme all'elemento informativo 1.2.1.3.2 <Nome>  e solo se non è valorizzato l'elemento informativo 1.2.1.3.1 <Denominazione>
    /// </summary>
    public string Cognome;

    /// <summary>
    /// Titolo onorifico 
    /// </summary>
    public string Titolo;

    /// <summary>
    /// Numero del Codice EORI (Economic Operator Registration and Identification) in base al Regolamento (CE) n. 312 del 16 aprile 2009. In vigore dal 1 luglio 2009
    /// </summary>
    public string CodEORI;
}
