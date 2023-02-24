
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
    //Realizing this doesn't need to be in the test yet
    //     public int TotalCost()
    // {
    //   return BreadOrder.BreadTotal() + PastryOrder.PastryTotal();
    // }
}