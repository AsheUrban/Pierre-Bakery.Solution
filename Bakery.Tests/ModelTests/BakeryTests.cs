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
      int pastryQuantity = 1;
      Pastry pastryOrder = new Pastry(pastryQuantity);
      Assert.AreEqual(true, pastryOrder.IsPastry());
    }

    [TestMethod]
    public void CostOfPastry_CostOfOnePastry_Int()
    {
      int pastryQuantity = 1;
      int pastryCost = 2;
      Pastry pastryOrder = new Pastry(pastryQuantity);
      Assert.AreEqual(pastryCost, pastryOrder.CostOfPastry());
    }

    [TestMethod]
    public void CostOfPastry_CostOfThreePastries_Int()
    {
      int pastryQuantity = 3;
      int pastryCost = 5;
      Pastry pastryOrder = new Pastry(pastryQuantity);
      Assert.AreEqual(pastryCost, pastryOrder.CostOfPastry());
    }

    [TestMethod]
    public void CostOfPastry_CostOfMorePastries_Int()
    {
      int pastryQuantity = 4;
      int pastryCost = 7;
      Pastry pastryOrder = new Pastry(pastryQuantity);
      Assert.AreEqual(pastryCost, pastryOrder.CostOfPastry());
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
}