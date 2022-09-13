public class DatiRitenuta
{
    /// <summary>
    /// Tipologia della ritenuta
    /// valori ammessi:
    /// [RT01]: ritenuta pers. fisiche
    /// [RT02]: ritenuta pers. giurid.
    /// </summary>
    public string TipoRitenuta;

    /// <summary>
    /// Importo della ritenuta
    /// </summary>
    public string ImportoRitenuta;

    /// <summary>
    /// Aliquota (%) della ritenuta
    /// </summary>
    public string AliquotaRitenuta;

    /// <summary>
    /// Causale del pagamento (quella del modello 770)
    /// Rif. file dati 2.1.1.5.4
    /// </summary>
    public string CausalePagamento;
}
