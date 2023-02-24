using System;
using PierresBakery.Models;

namespace Pierres_Bakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("~~~~~~~~~~~~~~~~~Welcome to Pierre's~~~~~~~~~~~~~~~");
      OrderForm currentOrder = new OrderForm(0, 0);

      Console.WriteLine("- - - - - - - - - - Our Menu: - - - - - - - - - - -");
      Console.WriteLine("Loaf of Bread - $5ea.");
      Console.WriteLine("Pastry    -     $2ea.");
      Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - ");
      Console.WriteLine("T");
      Console.WriteLine("Pastry    -     $2ea.");
      // Console.WriteLine("How many loaves of bread would you like?");
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
      Console.WriteLine($"Total cost                              = ${totalCost}");

      Console.WriteLine("Would you like to Place your Order now? (Yes/No)");
      string placeOrder = Console.ReadLine().ToLower();
      if (placeOrder == "Yes")
      {
        Console.WriteLine("Thank you for your order! Press any key to exit.");
        Console.ReadKey();
      }
      else
      {
        Console.Write("Okay, let's start again!");
        Console.Write("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Main();
      }

    }
  }
}