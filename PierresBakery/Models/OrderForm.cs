
namespace PierresBakery.Models;

public class OrderForm
{
  public Bread BreadOrder { get; set; }
  public Pastry PastryOrder { get; set; }


  public OrderForm(int breadQuantity, int pastryQuantity)
  {
    BreadOrder = new Bread(breadQuantity);
    PastryOrder = new Pastry(pastryQuantity);
  }
  public int TotalCost()
  {
    return BreadOrder.BreadTotal() + PastryOrder.PastryTotal();
  }
}