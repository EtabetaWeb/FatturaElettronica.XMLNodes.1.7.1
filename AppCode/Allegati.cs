/// <summary>
/// [2.5] Dati relativi ad eventuali allegati
/// </summary>
public class Allegati
{

    /// <summary>
    /// Nome dell'allegato
    /// </summary>
    public string NomeAttachment;

    /// <summary>
    /// Algoritmo usato per comprimere l'attachment (ad es.: ZIP, RAR, …)
    /// </summary>
    public string AlgoritmoCompressione;

    /// <summary>
    /// Formato dell'attachment (ad es: TXT, XML, DOC, PDF …….)
    /// </summary>
    public string FormatoAttachment;

    /// <summary>
    /// Descrizione del documento
    /// </summary>
    public string DescrizioneAttachment;

    /// <summary>
    /// Contiene il documento allegato alla fattura; il contenuto è demandato agli accordi tra PA e fornitore 
    /// </summary>
    public string Attachment;
}
