Console.Clear();

//Din uppgift är att skapa ett program som hanterar en lista med julklappar och kopplar dem till personer.
Console.WriteLine("🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁");
Console.WriteLine("Välkommen till julklappslistan!🎅🌟");
Console.WriteLine("Ett spel där du får vara tomten under julafron och dela ut julklappar till snälla barn");
Console.WriteLine("🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁");
Console.WriteLine(" ");

// Del 1 - Du ska skapa ett program för att dela ut julklappar.
    //Först anger man hur många julklappar som ska delas ut.
    Console.WriteLine("🎅 Hur många julklappar vill du dela ut i år?");
    Console.Write("Svar: ");
    string nummer = Console.ReadLine();
    int antal = int.Parse(nummer);
    
    //Sedan skriver man in julklapparna som sparas i en lista.
    List<string> listjulklappar = [];
    for (int i = 0; i < antal; i++)
    {
        Console.Write("🎅 Ange julklapp 🎁: ");
        listjulklappar.Add(Console.ReadLine());
    }

    Console.WriteLine(" ");
    Console.WriteLine("""
    Välj ett alternativ
    1. Byt ut en julklapp
    2. Lista alla julklappar
    3. Avsluta programmet
    """);
    Console.Write("Svar: ");
    string alternativ = Console.ReadLine();
    int svar = int.Parse(alternativ);

    //Man ska kunna byta ut julklapparna.
    if (svar == 1)
    {
        Console.WriteLine("Vilken julklapp vill du byta ut?");
        Console.ReadLine();
    }
    //Man ska kunna skriva ut listan på alla julklappar.
    else if(svar == 2)
    {
        Console.WriteLine("🎄 Julklappar 🎄");
        Console.WriteLine(listjulklappar);
    }
    else if (svar == 3)
    {

    }

    // Del 3 - Utöka programmet så att en person kan få flera julklappar.
