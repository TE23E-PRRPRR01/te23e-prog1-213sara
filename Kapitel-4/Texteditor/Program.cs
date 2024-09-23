Console.Clear();

// Litet meny program
Console.WriteLine("");

// Variabel för valet
string val = "";

// Programloop som snurrar tills användaren säger avsluta
while (true)
{
    // Visar en meny och läser användarens val
    Console.Write("""
    1. Tid
    2. Datum
    3. Avsluta
    Välj ett av alternativen ovan: 
    """);

    val = Console.ReadLine();

    // Hantera användarens val
    if (val == "1")
    {

        Console.WriteLine("Tid:" + DateTime.Nowstring("hh:mm:ss"));


    }
    else if (val == "2")
    {
        Console.WriteLine("Datum:" + DateTime.Nowstring("yy:MM:dd"));

    else if (val == "3")
        {
            Console.WriteLine("Avslutar...");
            break;
        }
        else
        {
            Console.WriteLine("Du valde inget giltigt alternativ, försök igen!");
        }

    }
}