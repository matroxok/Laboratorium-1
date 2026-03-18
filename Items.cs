namespace Laboratorium_1;

public class Items
{
   public int Id { get; set; }
   public int Weight { get; set; }
   public int Price { get; set; }

   public double ValueToPriceRatio
   {
      get {return (double)Price / Weight;}
   }

   public Items(int id, int weight, int price)
   {
      Id = id;
      Weight = weight;
      Price = price;
   }
   
   public override string ToString()
   {
      return $"{Id} ---- {Weight} ---- {Price} ---- {ValueToPriceRatio}";
   }
}