# Stampante WPF
## Descrizione
Questo programma implementa un'applicazione WPF che simula una stampante che stampa pagine colorate. La stampante è rappresentata dalla classe **Stampante**, mentre le pagine sono rappresentate dalla classe **Pagina**. Il programma consente di visualizzare lo stato dell'inchiostro e della carta e permette di eseguire operazioni come la sostituzione del colore e la stampa di pagine.
## Classi

### `Stampante`

La classe **Stampante** rappresenta una stampante con quattro serbatoi di colore (CMYB) e un cassetto di fogli. Le sue funzionalità includono:

- **Stampa**: Il metodo `Stampa` prende in input una pagina e restituisce `true` se è possibile stamparla (abbastanza inchiostro e carta disponibili), altrimenti restituisce `false`.

- **StatoInchiostro**: Il metodo `StatoInchiostro` restituisce la quantità di inchiostro presente in un serbatoio (colore).

- **StatoCarta**: Il metodo `StatoCarta` restituisce la quantità di fogli di carta disponibili nel cassetto.

- **SostituisciColore**: Il metodo `SostituisciColore` sostituisce un serbatoio di inchiostro (colore) e lo riporta a 100.

- **AggiungiCarta**: Il metodo `AggiungiCarta` aggiunge fogli di carta fino a un massimo di 200 nel cassetto.


### `Pagina`

La classe `Pagina` rappresenta una pagina colorata con quattro attributi, che corrispondono ai colori CMYB (Ciano, Magenta, Giallo, Nero). La classe include due costruttori: uno che accetta valori specifici per i colori con un massimo di 3 e un costruttore che crea una pagina con colori casuali.

## MainWindow

L'interfaccia utente contiene 4 pulsanti per cambiare il serbatoio il colore della stampante, aggiungere carta, eseguire un test di stampa e stampare una pagina specifica. Inoltre la finestra visualizza anche lo stato corrente dell'inchiostro e della carta.

## Diagramma UML

Il diagramma UML si trova nel repository [StampanteUML](https://github.com/MicheleCasadei706/WPFStampante/blob/main/StampanteUML.png?raw=true).
