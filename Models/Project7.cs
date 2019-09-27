using System;


namespace Bakery
{
    public class Bread
    {
        public int Price { get; set; }
        public int Quantity { get; set; }

        public Bread(int Quantity) {
            Price = 5;
            Quantity = 0;
    

        }

        public void DecidePrice(int getActualQuantity)  {
            
            AddQuantity(getActualQuantity);
            AddTotalPrice(Price);
            

        }

       public void AddQuantity(int getActualQuantity) {
            Quantity += getActualQuantity;
            
       }

       public void AddTotalPrice(int price) {
           price = Price * Quantity;
       }
       
    }
    
}