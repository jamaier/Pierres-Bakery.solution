
namespace PierresBakery.Models;

public class OrderForm
{
    public Bread BreadOrder { get; set; }

    public OrderForm(int breadQuantity)
    {
      BreadOrder = new Bread(breadQuantity);
    }
        public int TotalCost()
    {
      return BreadOrder.BreadTotal();
    }
}