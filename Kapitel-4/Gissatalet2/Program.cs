// Spelet - gissa ett slumptal 1-100
Console.Clear();
Console.WriteLine("Spelet - gissa ett slumptal 1-100");
int gissningar = 0;

// Slumpar ett tal 1-100
Console.WriteLine("Välj ett intervall att spela mellan(rekommenderat: 1-100, 1-1000)");
// Välj ett maximum värde
Console.Write("Välj ett min värde: ");
int min = int.Parse(Console.ReadLine());

// Välj ett minimum värde
Console.Write("Välj ett max värde: ");
int max = int.Parse(Console.ReadLine());

int slumptal = Random.Shared.Next(min, (max + 1));

// Upprepning - loop
while (true)
{
    // Ställ fråga till användaren
    Console.Write($"Gissa ett tal ({min}-{max}): ");
    int gissning = int.Parse(Console.ReadLine());
    gissningar++;

    // Kontroll om gissning är rätt?
    if (gissning == slumptal)
    {
        Console.WriteLine($"Rätt gissat!🏆, på {gissningar}st gissningar");
    
        break;
    }
    else
    {
        if (gissning > slumptal)
        {
            Console.WriteLine("För högt!😡");
        }
        else
        {
            Console.WriteLine("För lågt!😡");
        }
        while (true)
        {
        
        // vill användaren gissa en gång till?
        Console.Write("Vill du gissa en gång till(ja/nej): ");
        string svar = Console.ReadLine();
        if (svar == "nej")
        {
        break;
        }
        else
        {

        }
        }
    }
}

// Slut på spelet
Console.WriteLine("SLUT!, Tack för att du spelade mitt fina spel!🎉");