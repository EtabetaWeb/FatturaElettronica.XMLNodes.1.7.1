public class DatiCassaPrevidenziale
{
    /// <summary>
    /// Tipologia cassa previdenziale di appartenenza
    /// Rif. file dati 2.1.1.7.1
    /// </summary>
    public string TipoCassa;

    /// <summary>
    /// Aliquota (%) del contributo, se previsto, per la cassa di appartenenza
    /// </summary>
    public string AlCassa;

    /// <summary>
    /// Importo del contributo per la cassa di appartenenza
    /// </summary>
    public string ImportoContributoCassa;

    /// <summary>
    /// Importo sul quale applicare il contributo cassa previdenziale
    /// </summary>
    public string ImponibileCassa;

    /// <summary>
    /// Aliquota (%) IVA applicata
    /// </summary>
    public string AliquotaIVA;

    /// <summary>
    /// Indica se il contributo cassa è soggetto a ritenuta
    /// </summary>
    public string Ritenuta;

    /// <summary>
    /// Codice che esprime la natura della non imponibilità del contributo cassa. Se AliquotaIVA è valorizzato impostare a zero.
    /// Rif. file dati 2.1.1.7.7
    /// </summary>
    public string Natura;

    /// <summary>
    /// Codice identificativo ai fini amministrativo-contabili
    /// </summary>
    public string RiferimentoAmministrazione;
}
