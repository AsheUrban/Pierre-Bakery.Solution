using System;

namespace Bakery.Models
{
  public class Bread
  {
    private static double _Price = 5;
    private double _FreeLoaf;
    public int BreadQuantity { get; set; }


    public static double Price
    {
      get { return _Price; }
      set { _Price = value; }
    }

    public Bread(int breadQuantity)
    {
      BreadQuantity = breadQuantity;
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
      for (int index = 0; index <= BreadQuantity; index ++)
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
