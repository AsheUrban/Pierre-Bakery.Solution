using System;
// using System.Collections.Generic;
// using System.Linq;

namespace Bakery.Models
{
  public class Bread
  {
    private int _Price = 5;
    public int Quantity;

    //Public auto-implemented properties will go here!

    //Constructor will go here!

    public Bread(int quantity)
    {
      Quantity = quantity;
    }

    public bool IsBread()
    {
      return true;
    }
  
    public int CostOfBread()
    {
      int breadTotal = 0;
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
