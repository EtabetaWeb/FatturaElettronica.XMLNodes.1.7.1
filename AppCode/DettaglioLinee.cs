public class DettaglioLinee
{
    /// <summary>
    /// Numero della riga di dettaglio del documento
    /// </summary>
    public string NumeroLinea;

    /// <summary>
    /// Da valorizzare nei soli casi in cui si voglia utilizzare la riga per rappresentare uno sconto/premio/abbuono ovvero una spesa accessoria
    /// Rif. file dati 2.2.1.2
    /// </summary>
    public string TipoCessionePrestazione;

    /// <summary>
    /// Eventuale codifica dell'articolo (la molteplicità N del blocco consente di gestire la presenza di più codifiche per la medesima riga)
    /// </summary>
    public CodiceArticolo CodiceArticolo;

    /// <summary>
    /// Natura e qualità dell'oggetto della cessione/prestazione; può fare anche riferimento a cessioni/prestazioni già oggetto di un precedente documento emesso a titolo di 'anticipo/acconto' , nel qual caso il valore dell'elemento informativo 2.2.1.9 PrezzoUnitario e 2.2.1.11 PrezzoTotale potranno essere valorizzati con segno negativo
    /// </summary>
    public string Descrizione;

    /// <summary>
    /// Numero di unità cedute / erogate
    /// </summary>
    public string Quantita;

    /// <summary>
    /// Unità di misura riferita alla quantità
    /// </summary>
    public string UnitaMisura;

    /// <summary>
    /// Data iniziale del periodo di riferimento cui si riferisce l'eventuale servizio prestato (secondo il formato ISO 8601:2004)
    /// </summary>
    public string DataInizioPeriodo;

    /// <summary>
    /// Data finale del periodo di riferimento cui si riferisce l'eventuale servizio prestato (secondo il formato ISO 8601:2004)
    /// </summary>
    public string DataFinePeriodo;

    /// <summary>
    /// Prezzo unitario del bene/servizio; nel caso di beni ceduti a titolo di sconto, premio o abbuono, l'importo indicato rappresenta il "valore normale"
    /// </summary>
    public string PrezzoUnitario;

    /// <summary>
    /// Eventuale sconto o maggiorazione applicati al prezzo unitario (la molteplicità N del blocco consente di gestire la presenza di più sconti o maggiorazioni a 'cascata')
    /// </summary>
    public ScontoMaggiorazione ScontoMaggiorazione;

    /// <summary>
    /// Importo totale del bene/servizio (che tiene conto di eventuali sconti / maggiorazioni applicati al prezzo unitario) IVA esclusa
    /// </summary>
    public string PrezzoTotale;

    /// <summary>
    /// Aliquota (%) IVA applicata al bene/servizio
    /// </summary>
    public string AliquotaIVA;

    /// <summary>
    /// Da valorizzare solo in caso di cessione/prestazione soggetta a ritenuta di acconto
    /// </summary>
    public string Ritenuta;

    /// <summary>
    /// L'elemento serve per indicare il motivo (Natura dell'operazione) per il quale l'emittente della fattura non indica aliquota IVA (l'elemento informativo 2.2.1.12 "AliquotaIVA" deve essere valorizzato a zero)
    /// Rif. file dati 2.2.1.14
    /// </summary>
    public string Natura;

    /// <summary>
    /// Codice identificativo ai fini amministrativo-contabili
    /// </summary>
    public string RiferimentoAmministrazione;

    /// <summary>
    /// Blocco che consente di agli utenti di inserire, con riferimento ad una linea di dettaglio, informazioni utili ai fini amministrativi, gestionali etc.
    /// </summary>
    public AltriDatiGestionali AltriDatiGestionali;
}
