using System;
using Bakery;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
       Console.WriteLine("WELCOME TO TASTY BAKERY");
       Console.WriteLine("--------------------");
       Console.WriteLine("Price of Single Loaf of bread is $5 and Pastery is $2");
       Console.WriteLine("--------------------");
       Console.WriteLine("Offer Price: Buy 2 Get 1 Bread free");
       Console.WriteLine("--------------------");
       Console.WriteLine("How many loafs of bread you want?");
       string OrderQuantity =  Console.ReadLine();
       
        Console.WriteLine("How many pasteries you want?");
        string OrderQuantityTwo =  Console.ReadLine();
        
        Regex regex = new Regex("^[0-9]+$");
        Match wordMatch = regex.Match(OrderQuantity);
        Match sentenceMatch = regex.Match(OrderQuantityTwo);

        if (wordMatch.Success && sentenceMatch.Success) {
        int OrderNumber = int.Parse(OrderQuantity);
        Bread newBread = new Bread(OrderNumber);
        int breadPrice = newBread.DecidePrice();
        int breadDiscount = newBread.CalculateDiscount();
        int OrderNumberPastery = int.Parse(OrderQuantityTwo);
        Pastery newPastery = new Pastery(OrderNumberPastery);
        int pasteryPrice = newPastery.DecidePasteryPrice();
        Console.WriteLine($"Your total Order Price is {breadDiscount + pasteryPrice}");

      } else {
          Console.WriteLine("------------");
          Console.WriteLine("INVALID INPUT");
          Main();
      }

    }
}
