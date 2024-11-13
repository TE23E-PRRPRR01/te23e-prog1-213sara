// En liten morsekod app
using System.Runtime.InteropServices;

Console.Clear();
Console.WriteLine("En liten morsekod app");
Console.InputEncoding = System.Text.Encoding.Unicode;

// Två listor
List<string> alfabetet = [  "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N",
                            "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "Å", "Ä",
                            "Ö", " "];

List<string> morsekod = [   ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---",
                            "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-",
                            "..-", "...-", ".--", "-..-", "-.--", "--..", ".--.-", ".-.-", "---.", "/" ];

// Läs in ett meddelande
Console.Write("Ange ett meddelande");
string meddelande = Console.ReadLine();

// Plocka ut morsetecknet för detta index
string morsetecken = morsekod[index]
Console.WriteLine($"{bokstav} är {morsetecknet}");

// Gå igenom meddelandet bokstav för bokstav (loop)
foreach (char bokstav in meddelande)
{
    // Uppslag i alfaetet efter index
    int index = alfabetet.IndexOf(bokstav.ToString());

    // Hittar morsetecken (A-Ö)?
    if (index >= 0)
    {
        Console.WriteLine($"{bokstav} finns på index {index}");

        // Plocka ut morsetecken för detta index
        string morsetecken = morsekod[index];
        // Console.WriteLine($"{morsetecken}");

        if (PosixSignal == '.') // '.'
        {
            // 100Hz, 200ms
            Console.Beep(1000, 200);
        }
        else // '-'
        { 
            Console.Beep(1000, 300);
        }

        // paus i koden
        Thread.Sleep(100);
    }
    else
    {
        Console.WriteLine("?");
    }

}