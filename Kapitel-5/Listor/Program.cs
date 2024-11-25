Console.Clear();
Console.WriteLine("Mikroövning: Listor");

// Fråga om namn
Console.WriteLine("Vad heter du?");
string namn = Console.ReadLine();

// Skapa en tom lista av stränger
List<string> listaBöcker = [];
Console.WriteLine("Skriv in 3 kända böcker: ");

// BOK NUMMER 1 + ta bort + lägg till igen
Console.WriteLine("Bok 1: ");
string bok1 = Console.ReadLine();
listaBöcker.Add(bok1);
listaBöcker.Remove(bok1);
listaBöcker.Add(bok1);

// BOK NUMMER 2
Console.WriteLine("Bok 2: ");
string bok2 = Console.ReadLine();
listaBöcker.Add(bok2);

// BOK NUMMER 3
Console.WriteLine("Bok 3: ");
string bok3 = Console.ReadLine();
listaBöcker.Add(bok3);

// Skriv ut alla filnamn
Console.WriteLine($"Alla böcker: {string.Join(",", listaBöcker)}");

// Söka efter namn