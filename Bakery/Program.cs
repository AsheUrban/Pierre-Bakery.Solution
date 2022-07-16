using System;
// using System.Collections.Generic;
// using System.Linq;
using Bakery.Models;

namespace Bakery.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("A loaf of bread costs $" + Bread.Price);
      Console.WriteLine("Every third loaf of bread is FREE!");
      Console.WriteLine("Would you like a loaf of bread?");
      string response = Console.ReadLine();
      if (response == "yes")
      {
        Console.WriteLine("How many loaves of bread to you want?");
        int breadOrder = int.Parse(Console.ReadLine());
        Bread userBreadOrder = new Bread(breadOrder);
        Console.WriteLine("For " + userBreadOrder.BreadQuantity + " loaves of bread, your total is $" + userBreadOrder.CostOfBread());
      }
      else
      {
        Console.WriteLine("Thats Ok! How about a delicious pastry instead?");
      }

      Console.WriteLine("Would you like a pastry? Pastries are $2, OR buy anywhere from 3 - 8 and get a dollar, or two, off depending on quantity!");
      {
        Console.WriteLine("How many pastries do you want?");
        int pastryOrder = int.Parse(Console.ReadLine());
        Pastry userPastryOrder = new Pastry(pastryOrder);
        Console.WriteLine("For " + userPastryOrder.PastryQuantity + " pastries, your total is $" + userPastryOrder.CostOfPastry());
      }

    }
  }
}