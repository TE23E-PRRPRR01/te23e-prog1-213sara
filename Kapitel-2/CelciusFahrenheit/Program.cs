// Program för att konvertera temperaturen i Celsius till Farenheit

Console.Clear();
Console.WriteLine("Program för att konvertera temperaturen i Celsius till Fahrenheit");

// Läser in Temp i Celcius
Console.Write("Ange temperatur i Celius: ");
int tempCelsius = int.Parse(Console.ReadLine());c

// Konvertera till Fahrenheit
int tempFahrenheit = tempCelsius*9/5 + 32;

// Skriver ut resultatet
Console.WriteLine($"{tempCelsius}Temperaturen i Celcius är {tempFahrenheit} Farenheit.");