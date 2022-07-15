using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryQuantity;

    public bool IsPastry()
    {
      return true;
    }

    public int CostOfPastry()
    {
      int pastryTotal = 2;
      for (int index = 0; index <= PastryQuantity; index ++)
      {
        if (index == 0)
        {
          pastryTotal += 0;
        }
        else
        {
          return pastryTotal;
        }
      }
      return pastryTotal;
    }

    
 


  }
}