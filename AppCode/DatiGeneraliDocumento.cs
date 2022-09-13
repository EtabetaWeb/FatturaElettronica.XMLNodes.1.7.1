using System.Collections.Generic;
using System.Xml.Serialization;

public class DatiGeneraliDocumento
{
    /// <summary>
    /// Tipologia di documento
    /// Rif. file dati 2.1.1.1
    /// </summary>
    public string TipoDocumento;

    /// <summary>
    /// Codice (espresso secondo lo standard ISO 4217 alpha-3:2001) della valuta utilizzata per l'indicazione degli importi
    /// </summary>
    public string Divisa;

    /// <summary>
    /// Data del documento (secondo il formato ISO 8601:2004 con la seguente precisione: YYYY-MM-DD)
    /// </summary>
    public string Data;

    /// <summary>
    /// Numero della fattura (art. 21, comma 2, lettera b DPR 633/1972)
    /// </summary>
    public string Numero;

    /// <summary>
    /// Blocco dati relativi alla ritenuta
    /// </summary>
    public DatiRitenuta DatiRitenuta;

    /// <summary>
    /// Blocco dati relativi al bollo
    /// </summary>
    public DatiBollo DatiBollo;

    /// <summary>
    /// Blocco dati relativi alla cassa professionale di appartenenza
    /// </summary>
    [XmlElement]
    public List<DatiCassaPrevidenziale> DatiCassaPrevidenziale;

    /// <summary>
    /// Eventuale sconto o maggiorazione applicati sul totale documento (la molteplicità N del blocco consente di gestire la presenza di più sconti o più maggiorazioni a 'cascata')
    /// </summary>
    [XmlElement]
    public List<ScontoMaggiorazione> ScontoMaggiorazione;

    /// <summary>
    /// Importo totale del documento al netto dell'eventuale sconto e comprensivo di imposta a debito del cessionario/committente
    /// </summary>
    public string ImportoTotaleDocumento;

    /// <summary>
    /// Eventuale arrotondamento sul totale documento (ammette anche il segno negativo)
    /// </summary>
    public string Arrotondamento;

    /// <summary>
    /// Descrizione della causale del documento
    /// </summary>
    public string Causale;

    /// <summary>
    /// Indica se il documento è stato emesso secondo modalità e termini stabiliti con decreto ministeriale ai sensi dell'articolo 73 del DPR 633/72 (ciò consente al cedente/prestatore l'emissione nello stesso anno di più documenti aventi stesso numero)
    /// </summary>
    public string Art73;
}
