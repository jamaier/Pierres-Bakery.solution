
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
  }
}