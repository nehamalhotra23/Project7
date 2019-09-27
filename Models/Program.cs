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
        
       if (UserInput == "Bread" || UserInput == "bread") {
        Console.WriteLine("How many Loaf of bread you want?");
        string OrderQuantity =  Console.ReadLine();
        int OrderNumber = int.Parse(OrderQuantity);
        Bread newBread = new Bread(OrderNumber);
         
         if (OrderNumber == 2 || OrderNumber == 1) {
           Console.WriteLine("$5");
        } else {
           newBread.DecidePrice(OrderNumber);
        }
            
       } else if (UserInput == "Pastery" || UserInput == "pastery") {
            Console.WriteLine("How many pasteries you want?");
            string OrderQuantityTwo =  Console.ReadLine();
            int OrderNumberPastery = int.Parse(OrderQuantityTwo);


       }

       
    
   
       }
    }
