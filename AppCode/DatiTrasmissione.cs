/// <summary>
/// [1.1] Blocco sempre obbligatorio contenente informazioni che identificano univocamente il soggetto che trasmette, il documento trasmesso, il formato in cui è stato trasmesso il documento, il soggetto destinatario
/// ''' </summary>
public class DatiTrasmissione
{
    /// <summary>
    /// E' l’identificativo univoco del soggetto trasmittente; per i soggetti residenti in Italia, siano essi persone fisiche o giuridiche, corrisponde al codice fiscale preceduto da IT; per i soggetti non residenti corrisponde al numero identificativo IVA (dove i primi due caratteri rappresentano il paese secondo lo standard ISO 3166-1 alpha-2 code, ed i restanti, fino ad un massimo di 28, il codice vero e proprio)
    /// </summary>
    public IdTrasmittente IdTrasmittente;

    /// <summary>
    /// Numerazione attribuita dal soggetto che trasmette, secondo sue proprie regole
    /// </summary>
    public string ProgressivoInvio;

    /// <summary>
    /// Contiene il codice identificativo del tipo di trasmissione che si sta effettuando e del relativo formato
    /// </summary>
    public string FormatoTrasmissione;

    /// <summary>
    /// Per le fatture verso la PA (1.1.3 "FormatoTrasmissione" = FPA12) contiene il codice, di 6 caratteri, dell'ufficio destinatario della fattura, definito dall'amministrazione di appartenenza come riportato nella rubrica “Indice PA”
    /// Per le fatture verso privati (1.1.3 "FormatoTrasmissione"= FPR12) contiene il codice, di 7 caratteri, assegnato dal Sdi ai soggetti che hanno accreditato un canale; qualora il destinatario non abbia accreditato un canale presso SdI, l'elemento deve essere valorizzato con tutti zeri ('0000000')
    /// Per le fatture emesse con riferimento a operazioni "transfrontaliere" l'elemento deve essere valorizzato con tutte "X" ('XXXXXXX') 
    /// </summary>
    public string CodiceDestinatario;

    /// <summary>
    /// Dati relativi ai contatti del trasmittente
    /// </summary>
    public ContattiTrasmittente ContattiTrasmittente;

    /// <summary>
    /// Indirizzo PEC al quale inviare il documento
    /// </summary>
    public string PECDestinatario;
}
