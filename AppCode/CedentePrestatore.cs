/// <summary>
/// [1.2] Blocco sempre obbligatorio contenente dati relativi al cedente / prestatore (fornitore)
/// </summary>
public class CedentePrestatore
{
    /// <summary>
    /// Blocco sempre obbligatorio contenente dati relativi al cedente / prestatore
    /// </summary>
    public DatiAnagrafici DatiAnagrafici;

    /// <summary>
    /// Blocco contenente i dati della sede del cedente / prestatore. Si tratta della sede legale per le società e del domicilio fiscale per le ditte individuali e i lavoratori autonomi
    /// </summary>
    public Sede Sede;

    /// <summary>
    /// Blocco da valorizzare nei casi di cedente / prestatore non residente, con stabile organizzazione in Italia
    /// </summary>
    public StabileOrganizzazione StabileOrganizzazione;

    /// <summary>
    /// Blocco da valorizzare nei casi di società iscritte nel registro delle imprese ai sensi dell'art. 2250 del codice civile.
    /// </summary>
    public IscrizioneREA IscrizioneREA;

    /// <summary>
    /// Dati relativi ai contatti del cedente / prestatore
    /// </summary>
    public Contatti Contatti;

    /// <summary>
    /// Codice identificativo del cedente / prestatore ai fini amministrativo-contabili
    /// </summary>
    public string RiferimentoAmministrazione;
}
