// Dungeon spel med massor av rum
using Microsoft.VisualBasic;

Console.Clear();
Console.WriteLine("Ett Dungeon-spel");

// Programvariabler (state variables)
string rum = "hallen";
List<string> inventarie = [];

// Spelloop
while (true)
{
    // Är vi i hallen?
   if (rum == "hallen")
   {
        Console.WriteLine("Du är i hallen");
        Console.WriteLine("1. Titta runt");
        Console.WriteLine("2. Gå rill nästa rum");
        Console.Write("Vad vill du göra? ");
        string val = Console.ReadLine();

    if(val == "1")
    {
        Console.WriteLine("Du ser nyckeln på golvet");
        Console.Write("Vill du plocka upp nyckeln?");
        val == Console.ReadLine().ToLower();

        if (val == "j")
        {
            inventaire.Add("Nyckel");
            Console.WriteLine("Du plockade bort nyckeln");
        }
        else
        {
            Console.WriteLine("Du lämnar nyckeln på golvet!");
        }

    }
   
   else if(val == "2")
   {
     rum = "köket"
     Console.WriteLine("...du går in i köket...");
     Console.WriteLine("I köket ser du en lapp");
     Console.WriteLine("Vill du läsa lappen?(J/N)");
    val == Console.ReadLine().ToLower();

   }
    else if(val == "Ja")
    {
        Console.WriteLine("På lappen står det "RYM GENAST FRÅN HUSET OCH GÅ INTE NED I KÄLLAREN!!"");

    }
   }
}