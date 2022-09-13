public class DatiDDT
{
    /// <summary>
    /// Numero del documento di trasporto
    /// </summary>
    public string NumeroDDT;

    /// <summary>
    /// Data del documento di trasporto (secondo il formato ISO 8601:2004)
    /// </summary>
    public string DataDDT;

    /// <summary>
    /// Linea di dettaglio della fattura cui si riferisce il DDT (non viene valorizzato se il riferimento è all'intera fattura) (vedi elemento informativo 2.2.1.1 "NumeroLinea")
    /// </summary>
    public string RiferimentoNumeroLinea;
}
