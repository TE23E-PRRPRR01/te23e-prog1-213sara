// Program för att räkna ut BMI
Console.Clear();
Console.WriteLine("Program för att räkna ut BMI.");

// Ange längd(M)
Console.Write("Ange längd(m): ");
int lenght = int.Parse(Console.ReadLine());

// Ange vikt(KG)
Console.Write("Ange vikt(kg): ");
int weight = int.Parse(Console.ReadLine());

// Räkna ut BMI
int BMI = weight/(lenght*lenght);

// Skriver ut resultatet
Console.WriteLine($"BMI:et är: {BMI}.");