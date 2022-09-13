public class DatiRiepilogo
{
    /// <summary>
    /// Aliquota (%) IVA
    /// </summary>
    public string AliquotaIVA;

    /// <summary>
    /// L'elemento serve per indicare il motivo (Natura dell'operazione) per il quale l'emittente della fattura non indica aliquota IVA
    /// Rif. file dati 2.2.2.2
    /// </summary>
    public string Natura;

    /// <summary>
    /// Riepilogo degli importi di spese accessorie indicate nelle righe di dettaglio ("TipoCessionePrestazione" = 'AC'), tale importo rappresenta una parte dell'ammontare contenuto nell'elemento 2.2.2.5 "ImponibileImporto"
    /// </summary>
    public string SpeseAccessorie;

    /// <summary>
    /// Importo dell'arrotondamento eventualmente applicato alle somme dei dati di dettaglio per riportarle al centesimo di euro, come espresse nell'elemento 2.2.2.5 "ImponibileImporto"
    /// </summary>
    public string Arrotondamento;

    /// <summary>
    /// Questo valore rappresenta:la base imponibile, se il riepilogo riguarda operazioni soggette ad IVA;l'ammontare degli importi, se il riepilogo riguarda le operazioni per le quali l'IVA non deve essere esposta (elemento informativo 2.2.2.2 "Natura" valorizzato)
    /// </summary>
    public string ImponibileImporto;

    /// <summary>
    /// Imposta risultante dall'applicazione dell'aliquota IVA all'imponibile
    /// </summary>
    public string Imposta;

    /// <summary>
    /// L'elemento esprime il momento nel quale l'IVA diventa esigibile (immediata ai sensi dell'Art. 6 comma 5 del DPR 633 1972, oppure differita) oppure il fatto che le modalità di versamento dell'imposta sono differenti da quelle ordinarie (scissione dei pagamenti)
    /// I=IVA ad esigibilità immediata, D=IVA ad esigibilità differita, S=scissione dei pagamenti
    /// </summary>
    public string EsigibilitaIVA;

    /// <summary>
    /// Norma di riferimento (nei casi in cui l'elemento informativo 2.2.2.2 "Natura" è valorizzato)
    /// </summary>
    public string RiferimentoNormativo;
}
