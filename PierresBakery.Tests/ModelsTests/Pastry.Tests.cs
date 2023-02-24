using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;


namespace PierresBakery.ModelsTests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void Pastry_CreateInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(0);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void Pastry_GetQuantityAndCostOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      int price = 2;
      int quantity = 1;
      Assert.AreEqual(price, newPastry.Price);
      Assert.AreEqual(quantity, newPastry.Quantity);
    }

    [TestMethod]
    public void Pastry_GetPastryDiscount_PastryTest2()
    {
      int quantity = 10;
      Pastry newPastry = new Pastry(quantity);
      int result = newPastry.PastryTotal();
      Assert.AreEqual(16, result);
    }
  }
}