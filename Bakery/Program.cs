using System;
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
      Console.WriteLine("Would you like a loaf of bread? (yes/no)");
      string response = Console.ReadLine();
      if (response == "yes" || response == "Yes")
      {
        Console.WriteLine("How many loaves of bread to you want?");
        int breadOrder = int.Parse(Console.ReadLine());
        Bread userBreadOrder = new Bread(breadOrder);
        Console.WriteLine("For " + userBreadOrder.BreadQuantity + " loaves of bread, your total is $" + userBreadOrder.CostOfBread());
      }
      else
      {
        Console.WriteLine("How about a delicious pastry instead?");
      }
        Console.WriteLine("Pastries are $2, OR buy anywhere from 3 - 8 and get a dollar, or two, off depending on quantity!");
        Console.WriteLine("Would you like a pastry? (yes/no)");
        string responseTwo = Console.ReadLine();
        if (responseTwo == "no" || responseTwo == "No")
      {
        Console.WriteLine("That's ok! Thank you for coming by!");
      }
      else
      {
        Console.WriteLine("How many pastries do you want?");
        int pastryOrder = int.Parse(Console.ReadLine());
        Pastry userPastryOrder = new Pastry(pastryOrder);
        Console.WriteLine("For " + userPastryOrder.PastryQuantity + " pastries, your total is $" + userPastryOrder.CostOfPastry());
      }
    }
  }
}
