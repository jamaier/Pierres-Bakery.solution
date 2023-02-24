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
      OrderForm newOrder = new OrderForm();
      Assert.AreEqual(typeof(OrderForm), newOrder.GetType());
    }
  }
}