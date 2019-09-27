using System;
using Bakery;

class Program
{
    static void Main()
    {  

       Console.WriteLine("Price of Single Loaf of bread is $5 and Pastery is $2");
       Console.WriteLine("Offer Price: Buy 2 Get 1 Bread free and 'Buy 3 Pastery for $5' ");
       string OrderQuantity =  Console.ReadLine(); 
       int OrderNumber = int.Parse(OrderQuantity);
    //    int result = OrderQuantity;
       
       if (OrderNumber > 2 ) {
           Console.WriteLine("$5");
       }
    //    } else {
    //        return result;
    //    }
       }
    }
