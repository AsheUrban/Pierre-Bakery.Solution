using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void IsPastry_CostofOnePastry_True()
    {
      Pastry pastryOrder = new Pastry();
      Assert.AreEqual(true, pastryOrder.IsPastry());
    }

  }

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
      double breadCost = 5;
      Bread breadOrder = new Bread(breadQuantity);
      Assert.AreEqual(breadCost, breadOrder.CostOfBread());
    }

    [TestMethod]
    public void CostOfBread_CostOfTwoLoaves_Int()
    {
      int breadQuantity = 2;
      double breadCost = 10;
      Bread breadOrder = new Bread(breadQuantity);
      Assert.AreEqual(breadCost, breadOrder.CostOfBread());
    }

    [TestMethod]
    public void CostOfBread_ThirdLoafIsFree_Int()
    {
      int breadQuantity = 3;
      double costOfBread = 10;
      Bread breadOrder = new Bread(breadQuantity);
      Assert.AreEqual(costOfBread, breadOrder.CostOfBread());
    }
  }
}