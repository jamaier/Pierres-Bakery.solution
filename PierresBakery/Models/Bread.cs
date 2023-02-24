
namespace PierresBakery.Models
{
  public class Bread
  {
    public int Price { get; set; }
    public int Quantity { get; set; }
    public Bread(int quantity)
    {
      Price = 5;
      Quantity = quantity;
    }
    public int BreadTotal()
    {
      int totalCost = Price * Quantity;
      if (Quantity >= 3)
      {
        int discount = (Quantity / 3) * Price;
        totalCost -= discount;
      }
      return totalCost;
    }
  }
}