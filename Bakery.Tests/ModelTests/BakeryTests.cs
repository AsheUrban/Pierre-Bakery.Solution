using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.TestTools
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void IsBread_CostOfOneLoaf_True()
    {
      int breadQuantity = 1;
      Bread breadOrder = new Bread(breadQuantity);
      Assert.AreEqual(true, breadOrder.IsBread());
    }
    
    [TestMethod]
    public void CostOfBread_CostOfOneLoaf_Int()
    {
      int breadQuantity = 1;
      int breadCost = 5;
      Bread breadOrder = new Bread(breadQuantity);
      Assert.AreEqual(breadCost, breadOrder.CostOfBread());
    }

    [TestMethod]
    public void CostOfBread_CostOfTwoLoaves_Int()
    {
      int breadQuantity = 2;
      int breadCost = 10;
      Bread breadOrder = new Bread(breadQuantity);
      Assert.AreEqual(breadCost, breadOrder.CostOfBread());
    }
  }
}