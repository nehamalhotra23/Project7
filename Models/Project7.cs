using System;


namespace Bakery
{
    public class Bread
    {
        public int Price { get; set; }
        public int Quantity { get; set; }

        public Bread(int Quantity, int Price) {
            Price = 0;
            Quantity = 0;
    

        }

        public void DecidePrice(int getActualQuantity, int getTotalPrice)  {
            AddPrice();
            AddQuantity(getActualQuantity);
            AddTotalPrice(getTotalPrice);
            

        }

       public void AddPrice()
       {
          Price = Price + 5;
       }

       public void AddQuantity(int getActualQuantity) {
            Quantity += getActualQuantity;
            
       }

       public int AddTotalPrice(int getTotalPrice) {
          return Price * getActualQuantity;
       }
       
    }
    
}