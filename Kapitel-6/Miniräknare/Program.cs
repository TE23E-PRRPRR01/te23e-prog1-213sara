/* *************************************************
 * Namn: Miniräknare i konsolen
 * Beskrivning: Ett program för att utföra matematiska operationer
 * Datum: 2025-01-01
*********************************************** */

/* *********************************************
*  ******************* MAIN ********************
   ********************************************* */
VisaVälkomsttext();

// Variabler

// Programloopen
using System.Runtime.ConstrainedExecution;

while (true)
{
    VisaMeny();
    string val = Console.ReadLine();

    if (val == "1")
    {
        AppDomainUnloadedException();
    }
    else if(val == "2")
    {
        Subtraktion();
    }
    else if(val == "3")
    {
        Multiplikation();
    }
    else if(val == "4")
    {
        Division();
    }
    else if(val == "5")
    {
        Console.WriteLine("👋 Tack för att du använde miniräknaren!");
        break;
    }
    else
    {
        Console.WriteLine("⚠️ Ogiltigt val. Försök igen.");
    }
}

/* *********************************************
*  ****************** METOD ********************
   ********************************************* */

static void VisaVälkomsttext()
{
    Console.Clear();
    Console.WriteLine("""
    ==========================================
                 🧮 Miniräknare
    ==========================================
    """);
}

/// <summary>
/// Visar programmets meny och alla programmets funktioner
/// </summary>
 
static void VisaMeny()
{
    Console.WriteLine("""
    
    1. Addition
    2. Subtraktion
    3. Multiplikation
    4. Division
    5. Avsluta
    """);
    Console.Write("Ange ditt val: ");
}

static void Addition()
{
    string val = Console.ReadLine();
}

static void Subtraktion()
{
    string val = Console.ReadLine();
}

static void Division()
{
    string val = Console.ReadLine();
}

static void Avsluta()
{
    string val = Console.ReadLine();
}

Ange ditt val: 1
====================
Ange tal 1: 5
Ange tal 2: 3
Svar: 5 + 3 = 8

Ange ditt val: 2
====================
Ange tal 1: 5
Ange tal 2: 3
Svar: 5 - 3 = 2

Ange ditt val: 3
====================
Ange tal 1: 5
Ange tal 2: 3
Svar: 5 * 3 = 15

Ange ditt val: 4
====================
Ange tal 1: 5
Ange tal 2: 3
Svar: 5 / 3 = 1,66666666666667

Ange ditt val: 5