using System.Collections.Generic;
using System.Xml.Serialization;

/// <summary>
/// [2.2] Blocco sempre obbligatorio. Contiene natura, qualità, quantità e gli elementi necessari a determinare il valore dei beni e/o dei servizi formanti oggetto dell'operazione
/// </summary>
[XmlRoot("DettaglioLinee")]
public class DatiBeniServizi
{
    /// <summary>
    /// Blocco contenente le linee di dettaglio del documento (gli elementi informativi del blocco si ripetono per ogni riga di dettaglio).
    /// </summary>
    [XmlElement("DettaglioLinee")]
    public List<DettaglioLinee> DettaglioLinee;

    /// <summary>
    /// Blocco obbligatorio, gli elementi informativi che lo compongono riepilogano le informazioni di dettaglio, aggregandole per aliquota IVA distinta oppure per aliquota IVA nulla e "Natura" distinta oppure, a parità di questi elementi, per valore distinto di "Esigbilità"
    /// </summary>
    [XmlElement("DatiRiepilogo")]
    public List<DatiRiepilogo> DatiRiepilogo;

    public DatiBeniServizi()
    {
        DettaglioLinee = new List<DettaglioLinee>();
        DatiRiepilogo = new List<DatiRiepilogo>();
    }
}
