// Frågesport - Hur mycket kan du om jorden?
Console.Clear();
Console.WriteLine("""
Frågesport:
"Hur mycket kan du om världen?
""");
int points = 0;

// Fråga om användarens namn
Console.WriteLine("Namn: ");
Console.ReadLine();

// Fråga 1
Console.WriteLine("""
Fråga nr 1: Vilket är världens största ocean?
a) Antlanten
b) Indiska oceanen
c) Stilla havet
""");
string svar1 = Console.ReadLine();
if (svar1 == "c")
{
    points++;
    Console.WriteLine("RÄTT!👍");
}
else
{
    Console.WriteLine("FEL!👎");
}

// Fråga 2
Console.WriteLine("""
Fråga nr 2: Hur många öar finns på jorden?
a) 300 000+
b) 600 000+
c) 900 000+
""");
string svar2 = Console.ReadLine();
if (svar2 == "b")
{
  points++;
  Console.WriteLine("RÄTT!👍");
}
else
{
  Console.WriteLine("FEL!👎");
}

// Fråga 3
Console.WriteLine("""
Fråga nr 3: Hur många länder finns det i världen?
a) 195
b) 196
c) 197
""");
string svar3 = Console.ReadLine();
if (svar3 == "a")
{
  points++;
  Console.WriteLine("RÄTT!👍");
}
else
{
  Console.WriteLine("FEL!👎");
}

// Fråga 4
Console.WriteLine("""
Fråga nr 4: Vilka 2 länder har en nationalldjuret örnen?
a) Sri lanka och Peru
b) Filippinerna och Andorra
c) USA och Moldavien
""");
string svar4 = Console.ReadLine();
if (svar4 == "c")
{
  points++;
  Console.WriteLine("RÄTT!👍");
}
else
{
  Console.WriteLine("FEL!👎");
}


// Slut
Console.WriteLine($"Du fick {points} poäng!");
if (points == 0)
{
  Console.WriteLine("Du fick 0/4 rätt👎");
}
else if (points ==2)
{
  Console.WriteLine("Du fick 2/4 rätt😐");
}
else if(points == 3)
{
  Console.WriteLine("Du fick 3/4 rätt😐");
}
else if(points == 4)
{
    Console.WriteLine("Du fick 4/4(ALLA) rätt🎉");
}

Console.WriteLine("Bra kört!)");
