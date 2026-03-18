namespace Laboratorium_1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("liczba przedmiotow: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("seed: ");
        int seed = int.Parse(Console.ReadLine());

        Console.Write("pojemnosc plecaka: ");
        int capacity = int.Parse(Console.ReadLine());

        Algorithm algorithm = new Algorithm(n, seed);

        Console.WriteLine();
        Console.WriteLine("przedmioty:");
        Console.WriteLine(algorithm);

        Problem result = algorithm.Solve(capacity);

        Console.WriteLine(result);
    }
}