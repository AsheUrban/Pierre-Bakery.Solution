using System;
// using System.Collections.Generic;
// using System.Linq;

namespace Bakery.Models
{
  public class Bread
  {
    private static double _Price = 5;
    private double _FreeLoaf;
    public int Quantity { get; set; }


    public static double Price
    {
      get { return _Price; }
      set { _Price = value; }
    }

    public Bread(int quantity)
    {
      Quantity = quantity;
      _FreeLoaf = 5;
      _Price = Price;
    }

    public bool IsBread()
    {
      return true;
    }
  
    public double CostOfBread()
    {
      double breadTotal = 0;
      for (int index = 0; index <= Quantity; index ++)
      {
        if (index == 0)
        {
          breadTotal += 0;
        }
        else if (index == 3)
        {
          breadTotal += _Price - _FreeLoaf;
        }
        else
        {
          breadTotal += _Price;
        }
      }
      return breadTotal;
    }
   
  }
}
