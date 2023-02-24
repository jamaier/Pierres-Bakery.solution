using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.ModelsTests
{
  [TestClass]
  public class OrderFormTests
  {
    [TestMethod]
    public void OrderForm_CreateInstanceOfOrderForm_OrderForm()
    {
      OrderForm newOrder = new OrderForm(0);
      Assert.AreEqual(typeof(OrderForm), newOrder.GetType());
    }

    [TestMethod]
    public void OrderForm_GetTotalQuantitiesForBread_OrderForm()
    {
      int breadQuantity = 2;
      Bread newBread = new Bread(breadQuantity);
      OrderForm newOrder = new OrderForm(breadQuantity);
      Assert.AreEqual(newBread.Quantity, newOrder.BreadOrder.Quantity);
    }
  }
}