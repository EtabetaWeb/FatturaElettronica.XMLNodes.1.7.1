public class DettaglioPagamento
{
    /// <summary>
    /// Beneficiario del pagamento (utilizzabile se si intende indicare un beneficiario diverso dal cedente/prestatore)
    /// </summary>
    public string Beneficiario;

    /// <summary>
    /// Modalità di pagamento
    /// Rif. file dati 2.4.2.2
    /// </summary>
    public string ModalitaPagamento;

    /// <summary>
    /// Data dalla quale decorrono i termini di pagamento (secondo il formato ISO 8601:2004)
    /// </summary>
    public string DataRiferimentoTerminiPagamento;

    /// <summary>
    /// Termini di pagamento espressi in giorni a partire dalla data di riferimento di cui all'elemento informativo precedente 2.4.2.3 "DataRiferimentoTerminiPagamento" (vale 0 per pagamenti a vista )
    /// </summary>
    public string GiorniTerminiPagamento;

    /// <summary>
    /// Data di scadenza del pagamento (secondo il formato ISO 8601:2004) da indicare nei casi in cui ha senso sulla bese delle condizioni di pagamento previste)
    /// </summary>
    public string DataScadenzaPagamento;

    /// <summary>
    /// Importo relativo al pagamento
    /// </summary>
    public string ImportoPagamento;

    /// <summary>
    /// Nei casi di modalità di pagamento in cui ha senso l'indicazione dell'ufficio postale
    /// </summary>
    public string CodUfficioPostale;

    /// <summary>
    /// Cognome del quietanzante (nei casi di elemento informativo 2.4.2.2 "ModalitaPagamento" = MP04 )
    /// </summary>
    public string CognomeQuietanzante;

    /// <summary>
    /// Nome del quietanzante (nei casi di elemento informativo 2.4.2.2 "ModalitaPagamento" = MP04 )
    /// </summary>
    public string NomeQuietanzante;

    /// <summary>
    /// Codice fiscale del quietanzante (nei casi di elemento informativo 2.4.2.2 "ModalitaPagamento" = MP04 )
    /// </summary>
    public string CFQuietanzante;

    /// <summary>
    /// Titolo del quietanzante (nei casi di elemento informativo 2.4.2.2 <ModalitaPagamento> = MP04 )
    /// </summary>
    public string TitoloQuietanzante;

    /// <summary>
    /// Nome dell'Istituto Finanziario
    /// </summary>
    public string IstitutoFinanziario;

    /// <summary>
    /// International Bank Account Number (coordinata bancaria internazionale che consente di identificare, in maniera standard, il conto corrente del beneficiario )
    /// </summary>
    public string IBAN;

    /// <summary>
    /// Codice ABI
    /// </summary>
    public string ABI;

    /// <summary>
    /// Codice CAB
    /// </summary>
    public string CAB;

    /// <summary>
    /// Bank Identifier Code (codice che identifica la banca del beneficiario)
    /// </summary>
    public string BIC;

    /// <summary>
    /// Ammontare dello sconto per pagamento anticipato
    /// </summary>
    public string ScontoPagamentoAnticipato;

    /// <summary>
    /// Data limite stabilita per il pagamento anticipato (secondo il formato ISO 8601:2004)
    /// </summary>
    public string DataLimitePagamentoAnticipato;

    /// <summary>
    /// Ammontare della penalità dovuta per pagamenti ritardati
    /// </summary>
    public string PenalitaPagamentiRitardati;

    /// <summary>
    /// Data di decorrenza della penale (secondo il formato ISO 8601:2004)
    /// </summary>
    public string DataDecorrenzaPenale;

    /// <summary>
    /// Codice per la riconciliazione degli incassi da parte del cedente/prestatore
    /// </summary>
    public string CodicePagamento;
}
