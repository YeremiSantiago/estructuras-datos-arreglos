
public class Program
{
    public static void Main(string[] args)
    {
        decimal[] ventas = new decimal[7];

        decimal input;
        decimal total = 0;
        decimal promedio;
        decimal ventaMax = 0;
        int diaVentaMax = 0;


        Console.WriteLine("Programa que registra la ventas de una tienda durante 7 días");
        for (int i = 0; i < ventas.Length; i++)
        {
            Console.Write($"Ingresa la venta registrada el dia {i + 1}: ");
            while (!decimal.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Entrada invalida. Ingrese un numero decimal valido");
            }

            ventas[i] = input;
            Console.WriteLine("Venta registrada");
            total += input;

            if (ventaMax < input)
            {
                diaVentaMax = i + 1;
                ventaMax = input;

            }
        }

        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("El total vendido a la semana es: " + total);
        promedio = total / 7;
        Console.WriteLine($"El promedio Diario es: " + promedio);
        Console.WriteLine($"El dia con la venta maxima es: " + diaVentaMax);



    }
}