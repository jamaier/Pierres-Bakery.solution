using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;


namespace PierresBakery.ModelsTests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void Bread_CreateInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(0);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void Bread_GetQuantityAndCostOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      int price = 5;
      int quantity = 1;
      Assert.AreEqual(price, newBread.Price);
      Assert.AreEqual(quantity, newBread.Quantity);
    }
  }
}
