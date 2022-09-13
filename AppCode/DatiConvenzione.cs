public class DatiConvenzione
{
    /// <summary>
    /// Linea di dettaglio della fattura a cui si fa riferimento (se il riferimento è all'intera fattura, non viene valorizzato) (vedi elemento informativo 2.2.1.1)
    /// </summary>
    public string RiferimentoNumeroLinea;

    /// <summary>
    /// Numero del documento
    /// </summary>
    public string IdDocumento;

    /// <summary>
    /// Data del documento (secondo il formato ISO 8601:2004, con la seguente precisione: YYYY-MM-DD.)
    /// </summary>
    public string Data;

    /// <summary>
    /// Identificativo della singola voce all'interno del documento (ad esempio, nel caso di ordine di acquisto, è il numero della linea dell'ordine di acquisto, oppure, nel caso di contratto, è il numero della linea del contratto, etc.)
    /// </summary>
    public string NumItem;

    /// <summary>
    /// Codice della commessa o della convenzione
    /// </summary>
    public string CodiceCommessaConvenzione;

    /// <summary>
    /// Rappresenta il codice gestito dal CIPE che caratterizza ogni progetto di investimento pubblico (Codice Unitario Progetto)
    /// </summary>
    public string CodiceCUP;

    /// <summary>
    /// Rappresenta il Codice Identificativo della Gara
    /// </summary>
    public string CodiceCIG;
}
