
public class Codifiche
{
    public enum RegimeFiscale
    {
        /// <summary>
        /// Ordinario
        /// </summary>
        RF01,
        /// <summary>
        /// Contribuenti minimi (art.1, c.96-117, L. 244/07) 									
        /// </summary>
        RF02,
        /// <summary>
        /// Agricoltura e attività connesse e pesca (artt.34 e 34-bis, DPR 633/72) 									
        /// </summary>
        RF04,
        /// <summary>
        /// Vendita sali e tabacchi (art.74, c.1, DPR. 633/72) 									
        /// </summary>
        RF05,
        /// <summary>
        /// Commercio fiammiferi (art.74, c.1, DPR  633/72) 									
        /// </summary>
        RF06,
        /// <summary>
        /// Editoria (art.74, c.1, DPR  633/72)									
        /// </summary>
        RF07,
        /// <summary>
        /// Gestione servizi telefonia pubblica (art.74, c.1, DPR 633/72) 									
        /// </summary>
        RF08,
        /// <summary>
        /// Rivendita documenti di trasporto pubblico e di sosta (art.74, c.1, DPR  633/72) 									
        /// </summary>
        RF09,
        /// <summary>
        /// Intrattenimenti, giochi e altre attività di cui alla tariffa allegata al DPR 640/72 (art.74, c.6, DPR 633/72) 									
        /// </summary>
        RF10,
        /// <summary>
        /// Agenzie viaggi e turismo (art.74-ter, DPR 633/72) 									
        /// </summary>
        RF11,
        /// <summary>
        /// Agriturismo (art.5, c.2, L. 413/91) 									
        /// </summary>
        RF12,
        /// <summary>
        /// Vendite a domicilio (art.25-bis, c.6, DPR  600/73) 									
        /// </summary>
        RF13,
        /// <summary>
        /// Rivendita beni usati, oggetti d’arte, d’antiquariato o da collezione (art.36, DL 41/95) 									
        /// </summary>
        RF14,
        /// <summary>
        /// Agenzie di vendite all’asta di oggetti d’arte, antiquariato o da collezione (art.40-bis, DL 41/95) 									
        /// </summary>
        RF15,
        /// <summary>
        /// IVA per cassa P.A. (art.6, c.5, DPR 633/72) 									
        /// </summary>
        RF16,
        /// <summary>
        /// IVA per cassa (art. 32-bis, DL 83/2012) 									
        /// </summary>
        RF17,
        /// <summary>
        /// Altro									
        /// </summary>
        RF18,
        /// <summary>
        /// Regime forfettario (art.1, c.54-89, L. 190/2014)									
        /// </summary>
        RF19,
    }

    public enum TipoCassa
    {
        /// <summary>
        /// Cassa nazionale previdenza e assistenza avvocati e procuratori legali 									
        /// </summary>
        TC01,
        /// <summary>
        /// Cassa previdenza dottori commercialisti									
        /// </summary>
        TC02,
        /// <summary>
        /// Cassa previdenza e assistenza geometri									
        /// </summary>
        TC03,
        /// <summary>
        /// Cassa nazionale previdenza e assistenza ingegneri e architetti liberi professionisti									
        /// </summary>
        TC04,
        /// <summary>
        /// Cassa nazionale del notariato									
        /// </summary>
        TC05,
        /// <summary>
        /// Cassa nazionale previdenza e assistenza ragionieri e periti commerciali									
        /// </summary>
        TC06,
        /// <summary>
        /// Ente nazionale assistenza agenti e rappresentanti di commercio (ENASARCO)									
        /// </summary>
        TC07,
        /// <summary>
        /// Ente nazionale previdenza e assistenza consulenti del lavoro (ENPACL)									
        /// </summary>
        TC08,
        /// <summary>
        /// Ente nazionale previdenza e assistenza medici (ENPAM)									
        /// </summary>
        TC09,
        /// <summary>
        /// Ente nazionale previdenza e assistenza farmacisti (ENPAF)									
        /// </summary>
        TC10,
        /// <summary>
        /// Ente nazionale previdenza e assistenza veterinari (ENPAV)									
        /// </summary>
        TC11,
        /// <summary>
        /// Ente nazionale previdenza e assistenza impiegati dell'agricoltura (ENPAIA)									
        /// </summary>
        TC12,
        /// <summary>
        /// Fondo previdenza impiegati imprese di spedizione e agenzie marittime									
        /// </summary>
        TC13,
        /// <summary>
        /// Istituto nazionale previdenza giornalisti italiani (INPGI)									
        /// </summary>
        TC14,
        /// <summary>
        /// Opera nazionale assistenza orfani sanitari italiani (ONAOSI)									
        /// </summary>
        TC15,
        /// <summary>
        /// Cassa autonoma assistenza integrativa giornalisti italiani (CASAGIT)									
        /// </summary>
        TC16,
        /// <summary>
        /// Ente previdenza periti industriali e periti industriali laureati (EPPI)									
        /// </summary>
        TC17,
        /// <summary>
        /// Ente previdenza e assistenza pluricategoriale (EPAP)									
        /// </summary>
        TC18,
        /// <summary>
        /// Ente nazionale previdenza e assistenza biologi (ENPAB)									
        /// </summary>
        TC19,
        /// <summary>
        /// Ente nazionale previdenza e assistenza professione infermieristica (ENPAPI)									
        /// </summary>
        TC20,
        /// <summary>
        /// Ente nazionale previdenza e assistenza psicologi (ENPAP)									
        /// </summary>
        TC21,
        /// <summary>
        /// INPS									
        /// </summary>
        TC22,
    }

