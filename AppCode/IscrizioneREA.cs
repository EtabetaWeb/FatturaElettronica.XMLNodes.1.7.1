public class IscrizioneREA
{
    /// <summary>
    /// Sigla della provincia dell'Ufficio del registro delle imprese presso il quale è registrata la società
    /// </summary>
    public string Ufficio;

    /// <summary>
    /// Numero di iscrizione al registro delle imprese
    /// </summary>
    public string NumeroREA;

    /// <summary>
    /// Nei soli casi di società di capitali (SpA, SApA, SRL), l'elemento informativo va valorizzato per indicare il capitale sociale
    /// </summary>
    public string CapitaleSociale;

    /// <summary>
    /// Nei casi di società per azioni e a responsabilità limitata, l'elemento informativo va valorizzato per indicare se vi è un socio unico oppure se vi sono più soci 
    /// formato alfanumerico; lunghezza di 2 caratteri; i valori ammessi sono i seguenti:
    /// SU la società è a socio unico.
    /// SM la società NON è a socio unico.
    /// </summary>
    public string SocioUnico;

    /// <summary>
    /// Indica se la Società si trova in stato di liquidazione oppure no
    /// formato alfanumerico; lunghezza di 2 caratteri; i valori ammessi sono i seguenti:
    /// LS la società è in stato di liquidazione.
    /// LN la società NON è in stato di liquidazione.
    /// </summary>
    public string StatoLiquidazione;
}
