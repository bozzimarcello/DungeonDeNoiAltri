using DungeonDeNoiAltri;

Console.WriteLine("Dungeon De Noi Altri");
Console.WriteLine("====================");

Personaggio[] archivioPersonaggi = new Personaggio[10];

archivioPersonaggi[0] = new Guerriero("Conan");
archivioPersonaggi[1] = new Mago("Merlino");

Console.WriteLine("\n+++ Inizio partita");

Random random = new Random();
int numeroTurni = random.Next(1, 101);

for (int i = 0; i < numeroTurni; i++)
{

    Console.WriteLine("\n--Turno " + (i + 1));

    Personaggio personaggioAttaccante = archivioPersonaggi[i % 2];
    Personaggio personaggioDifensore = archivioPersonaggi[(i + 1) % 2];

    int attacco = personaggioAttaccante.Attacca();
    int difesa = personaggioDifensore.Difendi();
    Console.WriteLine(personaggioAttaccante.Nome + " attacca con " + attacco);
    Console.WriteLine(personaggioDifensore.Nome + " difende con " + difesa);
    if (attacco > difesa)
    {
        Console.WriteLine(personaggioDifensore.Nome + " perde 10 punti vita");
        personaggioDifensore.PuntiVita -= 10;
    }
    else
    {
        Console.WriteLine(personaggioAttaccante.Nome + " non ha superato la difesa");
    }
}

Console.WriteLine("+++ Fine partita");

Console.WriteLine("\n+++ Classifica");
for (int i = 0; i < 2; i++)
{
    Personaggio personaggio = archivioPersonaggi[i];
    Console.WriteLine(personaggio.Nome + " ha :");
    Console.WriteLine(personaggio.PuntiVita + " punti vita");
    Console.WriteLine(personaggio.PuntiEsperienza + " punti esperienza");
}
