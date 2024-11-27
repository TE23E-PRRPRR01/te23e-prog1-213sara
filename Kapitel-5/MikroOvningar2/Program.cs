Console.Clear();
Console.WriteLine("Mikroövning: Lista med 5 namn");

// Fråga om användarens namn
Console.WriteLine("Vad heter du?");
string anvandarnamn = Console.ReadLine();

//variabler

// Låt användaren välja en uppgift
Console.WriteLine("1. Lista med namn");
Console.WriteLine("2. Lista med orter");
Console.WriteLine("3. Lista med årtal");
Console.WriteLine("4. Lista med språk");
Console.WriteLine("5. Lista med favoritdrycker");
Console.WriteLine("--------------------------------");
Console.WriteLine("                                ");
string val = Console.ReadLine();

if (val == "1")
{
    // Skapa en lista med 5 namn(råkade göra så att användaren själv får skriva in namnen)
    List<string> listaNamn = [];
    Console.WriteLine("                                ");
    Console.WriteLine("Ange 5 namn");
    Console.WriteLine("--------------------------------");
    Console.WriteLine("                                ");

    // Namn 1 - M
    Console.WriteLine("Ange ett namn på bokstaven M: ");
    string namn1 = Console.ReadLine();
    listaNamn.Add(namn1);

    // Namn 2 - T
    Console.WriteLine("Ange ett namn på bokstaven T: ");
    string namn2 = Console.ReadLine();
    listaNamn.Add(namn2);

    // Namn 3 - S
    Console.WriteLine("Ange ett namn på bokstaven S: ");
    string namn3 = Console.ReadLine();
    listaNamn.Add(namn3);

    // Namn 4 - E
    Console.WriteLine("Ange ett namn på bokstaven E: ");
    string namn4 = Console.ReadLine();
    listaNamn.Add(namn4);

    // Namn 5 - K
    Console.WriteLine("Ange ett namn på bokstaven K: ");
    string namn5 = Console.ReadLine();
    listaNamn.Add(namn5);

    // Skriv upp listan
    Console.WriteLine("                                ");
    Console.WriteLine("--------------------------------");
    Console.WriteLine($"Alla namn: {string.Join(",", listaNamn)}");
    Console.WriteLine("                                ");
}
else
{
    if (val == "2")
    {
        // 2. Skapa en lista med 5 orter
        List<string> listaOrter = ["Stockholm", "Nykvarn", "Jakobsberg", "Flemingsberg", "Tullinge"];
        Console.WriteLine($"Alla orter: {string.Join(",", listaOrter)}");

    }
    else
    {
        if (val == "3")
        {
            // 3. Skapa en lista med 5 årtal
            List<int> listaÅrtal = [1492, 1776, 1914, 1945, 1969];
            Console.WriteLine($"Alla årtal: {string.Join(",", listaÅrtal)}");
            Console.WriteLine("                                ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("                                ");

        }
        else
        {
            if (val == "4")
            {
                // 4. Visa första och sista objekt i en lista
                List<string> listaSpråk = ["Svenska", "Engelska", "Franska", "Spanska", "Tyska"];
                Console.WriteLine($"Alla Språk: {string.Join(",", listaSpråk)}");
                Console.WriteLine("Första språket: " + listaSpråk[1]);
                Console.WriteLine("                                ");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("                                ");
            }
            else
            {
                if (val == "5")
                {
                    // Skapa en lista med favoritdrycker
                    List<string> listaDrycker = ["Coca Cola", "Sprite", "Festis", "Spanska", "Tyska"];
                    Console.WriteLine($"Alla Drycker: {string.Join(",", listaDrycker)}");
                    Console.WriteLine("Detta är min favo favo favo dryck: " + listaDrycker[3]);
                    Console.WriteLine("                                ");
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("                                ");
                }
                else
                {
                    
                }
            }
        }

    }
}


