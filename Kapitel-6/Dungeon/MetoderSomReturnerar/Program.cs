Console.Clear();
//* **************************************************************************************
//**********************************        MAIN        ***********************************
//************************************************************************************** */
// Använd metoder här!
// Addera(3,5);
// Console.WriteLine($"Svaret är {svar}");
// Console.WriteLine(Addera(3,5));
// Console.WriteLine($"3+5 = {Add}");

string namn = "Joan";
Console.WriteLine($"{namn} baklänges är {VändText(namn)}");

// Exempel multiplikation
double resultat = Multiplicera(7, 6);
Console.WriteLine(resultat);

// Exempel division
double resultat = Dividera(7, 7);
Console.WriteLine(resultat);

//* **************************************************************************************
//********************************        METODER        **********************************
//************************************************************************************** */
// Skapa metoderhär!


static int Addera(int tal1, int tal2) // signatur
{
    int summa = tal1 + tal2;
    return summa;
}

/// <summary>
/// Vänder på texten
/// </summary>
/// <param name="text"></param>
static string VändText(string text)
{
    string omvändText = "";
    for (int i = text.Length -1; i >=0; i--)
    {
        omvändText += text[i];
    }
    return omvändText;
}
// Uppgift 6.6: Skapa ett program som innehåller double Dividera(double tal1, double tal2)




/// <summary>
/// Uppgift 6.6: Skapa ett program som innehåller double Multiplicera(double tal1, double tal2)
/// </summary>
/// <param name="text"></param>

static double Multiplicera(double tal1, double tal2)
{
    double tal = tal1*tal2;
    return tal;
}

static double Dividera(double tal1, double tal2)
{
    double tal = tal1/tal2;
    return tal;
}

/// <summary>
/// Säkert sätt att läsa in ett tal (utan att det kraschar)
/// </summary>
static void LäsInHeltal()
{
    int tal = 0;
    string textSomBlirTal = Console.ReadLine();
    bool lyckades = int.TryParse(textSomBlirTal, out tal)
}