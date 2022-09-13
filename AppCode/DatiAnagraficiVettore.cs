public class DatiAnagraficiVettore
{
    /// <summary>
    /// Numero di identificazione fiscale ai fini IVA; i primi due caratteri rappresentano il paese ( IT, DE, ES …..) ed i restanti (fino ad un massimo di 28) il codice vero e proprio che, per i residenti in Italia, corrisponde al numero di partita IVA.
    /// </summary>
    public IdFiscaleIVA IdFiscaleIVA;

    /// <summary>
    /// Numero di Codice Fiscale
    /// </summary>
    public string CodiceFiscale;

    /// <summary>
    /// Dati anagrafici identificativi del vettore
    /// </summary>
    public Anagrafica Anagrafica;

    /// <summary>
    /// Numero identificativo della licenza di guida (es. numero patente)
    /// </summary>
    public string NumeroLicenzaGuida;
}
