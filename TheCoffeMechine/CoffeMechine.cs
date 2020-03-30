using System;

namespace TheCoffeMechine
{
    class CoffeMechine
    {
        private CoffePowder CoffePowder;
        private WaterGalon waterGalon;
        private Milk Milk;

        public CoffeMechine(CoffePowder powder, WaterGalon galon, Milk milk) 
        {
            this.waterGalon = galon;
            this.CoffePowder = powder;
            this.Milk = milk;
        }

        public String makeEspresso() 
        {
            if (!this.waterGalon.isAvailable())
            {
                return "Sorry, the water is empty";
            }
            if(!this.CoffePowder.isAvailable()) 
            {
                return "Sorry, the coffe is empty";
            }

            this.waterGalon.makeOneCup();
            this.CoffePowder.makeOneCup();
            return "Yey! your Espresso is ready";
        }
        public String makeCappucino()
        {
            if (!this.waterGalon.isAvailable())
            {
                return "Sorry, the water is empty";
            }
            if (!this.CoffePowder.isAvailable())
            {
                return "Sorry, the coffe is empty";
            }
            if (!this.CoffePowder.isAvailable())
            {
                return "Sorry, the milk is empty";
            }

            this.waterGalon.makeOneCup();
            this.CoffePowder.makeOneCup();
            this.Milk.makeOneCup();
            return "Yey! your Cappucino is ready";
        }
        public String checkAvailability() {
            return $"the water :{this.waterGalon.getVolume()} and the coffe powder : {this.CoffePowder.getNetto()}, and the milk : {this.Milk.getVolume()}";
        }
    }
}
