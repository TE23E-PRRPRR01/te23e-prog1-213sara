// Loop mätare
Console.Clear();
Console.WriteLine("Räkna....");

//namn
Console.WriteLine("Vad heter du?");
string namn = Console.ReadLine();

// upprepa namn
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Antal: {i + ". " + namn}" );
}