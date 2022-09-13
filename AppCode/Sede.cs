public class Sede
{
    /// <summary>
    /// Indirizzo della sede del cedente o prestatore (nome della via, piazza etc.) 
    /// </summary>
    public string Indirizzo;

    /// <summary>
    /// Numero civico riferito all'indirizzo (non indicare se già presente nell'elemento informativo indirizzo)
    /// </summary>
    public string NumeroCivico;

    /// <summary>
    /// Codice Avviamento Postale 
    /// </summary>
    public string CAP;

    /// <summary>
    /// Comune relativo alla sede del cedente / prestatore
    /// </summary>
    public string Comune;

    /// <summary>
    /// Sigla della provincia di appartenenza del comune indicato nell'elemento informativo 1.2.2.4 "Comune". Da valorizzare se l'elemento informativo 1.2.2.6 "Nazione" è uguale a IT
    /// </summary>
    public string Provincia;

    /// <summary>
    /// Codice della nazione espresso secondo lo standard ISO 3166-1 alpha-2 code 
    /// </summary>
    public string Nazione;
}
