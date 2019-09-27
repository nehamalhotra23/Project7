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
       Console.WriteLine("Offer Price: Buy 2 Get 1 Bread free and 'Buy 3 Pastery for $5' ");
       Console.WriteLine("--------------------");
       Console.WriteLine("What's your order? BREAD or Pastery");
       string UserInput = Console.ReadLine();
        
    //  Bread newBread = new Bread(OrderNumber);

       if (UserInput == "Bread" || UserInput == "bread") {
            Console.WriteLine("How many Loaf of bread you want?");
            string OrderQuantity =  Console.ReadLine();
            int OrderNumber = int.Parse(OrderQuantity);
         
         if (OrderNumber == 2 || OrderNumber == 1) {
           Console.WriteLine("$5");
        }
            
       } else {
            Console.WriteLine("Pastery");
       }

       
    //     else if (OrderNumber > 2) {
    //     newBread.DecidePrice(OrderNumber);
    //      Console.WriteLine(outPut);
    //    }
   
       }
    }
