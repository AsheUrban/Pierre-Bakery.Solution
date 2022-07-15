using System;

namespace Bakery.Models
{
  public class Pastry
  {
    private static int _Price = 2;
    private int _Discount = 1;
    public int PastryQuantity { get; set; }

    public static int Price
    {
      get { return _Price; }
      set {_Price = value; }
    }

    public Pastry(int pastryQuantity)
    {
      PastryQuantity = pastryQuantity;
      // _Discount = 1;
      _Price = Price;
    }

    public bool IsPastry()
    {
      return true;
    }


    public int CostOfPastry()
    {
      int pastryTotal = 0;
      for (int index = 0; index <= PastryQuantity; index ++)
      {
        if (index == 0)
        {
          pastryTotal += 0;
        }
        else if (index == 3 || index == 4 || index == 5 || index == 9)
        {
          pastryTotal += _Price - _Discount;
        }
        else
        {
          pastryTotal += _Price;
        }
      }
      return pastryTotal;
    }

    
 


  }
}