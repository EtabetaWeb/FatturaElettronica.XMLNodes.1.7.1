/// <summary>
/// ''' [2] Il blocco ha molteplicità pari a 1 nel caso di fattura singola; nel caso di lotto di fatture, si ripete per ogni fattura componente il lotto stesso
/// ''' </summary>
public class FatturaElettronicaBody
{
    /// <summary>
    /// [2.1] Blocco sempre obbligatorio contenente i dati generali della fattura e quelli degli eventuali documenti correlati
    /// </summary>
    public DatiGenerali DatiGenerali;

    /// <summary>
    /// [2.2] Blocco sempre obbligatorio. Contiene natura, qualità, quantità e gli elementi necessari a determinare il valore dei beni e/o dei servizi formanti oggetto dell'operazione
    /// </summary>
    public DatiBeniServizi DatiBeniServizi;

    /// <summary>
    /// [2.3] Dati relativi ai veicoli di cui all'art. 38, comma 4 del dl 331 del 1993
    /// </summary>
    public DatiVeicoli DatiVeicoli;

    /// <summary>
    /// [2.4] Blocco destinato a descrivere le modalità di pagamento per la cessione/prestazione rappresentata in fattura
    /// </summary>
    public DatiPagamento DatiPagamento;

    /// <summary>
    /// [2.5] Dati relativi ad eventuali allegati
    /// </summary>
    public Allegati Allegati;
}
