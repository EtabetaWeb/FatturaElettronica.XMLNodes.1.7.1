using System.Collections.Generic;
using System.Xml.Serialization;

/// <summary>
/// ''' [2.1] Blocco sempre obbligatorio contenente i dati generali della fattura e quelli degli eventuali documenti correlati
/// ''' </summary>
public class DatiGenerali
{
    /// <summary>
    /// Blocco sempre obbligatorio contenente i dati generali della fattura
    /// </summary>
    public DatiGeneraliDocumento DatiGeneraliDocumento;

    /// <summary>
    /// Blocco contenente le informazioni relative all'ordine di acquisto
    /// </summary>
    [XmlElement]
    public List<DatiOrdineAcquisto> DatiOrdineAcquisto;

    /// <summary>
    /// Blocco contenente le informazioni relative al contratto; contiene gli stessi elementi informativi previsti per il blocco 2.1.2
    /// </summary>
    [XmlElement]
    public List<DatiContratto> DatiContratto;

    /// <summary>
    /// Blocco contenente le informazioni relative alla convenzione; contiene gli stessi elementi informativi previsti per il blocco 2.1.2
    /// </summary>
    [XmlElement]
    public List<DatiConvenzione> DatiConvenzione;

    /// <summary>
    /// Blocco contenente le informazioni relative ai dati presenti sul sistema gestionale in uso presso la PA (Agenzie Fiscali) riguardanti la fase di ricezione; contiene gli stessi elementi informativi previsti per il blocco 2.1.2
    /// </summary>
    [XmlElement]
    public List<DatiRicezione> DatiRicezione;

    /// <summary>
    /// Blocco contenente le informazioni relative alle fatture precedentemente trasmesse e alle quali si collega il documento presente; riguarda i casi di invio di nota di credito e/o di fatture di conguaglio a fronte di precedenti fatture di acconto; contiene gli stessi elementi informativi previsti per il blocco 2.1.2
    /// </summary>
    [XmlElement]
    public List<DatiFattureCollegate> DatiFattureCollegate;

    /// <summary>
    /// Blocco da valorizzare nei casi di fattura per stato di avanzamento
    /// </summary>
    public List<DatiSAL> DatiSAL;

    /// <summary>
    /// Blocco da valorizzare nei casi di fattura "differita" per indicare il documento con cui è stato consegnato il bene (gli elementi informativi del blocco possono essere ripetuti se la fattura fa riferimento a più consegne e quindi a più documenti di trasporto)
    /// </summary>
    [XmlElement]
    public List<DatiDDT> DatiDDT;

    /// <summary>
    /// Blocco valorizzabile nei casi di fattura "accompagnatoria" per inserire informazioni relative al trasporto
    /// </summary>
    public DatiTrasporto DatiTrasporto;

    /// <summary>
    /// Blocco da valorizzare nei casi di fatture per operazioni accessorie, emesse dagli 'autotrasportatori' per usufruire delle agevolazioni in materia di registrazione e pagamento dell' IVA
    /// </summary>
    public FatturaPrincipale FatturaPrincipale;
}
