public class CodiceArticolo
{
    /// <summary>
    /// Indica la tipologia di codice articolo (per esempio, TARIC, CPV, EAN, SSC, ...)
    /// </summary>
    public string CodiceTipo;

    /// <summary>
    /// Indica il valore del codice articolo corrispondente alla tipologia riportata nell'elemento informativo 2.2.1.3.1 "CodiceTipo"
    /// </summary>
    public string CodiceValore;
}
