using System;
// using System.Collections.Generic;
// using System.Linq;

namespace Bakery.Models
{
  public class Bread
  {
    private static double _Price = 5;
    public int Quantity { get; set; }


    public static double Price
    {
      get { return _Price; }
      set { _Price = value; }
    }

    public Bread(int quantity)
    {
      Quantity = quantity;
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
        else
        {
          breadTotal += _Price;
        }
      }
      return breadTotal;
    }
   
  }
}
