namespace Laboratorium_1;
using System.Text;

public class Problem
{
    public List<int> Items { get; set; }
    public int PriceSum { get; set; }
    public int ValueSum { get; set; }

    public Problem()
    {
        Items = new List<int>();
        PriceSum = 0;
        ValueSum = 0;
    }

    public override string ToString()
    {
        // so - StringOutput 
        StringBuilder so = new StringBuilder();
        so.AppendLine("Wynik:");
        so.AppendLine("Wybrane przedmioty: " + string.Join(", ", Items));
        so.AppendLine("Suma wag: " + PriceSum);
        so.AppendLine("Suma wartosci: " + ValueSum);

        return so.ToString();
        
    }
}