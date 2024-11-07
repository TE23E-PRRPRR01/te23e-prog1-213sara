// Slumpa många tal och spara i lista
Console.Clear();
Console.WriteLine("Slumpa många tal och spara i lista");

// Globala variabler
// En lista för heltal
List<int> listaslumptal = [];

// Be användaren ange antal slumpade tal
Console.WriteLine("Ange antal slump tal");
int antal = int.Parse(Console.ReadLine());

// Be användaren ange min och max slumptal
Console.Write("Ange minsta värde för slumptal: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Ange högsta värde för slumptal: ");
int max = int.Parse(Console.ReadLine());

// Loopa 5 ggr
for (int i = 0; i < antal; i++)
{

    // Slumpa ett tal 1-100
    int slumptal = 0;
    slumptal = Random.Shared.Next(min, max);
    Console.WriteLine($"Slumpat tal: {i + 1}: {slumptal}");

    // Lägg till slumptalet i listan
    listaslumptal.Add(slumptal);

    Console.WriteLine($"slumpat tal {i + 1}: {slumptal}");

}