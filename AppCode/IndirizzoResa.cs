public class IndirizzoResa
{
    /// <summary>
    /// Indirizzo di resa (nome della via, piazza etc.)
    /// </summary>
    public string Indirizzo;

    /// <summary>
    /// Numero civico riferito all'indirizzo di resa (non indicare se già presente nell'elemento informativo Indirizzo)
    /// </summary>
    public string NumeroCivico;

    /// <summary>
    /// Codice Avviamento Postale dell'indirizzo di resa
    /// </summary>
    public string CAP;

    /// <summary>
    /// Comune ove ha sede l'indirizzo di resa
    /// </summary>
    public string Comune;

    /// <summary>
    /// Sigla della provincia di appartenenza del comune indicato nell'elemento informativo 2.1.9.12.4 "Comune"
    /// </summary>
    public string Provincia;

    /// <summary>
    /// Codice della nazione espresso secondo lo standard ISO 3166-1 alpha-2 code
    /// </summary>
    public string Nazione;
}
