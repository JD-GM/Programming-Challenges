using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {

        Random rand = new Random();

        int random = rand.Next(0,100);

        int number;

        int count = 0;

        do
        {
            count++;

            Console.WriteLine("Introduce un número:");

            number = int.Parse(Console.ReadLine());

            if (number < random) Console.WriteLine("Introduce un número mayor.");

            if (number > random) Console.WriteLine("Introduce un número menor.");

        } while (number != random);

        Console.WriteLine($"Correcto. Has consumido {count} intentos.");
     }
}