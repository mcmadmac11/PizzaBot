using System;
namespace PizzaBot
{     
    public abstract class FoodProduct: IAmEdible
    { 

        public abstract void Consumed();

        public abstract void Spoil();
        
	
	}
}
