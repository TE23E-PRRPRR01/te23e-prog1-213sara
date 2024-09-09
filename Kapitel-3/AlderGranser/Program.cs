// Ett litet spel - vad får respektive ålder göra
Console.Clear();
Console.WriteLine("Ett litet spel - vad får respektive ålder göra");

// Fråga efter ålder
Console.WriteLine("Berätta din eller valfri ålder: ");
string ålder = Console.ReadLine();

// Konvertera text till ett heltal
int ålder = int.Parse(ålderText);

// Vad händer om...
if(ålder == 13)
{
    Console.WriteLine("13 åringar får skaffa sociala medier som ex. Instagram, Snapchat och Youtube!")
}
else if(ålder == 15)
{
    Console.WriteLine("15 åringar får ta körkort för mopeder, mopedbilar och traktorer!")
}
else if(ålder == 16)
{
    Console.WriteLine("16 åringar får börja övningsköra för att köra personbilar m.m.!")
}
