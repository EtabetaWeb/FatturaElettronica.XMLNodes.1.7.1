![FatturaElettronica.XMLNodes](https://etabetaweb.files.wordpress.com/2018/11/fattura-elettronica.jpg)


# Fattura Elettronica XMLNodes 1.7.1

Il progetto nasce dall’esigenza di creare una **libreria** che permetta di rappresentare tutti i **nodi previsti nel formato XML** (eXtensible Markup Language) della **Fattura Elettronica**. Basata sulla **versione 1.7.1** delle specifiche tecniche dell’**Agenzia delle Entrate**, la **libreria** è sviluppata in **C# e NET Standard 2.0**.



# Organizzazione del repository

- **AppCode**: file sorgenti della libreria;
- **AppIcon**: file di icona;
- **CodiceEsempio**: file con il codice di esempio di un'applicazione per l'utilizzo della libreria in versione C# e Visual Basic;
- **Documentazione**: file di specifiche tecniche, rappresentazione tabellare ed elenco errori SDI;



# Codice di esempio

La soluzione comprende un esempio per utilizzare, tramite code-behind, i metodi e le proprietà della libreria.

**Il codice dei esempio non è esaustivo, in quanto non utilizza tutti i metodi della classe, e vi rimando alle specifiche tecniche dell'Agenzia delle Entrate per l'elenco completo dei nodi previsti**.

Il codice principale si trova nella funzione GeneraXML e i parametri sono passati direttamente da codice ma possono essere passati anche tramite campi TextBox con le opportune modifiche.

La classe prevede due metodi principali "FatturaHeader" e "FatturaBoody". Questi sono i due nodi principali del file XML che racchiudono tutti i nodi figlio contenenti le informazioni previste dalla fattura elettronica.

**Dal codice di esempio è possibile comprendere come**:

- aggiungere un nodo con occorrenza singola;
- assegnare il valore alla proprietà di un nodo con occorrenza singola;
- assegnare il nodo figlio al nodo padre;
- aggiungere un nodo con occorrenza multipla;
- assegnazione delle proprietà al nodo con occorrenza multipla;

Inoltre, il codice serializza il file XML e lo salva sul computer.



# Installazione come package NuGet

FatturaElettronica.XMLNodes può essere scaricato anche come package [NuGet](https://www.nuget.org/packages/FatturaElettronica.XMLNodes/). 

Per installarlo è sufficiente utilizzare il seguente comando tramite il Package Manager (sostituire le x con il valore appropriato della versione richiesta).

```c#
PM> Install-Package FatturaElettronica.XMLNodes -Version 1.x.x
```

Oppure, da riga di comando (CMD), con .NET Core:

```c#
dotnet add package FatturaElettronica.XMLNodes
```

Oppure, dalla Console di Gestione Pacchetti in Visual Studio.


