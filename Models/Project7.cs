using System;


namespace Bakery
{
    public class Bread
    {
        public int Price { get; set; }
        public int Quantity { get; set; }

        public Bread(int Quantity, int TotalPrice) {
            Price = 0;
            Quantity = 0;
            TotalPrice = 0;

        }

        public void DecidePrice(int getActualQuantity)  {
            AddPrice();
            AddQuantity(getActualQuantity);
            ExitPrice(TotalPrice);


        }

       public void AddPrice()
       {
          Price += 5;
       }

       public void AddQuantity(int getActualQuantity) {
            Quantity += getActualQuantity;
       }
        
       public void ExitPrice(int TotalPrice) 
       {
           TotalPrice = Price * Quantity;
       }
    }
    
}