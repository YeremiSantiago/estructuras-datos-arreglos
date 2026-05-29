public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Programa que almacena temperaturas de una ciudad durante 10 días");

        decimal[] temperaturas = new decimal[10];
        decimal input;
        decimal sumatoria = 0;
        int diasPorEncima = 0;
        decimal tempHigh = decimal.MinValue;
        decimal tempLow = decimal.MaxValue;

        for (int i = 0; i < temperaturas.Length; i++)
        {
            Console.Write($"Ingresa la temperatura registrada el dia {i + 1}: ");
            while (!decimal.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Entrada invalida. Por favor ingresa un numero decimal valido");
            }

            temperaturas[i] = input; 
            sumatoria += input;

            if(input > 30.0m)
            {
                diasPorEncima++;
            }

            if(tempHigh < input)
            {
                tempHigh = input;
            }

            if(tempLow > input)
            {
                tempLow = input;
            }
        }

        Console.WriteLine($"La temperatura mas alta fue de {tempHigh}°C");
        Console.WriteLine($"La temperatura mas baja fue de {tempLow}°C");
        Console.WriteLine($"El promedio de temperaturas fue de {sumatoria / temperaturas.Length}");
        Console.WriteLine($"La cantidad de dias donde la temperatura estuvo por encima de 30°C fue de {diasPorEncima}");
    }
}