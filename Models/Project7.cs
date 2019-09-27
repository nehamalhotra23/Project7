using System;


namespace Bakery
{
    public class Bread
    {
        public int Price { get; set; }
        public int Quantity { get; set; }

        public Bread(int Quantity) {
            Quantity = 0;
    
       }
        public int  DecidePrice(int getActualQuantity)  {
           return  AddQuantity(getActualQuantity);
            
        }

       public int AddQuantity(int getActualQuantity) {
           return Quantity += getActualQuantity;
            
       }
       
    }

    public class Pastery {

        public int PasteryPrice { get; set; }
        public int PasteryQuantity { get; set; }

        public Pastery(int PasteryQuantity) {
            PasteryQuantity = 0;
    }

        public int  DecidePasteryPrice(int getActualQuantityPas)  {
            
            return AddQuantityOfPastery(getActualQuantityPas);
        }

       public int AddQuantityOfPastery(int getActualQuantityPas) {
           return  PasteryQuantity += getActualQuantityPas;
            
       }
       
    }


    }
    
