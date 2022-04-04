Console.WriteLine("--- IL LIBRO DI OGGI: CLEAN CODE di Robert C.Martin ---");
Console.WriteLine("");

Console.Write("Inserisci l'ISBN del libro: ");
string richiestaIsbn = Console.ReadLine();
long isbn = long.Parse(richiestaIsbn);

Console.Write("Inserisci il numero delle pagine del libro: ");
string richiestaNumeroDellePagine = Console.ReadLine();
int numeroDellePagine = int.Parse(richiestaNumeroDellePagine);

Console.Write("Inserisci il peso del libro: ");
string richiestaPesoDelLibro = Console.ReadLine();
int pesoDelLibro = int.Parse(richiestaPesoDelLibro);

Console.Write("Inserisci la larghezza del libro: ");
string richiestaLarghezzaDelLibro = Console.ReadLine();
double larghezzaDelLibro = Convert.ToDouble(richiestaLarghezzaDelLibro);

Console.Write("Inserisci la lunghezza del libro: ");
string richiestaLunghezzaDelLibro = Console.ReadLine();
double lunghezzaDelLibro = Convert.ToDouble(richiestaLunghezzaDelLibro);

Console.Write("Inserisci la profondita del libro: ");
string richiestaProfonditaDelLibro = Console.ReadLine();
double profonditaDelLibro = Convert.ToDouble(richiestaProfonditaDelLibro);

Console.Write("Quante recensioni ha ricevuto il libro? ");
string richiestaNumeroDiRecensioni = Console.ReadLine();
int numeroDiRecensioni = int.Parse(richiestaNumeroDiRecensioni);

Console.Write("Qual'è la valutazione media del libro? ");
string richiestaValutazioneMedia = Console.ReadLine();
double valutazioneMedia = Convert.ToDouble(richiestaValutazioneMedia);

Console.Write("è disponibile una versione Kindle del libro? ");
string richiestaKindle = Console.ReadLine();

Console.Write("è disponibile la versione con la copertina flessibile? ");
string richiestaCopertinaFlessibile = Console.ReadLine();

Console.WriteLine("");
Console.WriteLine("");


Console.WriteLine("--- IL LIBRO DI OGGI: CLEAN CODE di Robert C.Martin ---");
Console.WriteLine("");
Console.WriteLine("Informazioni generiche:");
Console.WriteLine($"ISBN: {isbn}");
Console.WriteLine($"Numero delle pagine: {numeroDellePagine} pagine");
Console.WriteLine($"Peso del libro: {pesoDelLibro}g");
Console.WriteLine($"Dimensioni del libro: {larghezzaDelLibro} x {lunghezzaDelLibro} x {profonditaDelLibro} cm");
Console.WriteLine("");
Console.WriteLine("Informazioni Amazon:");
Console.WriteLine($"Numero di recensioni: {numeroDiRecensioni} recensioni");
Console.WriteLine($"Valutazione media: {valutazioneMedia} stelle su 5");
Console.WriteLine($"Kindle disponibile: {richiestaKindle}");
Console.WriteLine($"Copertina flessibile disponibile: {richiestaCopertinaFlessibile}");





