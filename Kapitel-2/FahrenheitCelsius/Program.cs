// Program för att konvertera temperaturen i Fahrenheit till Celsius

Console.Clear();
Console.WriteLine("Program flr att konvertera temperaturen i Fahrenheit till Celsius");

// Läser in Temp i Fahrenheit
Console.Write("Ange temperatur i Fahrenheit: ");
double tempFahrenheit = double.Parse(Console.ReadLine());

// Konvertera till Celsius
double tempCelsius = double.Parse(tempFahrenheit- 32)* 5/9;

// Skriver ut resultatet med decimaler
Console.WriteLine($"{tempFahrenheit} F blir {tempCelsius} C");