    public enum ModalitaPagamento
    {
        /// <summary>
        /// contanti									
        /// </summary>
        MP01,
        /// <summary>
        /// assegno									
        /// </summary>
        MP02,
        /// <summary>
        /// assegno circolare									
        /// </summary>
        MP03,
        /// <summary>
        /// contanti presso Tesoreria									
        /// </summary>
        MP04,
        /// <summary>
        /// bonifico									
        /// </summary>
        MP05,
        /// <summary>
        /// vaglia cambiario									
        /// </summary>
        MP06,
        /// <summary>
        /// bollettino bancario									
        /// </summary>
        MP07,
        /// <summary>
        /// carta di pagamento									
        /// </summary>
        MP08,
        /// <summary>
        /// RID									
        /// </summary>
        MP09,
        /// <summary>
        /// RID utenze									
        /// </summary>
        MP10,
        /// <summary>
        /// RID veloce									
        /// </summary>
        MP11,
        /// <summary>
        /// RIBA									
        /// </summary>
        MP12,
        /// <summary>
        /// MAV									
        /// </summary>
        MP13,
        /// <summary>
        /// quietanza erario									
        /// </summary>
        MP14,
        /// <summary>
        /// giroconto su conti di contabilità speciale									
        /// </summary>
        MP15,
        /// <summary>
        /// domiciliazione bancaria									
        /// </summary>
        MP16,
        /// <summary>
        /// domiciliazione postale									
        /// </summary>
        MP17,
        /// <summary>
        /// bollettino di c/c postale									
        /// </summary>
        MP18,
        /// <summary>
        /// SEPA Direct Debit									
        /// </summary>
        MP19,
        /// <summary>
        /// SEPA Direct Debit CORE									
        /// </summary>
        MP20,
        /// <summary>
        /// SEPA Direct Debit B2B									
        /// </summary>
        MP21,
        /// <summary>
        /// Trattenuta su somme già riscosse									
        /// </summary>
        MP22,
    }

    public enum TipoDocumento
    {
        /// <summary>
        /// fattura									
        /// </summary>
        TD01,
        /// <summary>
        /// acconto/anticipo su fattura									
        /// </summary>
        TD02,
        /// <summary>
        /// acconto/anticipo su parcella									
        /// </summary>
        TD03,
        /// <summary>
        /// nota di credito									
        /// </summary>
        TD04,
        /// <summary>
        /// nota di debito									
        /// </summary>
        TD05,
        /// <summary>
        /// parcella									
        /// </summary>
        TD06,
        /// <summary>
        /// autofattura									
        /// </summary>
        TD20,
    }

    public enum Natura
    {
        /// <summary>
        /// escluse ex art. 15									
        /// </summary>
        N1,
        /// <summary>
        /// non soggette									
        /// </summary>
        N2,
        /// <summary>
        /// non imponibili									
        /// </summary>
        N3,
        /// <summary>
        /// esenti									
        /// </summary>
        N4,
        /// <summary>
        /// regime del margine / IVA non esposta in fattura									
        /// </summary>
        N5,
        /// <summary>
        /// inversione contabile (per le operazioni in reverse charge ovvero nei casi di autofatturazione per acquisti extra UE di servizi ovvero per importazioni di beni nei soli casi previsti)									
        /// </summary>
        N6,
        /// <summary>
        /// IVA assolta in altro stato UE (vendite a distanza ex art. 40 c. 3 e 4 e art. 41 c. 1 lett. b,  DL 331/93; prestazione di servizi di telecomunicazioni, tele-radiodiffusione ed elettronici ex art. 7-sexies lett. f, g, art. 74-sexies DPR 633/72)									
        /// </summary>
        N7,
    }
}
