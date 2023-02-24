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
      OrderForm newOrder = new OrderForm(0,0);
      Assert.AreEqual(typeof(OrderForm), newOrder.GetType());
    }

    [TestMethod]
    public void OrderForm_GetTotalQuantitiesForBread_OrderForm()
    {
      int breadQuantity = 2;
      Bread newBread = new Bread(breadQuantity);
      OrderForm newOrder = new OrderForm(breadQuantity,0);
      Assert.AreEqual(newBread.Quantity, newOrder.BreadOrder.Quantity);
    }

    [TestMethod]
    public void OrderForm_GetTotalQuantitiesForBreadAndPastries_OrderForm()
    {
      int breadQuantity = 2;
      int pastryQuantity = 5;
      Bread newBread = new Bread(breadQuantity);
      Pastry newPastry = new Pastry(pastryQuantity);
      OrderForm newOrder = new OrderForm(breadQuantity, pastryQuantity);
      Assert.AreEqual(breadQuantity, newOrder.BreadOrder.Quantity);
      Assert.AreEqual(pastryQuantity, newOrder.PastryOrder.Quantity);
    }
  }
}