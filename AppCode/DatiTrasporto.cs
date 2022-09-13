public class DatiTrasporto
{
    /// <summary>
    /// Blocco contenente i dati fiscali e anagrafici del vettore
    /// </summary>
    public DatiAnagraficiVettore DatiAnagraficiVettore;

    /// <summary>
    /// Mezzo utilizzato per il trasporto
    /// </summary>
    public string MezzoTrasporto;

    /// <summary>
    /// Causale del trasporto
    /// </summary>
    public string CausaleTrasporto;

    /// <summary>
    /// Numero dei colli trasportati
    /// </summary>
    public string NumeroColli;

    /// <summary>
    /// Descrizione (natura, qualità, aspetto …) relativa ai colli trasportati
    /// </summary>
    public string Descrizione;

    /// <summary>
    /// Unità di misura riferita al peso della merce
    /// </summary>
    public string UnitaMisuraPeso;

    /// <summary>
    /// Peso lordo della merce
    /// </summary>
    public string PesoLordo;

    /// <summary>
    /// Peso netto della merce
    /// </summary>
    public string PesoNetto;

    /// <summary>
    /// Data e ora del ritiro della merce (secondo il formato ISO 8601:2004)
    /// </summary>
    public string DataOraRitiro;

    /// <summary>
    /// Data di inizio del trasporto (secondo il formato ISO 8601:2004)
    /// </summary>
    public string DataInizioTrasporto;

    /// <summary>
    /// Codifica del termine di resa espresso secondo lo standard ICC-Camera di Commercio Internazionale (Incoterms)
    /// </summary>
    public string TipoResa;

    /// <summary>
    /// Dati dell'indirizzo di resa
    /// </summary>
    public IndirizzoResa IndirizzoResa;

    /// <summary>
    /// Data e ora della consegna della merce (secondo il formato ISO 8601:2004)
    /// </summary>
    public string DataOraConsegna;
}
