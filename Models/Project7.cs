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

        public void  DecidePrice(int getActualQuantity)  {
            
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

    public class Pastery {

        public int PasteryPrice { get; set; }
        public int PasteryQuantity { get; set; }

        public Pastery(int PasteryQuantity) {
            PasteryPrice = 2;
            PasteryQuantity = 0;
    

        }

        public void  DecidePasteryPrice(int getActualQuantityPas)  {
            
            AddQuantityOfPastery(getActualQuantityPas);
            AddTotalPasteryPrice(PasteryPrice);
            

        }

       public void AddQuantityOfPastery(int getActualQuantityPas) {
            PasteryQuantity += getActualQuantityPas;
            
       }

       public void AddTotalPasteryPrice(int pasteryPrice) {
           pasteryPrice = PasteryPrice * PasteryQuantity;
       }
       
    }


    }
    
