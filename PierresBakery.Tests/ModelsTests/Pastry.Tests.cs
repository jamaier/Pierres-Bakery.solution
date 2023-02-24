using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pastry.Models;


namespace Pastry.ModelsTests
{
  [TestClass]
  public class PastryTests
  {
        [TestMethod]
    public void Bread_CreateInstanceOfBread_Bread()
    {
      PastryTypes newPastry = new PastryTypes();
      Assert.AreEqual(typeof(PastryTypes), newPastry.GetType());
    }
  }
}