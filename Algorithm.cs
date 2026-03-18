namespace Laboratorium_1;
using System.Text;
using System.Linq;

public class Algorithm
{
    public int ItemsNumber { get; set; }
    public List<Items> Items { get; set; }

    public Algorithm(int n, int seed)
    {
        ItemsNumber = n;
        Items = new List<Items>();

        Random random = new Random(seed);

        for (int i = 0; i < n; i++)
        {
            int value = random.Next(1, 11);
            int weight = random.Next(1, 11);

            Items.Add(new Items(i + 1, weight, value));
        }
    }

    public Algorithm(List<Items> items)
    {
        Items = items;
        ItemsNumber = items.Count;
    }

    public Problem Solve(int capacity)
    {
        Problem result = new Problem();

        var sortedItems = Items
            .OrderByDescending(p => p.ValueToPriceRatio)
            .ToList();

        foreach (var item in sortedItems)
        {
            if (result.PriceSum + item.Weight <= capacity)
            {
                result.Items.Add(item.Id);
                result.PriceSum += item.Weight;
                result.ValueSum += item.Price;
            }

            if (result.PriceSum == capacity)
            {
                break;
            }
        }

        return result;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"Liczba przedmiotow: {ItemsNumber}");
        sb.AppendLine("Lista przedmiotow:");

        foreach (var item in Items)
        {
            sb.AppendLine(item.ToString());
        }

        return sb.ToString();
    }
}