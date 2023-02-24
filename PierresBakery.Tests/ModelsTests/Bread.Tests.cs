using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bread.Models;


namespace Bread.ModelsTests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void Bread_CreateInstanceOfBread_Bread()
    {
      BreadTypes newBread = new BreadTypes();
      Assert.AreEqual(typeof(BreadTypes), newBread.GetType());
    }
  }
}
