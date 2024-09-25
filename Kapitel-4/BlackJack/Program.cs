// Spelet BlackJack, även kallad 21:an
Console.Clear();
Console.WriteLine("Spelet BlackJack");

// Kortens värde är
// 2-10 = 2-10
// Kneckt, dam, kund = 10
// Ess = 1(eller 11)
// @todo slump måste efterlikna riktig kortlek, dvs 4x1, 4x2...4xkung

// Variabler
int summaSpelare = 0;
int summaDator = 0;
int kort = 0;

// Dela ut 2 kort till spelaren
kort = Random.Shared.Next(1, 11); // @todo Knäckt, dam & Kung?
summaSpelare += kort;
kort = Random.Shared.Next(1, 11); // @todo Knäckt, dam & Kung?
summaSpelare += kort;

// Dela ut 2 kort till datorn
kort = Random.Shared.Next(1, 11); // @todo Knäckt, dam & Kung?
summaDator += kort;
kort = Random.Shared.Next(1, 11); // @todo Knäckt, dam & Kung?
summaDator += kort;

// Flera gånger (loop)
while (true)
{
    // Skriv ut summorna
    Console.WriteLine($"Du har {summaSpelare} poäng");
    Console.WriteLine($"Datorn har {summaDator} poäng");

    // Stanna eller dra ett kort
    Console.WriteLine("Vill du ha ett nytt kort? (j/n)");
    string svar = Console.ReadLine().ToLower();
    if (svar == "n")
    {
        break;
    }

    // @todo datorn får ta extra kort <=17
    while (summaDator < 17)
    {
    kort = Random.Shared.Next(1, 11); // @todo Knäckt, dam & Kung?
    summaDator += kort;
    }

    // Den som har närmast 21 har vunnit?
    if (summaSpelare > summaDator && summaSpelare < 21)
    {
        Console.WriteLine("Du har vunnit!")
    }

    // Ta ett extra kort
        // Spelare
    kort = Random.Shared.Next(1, 11); // @todo Knäckt, dam & Kung?
    summaSpelare += kort;
    Console.WriteLine($"Du fick {kort}");
        // Datorn
    kort = Random.Shared.Next(1, 11); // @todo Knäckt, dam & Kung?
    summaDator += kort;
    Console.WriteLine($"Datorn fick {kort}");

    // Vem har vunnit
    // Har spelaren fått 21 har hen vunnit
    if (summaSpelare == 21)
    {
        Console.WriteLine("Du har vunnit!");
        break;
    }
    // Har datorn vunnit
    if (summaDator == 21)
    {
        Console.WriteLine("Datorn har vunnit!");
        break;
    }
    // Är spelaren tjock?
    if (summaSpelare > 21)
    {
        Console.WriteLine("Du har förlorat!");
    }
    // Är datorn tjock
    if (summaDator > 21)
    {
        Console.WriteLine("Du har vunnit!");
    }
}