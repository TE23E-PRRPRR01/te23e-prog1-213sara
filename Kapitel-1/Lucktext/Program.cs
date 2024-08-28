
Console.Clear();
Console.Write("Vad heter du? ");
string namn = Console.ReadLine();
Console.WriteLine("Hej " + namn + "!");
Console.WriteLine("Vad är din favorit läsk");
string läsk = Console.ReadLine();
Console.WriteLine("Jag älskar också " + läsk + "!");
Console.WriteLine("Vad är din favorit färg? ");
string färg = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Tyvärr, jag vill ha turkos lol");
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Nu när jag känner dig är det dags för en utmaning...");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Vilken är den bästa marabou smaken...?");
string marabou = Console.ReadLine();
if (marabou == "mjolk choklad")
{
    Console.WriteLine("ok");
}
else if (marabou == "oreo")
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("👑");
}
else
{
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("du har dålig smak");
}