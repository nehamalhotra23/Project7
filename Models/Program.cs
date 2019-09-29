using System;
using Bakery;
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
        int OrderNumber = int.Parse(OrderQuantity);
        Bread newBread = new Bread(OrderNumber);

        Console.WriteLine("How many pasteries you want?");
        string OrderQuantityTwo =  Console.ReadLine();
        int OrderNumberPastery = int.Parse(OrderQuantityTwo);
        Pastery newPastery = new Pastery(OrderNumberPastery);

        int totalPricePastery = newPastery.DecidePasteryPrice(OrderNumberPastery * 2);
        
        Console.WriteLine("Total Order Price is " + newBread.DecidePrice(OrderNumber * 5 * 74 / 100 + totalPricePastery));
    }
}
