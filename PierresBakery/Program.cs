using System;
using PierresBakery.Models;

namespace Pierres_Bakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      Console.WriteLine("~~~~~~~~~~~~~~Welcome to Pierre's~~~~~~~~~~~~~~~~~~");
      Console.WriteLine("");
      Console.WriteLine("- - - - - - - - - - Our Menu: - - - - - - - - - - -");
      Console.WriteLine("Loaf of Bread - $5ea.");
      Console.WriteLine("Pastry    -     $2ea.");
      Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - ");
      Console.WriteLine("");
      Console.WriteLine("****************Todays Deals***********************");
      Console.WriteLine("Bread -- Buy TWO get ONE FREE!");
      Console.WriteLine("Pastry - Buy THREE get ONE FREE!");
      Console.WriteLine("***************************************************");
      Console.WriteLine("");

      OrderForm currentOrder = new OrderForm(0, 0);
      int breadInput = 0;
      int pastryInput = 0;

      try
      {
        Console.WriteLine("How many loaves of bread would you like?");
        breadInput = int.Parse(Console.ReadLine());
        Console.WriteLine("How many Pastries would you like?");
        pastryInput = int.Parse(Console.ReadLine());
      }
      catch (Exception)
      {
        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        Console.WriteLine("Error: Invalid input. Please enter a valid Number value.");
        Console.WriteLine("Please start again.");
        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        // timer = new System.Timers.Timer(4000); want to figure out a delay in restart.
        Main();
      }

      currentOrder.BreadOrder = new Bread(breadInput);
      currentOrder.PastryOrder = new Pastry(pastryInput);

      int breadPrice = currentOrder.BreadOrder.Price;
      int pastryPrice = currentOrder.PastryOrder.Price;

      int breadTotal = currentOrder.BreadOrder.BreadTotal();
      int pastryTotal = currentOrder.PastryOrder.PastryTotal();

      int totalCost = breadTotal + pastryTotal;

      Console.WriteLine("====================================================");
      Console.WriteLine("Order Summary:");
      Console.WriteLine($"Bread x {breadInput} @ ${breadPrice}  = ${breadTotal}");
      Console.WriteLine($"Pastry x {pastryInput} @ ${pastryPrice} = ${pastryTotal}");
      Console.WriteLine($"Total cost      = ${totalCost}");
      Console.WriteLine("====================================================");

      Console.WriteLine("Would you like to place your order now? (YES/NO)");
      string placeOrder = Console.ReadLine().ToLower();

      while (placeOrder != "yes" && placeOrder != "no")
      {
        Console.WriteLine("Invalid input. Please enter YES or NO.");
        placeOrder = Console.ReadLine().ToLower();
      }

      if (placeOrder == "yes")
      {
        Console.WriteLine("Thank you for your order!");
      }
      else
      {
        Console.WriteLine("___________________________________________________");
        Console.WriteLine("Okay, let's start again!");
        Main();
      }

      Console.WriteLine("Press any key to exit.");
      Console.ReadKey();
    }
  }
}

