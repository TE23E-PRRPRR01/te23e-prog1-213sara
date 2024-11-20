
using System.Runtime.ConstrainedExecution;
using Microsoft.VisualBasic;

Console.Clear();


Console.Write("Ange ett startvärde ");
int startvärde = int.Parse(Console.ReadLine());

Console.Write("Ange ett slutvärde ");
int slutvärde = int.Parse(Console.ReadLine());

int summa = 0;

for (var i = startvärde; i < slutvärde + 1; i++)
{
    summa += i;
}
    Console.WriteLine($"Summa: {summa}");

// två separata for loopar
Console.WriteLine("Alla jämna tal 1-20: ");
for (var i = startvärde; i < slutvärde; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i);
    }
    
}

Console.WriteLine("Alla udda tal 1-20: ");
for (var i = startvärde; i < slutvärde; i++)
{
     if (i % 2 != 0)
    {
        Console.Write(i);
    }
}