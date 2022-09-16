![FatturaElettronica.XMLNodes](https://etabetaweb.files.wordpress.com/2018/11/fattura-elettronica.jpg)


# Fattura Elettronica XMLNodes 1.7.1

Il progetto **FatturaElettronica.XMLNodes** nasce dall’esigenza di creare una **libreria** che permetta di rappresentare tutti i **nodi previsti nel formato XML** (eXtensible Markup Language) della **Fattura Elettronica**. Basata sulla **versione 1.7.1** delle specifiche tecniche  dell’**Agenzia delle Entrate**, la **libreria** è sviluppata in **C# e NET Standard 2.0**.



# Organizzazione del repository

- **AppCode**: file sorgenti della libreria;
- **AppIcon**: file di icona;
- **CodiceEsempio**: file con il codice di esempio di un'applicazione per l'utilizzo della libreria in versione C# e Visual Basic;
- **Documentazione**: documentazione tecnica dell’Agenzia delle Entrate e rappresentazione tabellare;



# Note al codice di esempio

La soluzione comprende un esempio per utilizzare, tramite code-behind, i metodi e le proprietà della libreria.

**Il codice dei esempio non è esaustivo, in quanto non utilizza tutti i metodi della libreria, si prega di fare riferimento alle specifiche tecniche dell'Agenzia delle Entrate per l'elenco completo dei nodi previsti**.

Il codice principale si trova nella funzione GeneraXML e i parametri sono passati direttamente da codice ma possono essere passati anche tramite campi TextBox con le opportune modifiche.

La libreria prevede due metodi principali "FatturaHeader" e "FatturaBoody". Questi sono i due nodi principali del file XML che racchiudono tutti i nodi figlio contenenti le informazioni previste dalla fattura elettronica.

**Dal codice di esempio è possibile comprendere come**:

- aggiungere un nodo con occorrenza singola;
- assegnare il valore alla proprietà di un nodo con occorrenza singola;
- assegnare il nodo figlio al nodo padre;
- aggiungere un nodo con occorrenza multipla;
- assegnazione delle proprietà al nodo con occorrenza multipla;

Inoltre, il codice serializza il file XML e lo salva sul computer.



# Installazione come package NuGet

FatturaElettronica.XMLNodes può essere scaricato anche come package [NuGet](https://www.nuget.org/packages/FatturaElettronica.XMLNodes/). 

Per installarlo è sufficiente utilizzare il seguente comando tramite il Package Manager.

```c#
PM> Install-Package FatturaElettronica.XMLNodes -Version 1.7.1.1
```



# Guida per l'utilizzo

![copertina libro](https://etabetaweb.files.wordpress.com/2022/09/cover-fatturaelettronica.xmlnodes-v1.7.1.jpg?w=640)

In **esclusiva** sullo store **[Amazon](https://amzn.to/3UjU4T4)** è disponibile, in **formato digitale**, la **guida all'utilizzo della libreria** open source per la generazione della Fattura Elettronica.

**La guida si rivolge**, principalmente, agli **sviluppatori principianti** che desiderano utilizzare la libreria nei loro programmi.

**Nella guida** sono contenuti i **commenti al codice di esempio** non altrimenti recuperabili dai sorgenti presenti nel repository di GitHub.

Vi sono anche **informazioni utili** che possono essere utilizzate da **utenti avanzati** che vogliono **approfondire alcune tematiche relative alla Fatturazione Elettronica**.

È importante che il lettore abbia **familiarità con lo sviluppo del software** e con i concetti base della **programmazione ad oggetti**.



**[[ACQUISTA ONLINE](https://amzn.to/3UjU4T4)]**



### Indice dei contenuti

- Termini e condizioni per la copia, distribuzione e modifica del codice;
- La fattura elettronica;
- La fattura elettronica e le differenze con la fattura cartacea;
- I vantaggi della fattura elettronica;
- Le informazioni obbligatorie;
- La struttura del file XML;
- XML: visione generale;
- Come trasmettere il file XML;
- Variazioni alle specifiche tecniche presenti nella versione 1.7.1;
- Download del codice sorgente da GitHub;
- Organizzazione del repository;
- Utilizzo del progetto in Visual Studio;
- Aggiunta dei riferimenti al progetto;
- Download della libreria da NuGet;
- Utilizzo della libreria;
- Aggiunta dell’istanza alla classe;
- Utilizzo dei metodi e delle proprietà della classe;
- Aggiunta di un metodo con occorrenza singola;
- Assegnazione del valore ad una proprietà del metodo;
- Assegnazione del metodo figlio al metodo padre;
- Aggiunta di un metodo con occorrenza multipla;
- Assegnazione delle proprietà al nodo con occorrenza multipla;
- Serializzazione finale dei nodi;
- Codice di esempio in Visual Basic;
- Codice di esempio in C#;
