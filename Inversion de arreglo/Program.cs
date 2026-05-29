public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Programa que invierte un arreglo");

        int[] numeros = new int[6]{1, 2, 3, 4, 5, 6};
        
        Console.WriteLine("El orden invertidos de los numeros es: ");
        for (int i = numeros.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}
