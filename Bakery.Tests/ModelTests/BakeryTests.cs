using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.TestTools
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void CostOfBread_CostOfOneLoaf_Int()
    {
      // //Arrange
      // int breadQuantity = 1;
      int breadCost = 5;
      // ACT
      Bread breadOrder = new Bread();
      // ASSERT GOES HERE!
      Assert.AreEqual(breadCost, breadOrder.CostOfBread());
    }
  }
}