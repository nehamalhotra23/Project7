using System;
namespace Bakery
{
    public class Bread
    {
        public int Quantity { get; set; }
        public int Price { get; set;} = 5;

        public Bread(int quantity) {
            Quantity = quantity;
    
        }
        public int  DecidePrice()  {
            return (Quantity * Price) - CalculateDiscount();
            
        }

        public int CalculateDiscount() {
            return (Quantity * Price * 75 /100);
        }

       
    }
    public class Pastery 
    {
        public int Pquantity { get; set; }
         public int Ppastery { get; set;} = 2;

        public Pastery(int pquantity) {
            Pquantity = pquantity;
          
        }
        public int  DecidePasteryPrice()  {
          return (Pquantity * Ppastery);
        }
       
    }
}
    
