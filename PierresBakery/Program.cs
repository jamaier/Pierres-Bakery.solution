using System;
using PierresBakery.Models;

namespace Pierres_Bakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("~~~~~~~~Welcome to Pierre's~~~~~~~");
      Console.WriteLine("");
      Console.WriteLine("- - - - - - - - - - Our Menu: - - - - - - - - - - -");
      Console.WriteLine("Loaf of Bread - $5ea.");
      Console.WriteLine("Pastry    -     $2ea.");
      Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - ");
      Console.WriteLine("");
      Console.WriteLine("****************Todays Deals************************");
      Console.WriteLine("Bread -- Buy TWO get ONE FREE!");
      Console.WriteLine("Pastry - Buy THREE get ONE FREE!");
      Console.WriteLine("****************************************************");
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
        Console.WriteLine("Error: Invalid input. Please enter a valid Number value. Please start again.");
        Main();
      }

      currentOrder.BreadOrder = new Bread(breadInput);
      currentOrder.PastryOrder = new Pastry(pastryInput);

      int breadPrice = currentOrder.BreadOrder.Price;
      int pastryPrice = currentOrder.PastryOrder.Price;

      int breadTotal = currentOrder.BreadOrder.BreadTotal();
      int pastryTotal = currentOrder.PastryOrder.PastryTotal();

      int totalCost = breadTotal + pastryTotal;

      Console.WriteLine("=========================================================");
      Console.WriteLine($"Order Summary:");
      Console.WriteLine($"Bread x {breadInput} @ ${breadPrice}    = ${breadTotal}");
      Console.WriteLine($"Pastry x {pastryInput} @ ${pastryPrice} = ${pastryTotal}");
      Console.WriteLine($"Total cost          = ${totalCost}");

      Console.WriteLine("Would you like to place your order now? (YES/NO)");
      ConfirmOrder();
    }
    static void ConfirmOrder()
    {
      string placeOrder = Console.ReadLine().ToLower();
      if (placeOrder == "yes")
      {
        Console.WriteLine("Thank you for your order! Press any key to exit.");
        return;
      }
      else
      {
        Console.Write("Okay, let's start again!");
        Console.Write("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Main();
      }
      Console.ReadKey();
    }
  }
}

