
namespace PierresBakery.Models
{
  public class Pastry
  {
    public int Price { get; set; }
    public int Quantity { get; set; }
    public Pastry(int quantity)
    {
      Price = 2;
      Quantity = quantity;
    }
        public int PastryTotal()
    {
      int totalCost = Price * Quantity;
      if (Quantity >= 4)
      {
        int discount = (Quantity / 4) * Price;
        totalCost -= discount;
      }
      return totalCost;
    }
  }
}