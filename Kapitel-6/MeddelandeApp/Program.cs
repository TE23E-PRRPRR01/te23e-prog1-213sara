/* *********************************************
*  ******************* MAIN ********************
   ********************************************* */

VisaPresentation();

// Variabler
string filnamn = "meddelande.txt";

// Programloopen
while (true)
{
    VisaMeny();
    string val = Console.ReadLine();

    if (val == "1")
    {
        SparaMeddelande(filnamn);
    }
    else if(val == "2")
    {
        LäsaMeddelande(filnamn);
    }
    else if(val == "3")
    {
        Console.WriteLine("Tack för idag!");
        break;
    }
    else{
        Console.WriteLine("Fel val! Försök igen!");
    }
}

/* *********************************************
*  ****************** METOD ********************
   ********************************************* */
static void VisaPresentation()
{
    Console.Clear();
    Console.WriteLine("""
    ==========================================
    Program för att spara meddelande på disken
    Av xxx yyy 2025
    ==========================================
    """);
}

/// <summary>
/// Visar programmets meny med alla programmets funktioner
/// </summary>

static void VisaMeny()
{
    Console.WriteLine("""
    
    1. Spara meddelande
    2. Läsa meddelande
    3. Avsluta programmet
    """);
    Console.Write("Ange ditt val: ");
}

static string SparaMeddelande(string filen)
{
    Console.WriteLine("Ange ett meddelande");
    string meddelande = Console.ReadLine();
    File.WriteAllText("meddelande.txt", meddelande);
    Console.WriteLine("Ditt meddelande har sparats!");
    return filen;
}

/// <summary>
/// Läser in från textfilen och skriver meddelandet
/// </summary>

static void LäsaMeddelande(string filen)
{
    string meddelande = File.ReadAllText("meddelande.txt");
    Console.WriteLine("Ditt senaste meddlande");
    Console.WriteLine("---------------------------------");
    Console.WriteLine(meddelande);
    Console.WriteLine("---------------------------------");
}