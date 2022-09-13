public class DatiAnagrafici
{
    /// <summary>
    /// Numero di identificazione fiscale ai fini IVA; i primi due caratteri rappresentano il paese ( IT, DE, ES …..) ed i restanti (fino ad un massimo di 28) il codice vero e proprio che, per i residenti in Italia, corrisponde al numero di partita IVA
    /// </summary>
    public IdFiscaleIVA IdFiscaleIVA;

    /// <summary>
    /// Numero di Codice Fiscale
    /// </summary>
    public string CodiceFiscale;

    /// <summary>
    /// Dati anagrafici identificativi del cedente / prestatore
    /// </summary>
    public Anagrafica Anagrafica;

    /// <summary>
    /// Nome dell'albo professionale
    /// </summary>
    public string AlboProfessionale;

    /// <summary>
    /// Sigla della provincia di competenza dell'albo professionale 
    /// </summary>
    public string ProvinciaAlbo;

    /// <summary>
    /// Numero di iscrizione all'albo professionale
    /// </summary>
    public string NumeroIscrizioneAlbo;

    /// <summary>
    /// Data di iscrizione all'albo professionale (secondo il formato ISO 8601:2004) 
    /// </summary>
    public string DataIscrizioneAlbo;

    /// <summary>
    /// Regime fiscale (vedere tabella agenzia entrate per eventuali riferimenti)
    /// </summary>
    public string RegimeFiscale;
}
